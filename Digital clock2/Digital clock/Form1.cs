using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_clock
{
    public partial class Form1 : Form
    {
        bool flag24 = true;
        public Form1()
        {
            InitializeComponent();
        }

        //fill the time lable with the current time
        private void timer_Tick(object sender, EventArgs e)
        {
            //check if the mode is 24 or 12
            if(flag24)
            {
                hour_and_min.Text = appendZero0.append(int.Parse(DateTime.Now.ToString("HH"))) + ":" + appendZero0.append(int.Parse(DateTime.Now.ToString("mm")));

            }
            else
            {
                hour_and_min.Text = appendZero0.append(int.Parse(DateTime.Now.ToString("hh"))) + ":" + appendZero0.append(int.Parse(DateTime.Now.ToString("mm")));

            }

            second.Text = appendZero0.append(int.Parse(DateTime.Now.ToString("ss")));
            date.Text = DateTime.Now.ToString("MMM dd yyyy");
            day.Text = DateTime.Now.ToString("dddd");

        }
        //change mode from 24 to 12 and vice versa
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMode.Visible = false;
            timer.Start();              
        }
        //click timer button show timer form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form4()).Show();
        }
        //click alarm button show larm form
        private void btnAlarm_Click(object sender, EventArgs e)
        {
            this.Hide();

            (new Form3()).Show();
        }
        //click stop whatch button show stop whatch form
        private void btnstopWatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            (new Form2()).Show();
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //change mode button text
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag24)
            {
                lblMode.Visible = true;
                //hour_and_min.Text = appendZero0.append(int.Parse(DateTime.Now.ToString("hh"))) + ":" + appendZero0.append(int.Parse(DateTime.Now.ToString("mm")));
                lblMode.Text = DateTime.Now.ToString("tt");
                flag24 = false;
                button1.Text = "24 Mode";
            }
            else
            {
                lblMode.Visible = false;
                flag24 = true;
                button1.Text = "12 Mode";
            }


        }
    }
}
