using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Digital_clock
{
    public partial class Form2 : Form
    {
     
        string readingval = "";
        int counter = 0;
        int milliseconds = 0;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        //connection string "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DigitalClockDB.accdb;Persist Security Info=False;"
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DigitalClockDB.accdb;Persist Security Info=False;");
           
        public Form2()
        {
            InitializeComponent();
        }
        //stop whach timer with 10 intervals each tic eaual 10 milliseconds
        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
           
            if(milliseconds>99)
            {
                seconds++;
                milliseconds = 0;
            }
            if(seconds>59)
            {
                minutes++;
                seconds = 0;
            }
            if(minutes>59)
            {
                hours++;
                minutes = 0;
            }
    
            hour_min_second.Text = appendZero0.append(hours) + ":" +appendZero0.append(minutes)+":"+appendZero0.append(seconds);
            millisecond.Text = appendZero0.append(milliseconds);
            milliseconds++;
        }
        //click button start start the tmer
        private void btnStart_Click(object sender, EventArgs e)
        {
            stopWatchTimer.Start();
        }
        //click stop button stop the timer and save the value in time label in the database in stopWatchTable
        private void btnStop_Click(object sender, EventArgs e)
        {
            stopWatchTimer.Stop();
         
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText="insert into [stopWatchTable](reading_value)values(@nm)";
            cmd.Parameters.AddWithValue("@nm", hour_min_second.Text+":"+millisecond.Text);
           
            cmd.Connection = conn;
           if (readingval!= hour_min_second.Text + ":" + millisecond.Text)
            try
            {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery();
                    readingval = hour_min_second.Text + ":" + millisecond.Text;
                
                }
            catch(Exception ex)
            {


                }



        }
        //click restart button restart the timer and save the value in time label in the database in stopWatchTable

        private void btnRestart_Click(object sender, EventArgs e)
        {
            stopWatchTimer.Stop();
            milliseconds = seconds = minutes = hours = 0;
            hour_min_second.Text = appendZero0.append(hours) + ":" + appendZero0.append(minutes) + ":" + appendZero0.append(seconds);
            millisecond.Text = appendZero0.append(milliseconds);
       
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "insert into [stopWatchTable](reading_value)values(@nm)";
            cmd.Parameters.AddWithValue("@nm", hour_min_second.Text + ":" + millisecond.Text);

            cmd.Connection = conn;
            if (readingval != hour_min_second.Text + ":" + millisecond.Text)
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery();
                    readingval = hour_min_second.Text + ":" + millisecond.Text;
                  
                }
                catch (Exception ex)
                {
                 
                }
           
        }
        //close the form and open the main form 
        private void closeStopWatch(object sender, FormClosingEventArgs e)
        {
            (new Form1()).Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           
            //dataGridView1.Rows.Add(dataset);

        }
    }
}
