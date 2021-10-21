
namespace Digital_clock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hour_and_min = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnstopWatch = new System.Windows.Forms.Button();
            this.btnCounterDown = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hour_and_min
            // 
            this.hour_and_min.AutoSize = true;
            this.hour_and_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hour_and_min.Font = new System.Drawing.Font("DS-Digital", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_and_min.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hour_and_min.Location = new System.Drawing.Point(130, 140);
            this.hour_and_min.Name = "hour_and_min";
            this.hour_and_min.Size = new System.Drawing.Size(346, 134);
            this.hour_and_min.TabIndex = 1;
            this.hour_and_min.Text = "22:22";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.second.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.second.Location = new System.Drawing.Point(472, 209);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(91, 65);
            this.second.TabIndex = 2;
            this.second.Text = "22";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.date.Location = new System.Drawing.Point(54, 316);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(249, 49);
            this.date.TabIndex = 3;
            this.date.Text = "MAY 30 2021";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.day.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.day.Location = new System.Drawing.Point(450, 316);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(166, 49);
            this.day.TabIndex = 4;
            this.day.Text = "SUNDAY";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnstopWatch
            // 
            this.btnstopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstopWatch.Location = new System.Drawing.Point(53, 31);
            this.btnstopWatch.Name = "btnstopWatch";
            this.btnstopWatch.Size = new System.Drawing.Size(176, 36);
            this.btnstopWatch.TabIndex = 5;
            this.btnstopWatch.Text = "STOP WATCH";
            this.btnstopWatch.UseVisualStyleBackColor = true;
            this.btnstopWatch.Click += new System.EventHandler(this.btnstopWatch_Click);
            // 
            // btnCounterDown
            // 
            this.btnCounterDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounterDown.Location = new System.Drawing.Point(472, 31);
            this.btnCounterDown.Name = "btnCounterDown";
            this.btnCounterDown.Size = new System.Drawing.Size(143, 36);
            this.btnCounterDown.TabIndex = 6;
            this.btnCounterDown.Text = "TIMER";
            this.btnCounterDown.UseVisualStyleBackColor = true;
            this.btnCounterDown.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarm.Location = new System.Drawing.Point(263, 31);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(157, 36);
            this.btnAlarm.TabIndex = 7;
            this.btnAlarm.Text = "SET ALARM";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "12 Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMode.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMode.Location = new System.Drawing.Point(472, 140);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(91, 65);
            this.lblMode.TabIndex = 9;
            this.lblMode.Text = "AM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(692, 409);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.btnCounterDown);
            this.Controls.Add(this.btnstopWatch);
            this.Controls.Add(this.day);
            this.Controls.Add(this.date);
            this.Controls.Add(this.second);
            this.Controls.Add(this.hour_and_min);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hour_and_min;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnstopWatch;
        private System.Windows.Forms.Button btnCounterDown;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMode;
    }
}

