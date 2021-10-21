using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;
namespace Digital_clock
{
   
    public partial class Form3 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DigitalClockDB.accdb;Persist Security Info=False;");
        
        
        string tim = "ttt";
        SoundPlayer music;
        static int counter =1;
        public Form3()
        {
            InitializeComponent();
        }

        private void closeAlarm(object sender, FormClosingEventArgs e)
        {
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }
        delegate void updatelabel(Label label,string value);
        //load form and oppen connection with database
        private void Form3_Load(object sender, EventArgs e)
        {
            currentTimer.Start();
            conn.Open();
        }
        
        private void timerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
      
        }
        //save alarm in database in alarmTable
        private void saveAlarm_Click(object sender, EventArgs e)
        {
          //initialze command  to save the value of time in timer picker in the database
            OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "insert into [alarmTable](alarmTime)values(@nm)";
                cmd.Parameters.AddWithValue("@nm", timerPicker.Value);

                cmd.Connection = conn;
            DateTime userTime =timerPicker.Value;

            DateTime nowTime = DateTime.Now;
            if (userTime<nowTime)
            {
                MessageBox.Show("The alarm you trying to add is passed");
                return;
            }
            //print the time remaining 
                status.Text = "Remaining time " + (  userTime.Day- nowTime.Day).ToString()+" days "+( userTime.Hour- nowTime.Hour).ToString()+" hours "+  (userTime.Minute- nowTime.Minute).ToString()+" minutes "+ (userTime.Second- nowTime.Second).ToString()+" seconds.";
            //save the alarm time in the database
                try
                {

                    cmd.ExecuteNonQuery();
                    tim = timerPicker.Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Alarm was already saved");
                }
              finally
            {
                currentTimer.Start();
            }
          
        }
        //click ok button stop the music and delete the alarm time from the data base and close alarm form and open the main form
        private void cancelAlarm_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (!(status.Text == "Running..."))
                return;
            music.Stop();
            //if (tim == timerPicker.Value.ToString())
            //    return;
            OleDbCommand cmd4 = new OleDbCommand("select * from alarmTable", conn);
            OleDbDataReader reader = cmd4.ExecuteReader();
            reader.Read();



            //initialize command to insert the new updated alarm into database after addning snooze time to it
            OleDbCommand cmd3 = new OleDbCommand();
                cmd3.CommandText = "insert into [alarmTable](alarmTime)values(@lm)";
                System.DateTime timm =( (System.DateTime)reader.GetValue(0)).AddMinutes(1);
                cmd3.Parameters.AddWithValue("@lm", timm);

            cmd3.Connection = conn;
            try
            {
                cmd3.ExecuteNonQuery();
           

            }
            catch (Exception exx)
            {

               
            }
            finally
            {
                status.Text = "Snoozed";
                //delete the alarm time after update it 
                OleDbCommand cmd2 = new OleDbCommand("select * from alarmTable", conn);
                OleDbDataReader reader2 = cmd2.ExecuteReader();
                reader2.Read();
                //cmd2.ExecuteReader();
                string querey = "delete from alarmTable where alarmTime=@tv";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Parameters.AddWithValue("@tv", reader.GetValue(0));
                cmd.Connection = conn;
                cmd.CommandText = querey;
                cmd.ExecuteNonQuery();
            }
         
        
        }

        private void currentTimer_Tick(object sender, EventArgs e)
        {




            OleDbCommand cmd = new OleDbCommand("select * from alarmTable", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            //reader.Read();

            while(reader.Read() == true)
            {

                DateTime userTime = ((System.DateTime)(reader[0]));

                DateTime nowTime = DateTime.Now;
                //check if now time equal alarm time
                if (nowTime.Day == userTime.Day &&
                   nowTime.Hour == userTime.Hour &&
                   nowTime.Minute == userTime.Minute &&
                   nowTime.Second == userTime.Second)
                {
                    //starting play music
                    try
                    {
                        music = new SoundPlayer();
                        music.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                        status.Text = "Running...";
                        music.PlayLooping();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error can't get music file");
                    }

                }
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (!(music == null))
                music.Stop();
                (new Form1()).Show();
            
           
        }
        //click ok button stop the music and delete the alarm time from the data base and close alarm form and open the main form

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            if (status.Text== "Running...")
            {
                //initialize command to delete alarm from database
                OleDbCommand cmd2 = new OleDbCommand("select * from alarmTable", conn);
                OleDbDataReader reader = cmd2.ExecuteReader();
                reader.Read();
                
                string querey = "delete from alarmTable where alarmTime=@tv";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Parameters.AddWithValue("@tv", reader.GetValue(0));
                cmd.Connection = conn;
                cmd.CommandText = querey;
                cmd.ExecuteNonQuery();
                music.Stop();
              
                this.Hide();
                (new Form1()).Show();
            }
    
          
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
        
        }
    }
}
