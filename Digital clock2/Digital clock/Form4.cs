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
    public partial class Form4 : Form
    {
        static int valueOfSeconds=0
            ,valueOfMinutes=0
           ,valueOfHours=0;
        //restart the time but from the values in text boxes
        private void reStart()
        {
            try
            {
                if (int.Parse(txtHour.Text) < 100 && int.Parse(txtHour.Text) >= 0 && int.Parse(txtMinute.Text) < 60 && int.Parse(txtMinute.Text) >= 0 && int.Parse(txtSecond.Text) < 60 && int.Parse(txtSecond.Text) >= 0)
                {
                    hour_min_second.Text = appendZero0.append(int.Parse(txtHour.Text)) + ":" + appendZero0.append(int.Parse(txtMinute.Text)) + ":" + appendZero0.append(int.Parse(txtSecond.Text));
                    valueOfHours = int.Parse(txtHour.Text);
                    valueOfMinutes = int.Parse(txtMinute.Text);
                    valueOfSeconds = int.Parse(txtSecond.Text);
                    hour_min_second.ForeColor = Color.White;
                    countDownTimer.Start();
                }
                else
                {
                    MessageBox.Show("value of hours should be less than 100 and greater than or equal zero\nvalue of minutes should be less than 60 and greater than or equal zero\nvalue of seconds should be less than 60 and greater than or equal zero");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("value of hours should be less than 100 and greater than or equal zero\nvalue of minutes should be less than 60 and greater than or equal zero\nvalue of seconds should be less than 60 and greater than or equal zero");

            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void hour_min_second_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        //call function start
        private void btnStart_Click(object sender, EventArgs e)
        {

            reStart();
        }
        //stop the timer
        private void btnStop_Click(object sender, EventArgs e)
        {
            countDownTimer.Stop();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if(valueOfHours==0&&valueOfMinutes==0&&valueOfSeconds==0)
            {
                reStart();
            }
            else
            {
               countDownTimer.Start();
            }
        }

        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //close the form
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            (new Form1()).Show();
        }
        //each tic equal 1 second
        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            valueOfSeconds --;

            if (valueOfSeconds==-1&&valueOfMinutes>0)
            {
                valueOfMinutes--;
                valueOfSeconds = 59;
            }
            else if(valueOfSeconds == -1&&valueOfMinutes==0&&valueOfHours>0)
            {
                valueOfHours--;
                valueOfMinutes = 59;
                valueOfSeconds = 59;
            }
            else if (valueOfSeconds == -1 && valueOfMinutes == 0 && valueOfHours ==0)
            {
                valueOfHours=0;
                valueOfMinutes = 0;
                valueOfSeconds = 0;
                countDownTimer.Stop();
            }
            if (valueOfSeconds <= 59 && valueOfMinutes == 0 && valueOfHours == 0)
            {
                //change text color in time table if the still time less than one second
                hour_min_second.ForeColor = Color.Red;
            }
            hour_min_second.Text = appendZero0.append(valueOfHours) + ":" + appendZero0.append(valueOfMinutes) + ":" + appendZero0.append(valueOfSeconds);

        }
    }
}
