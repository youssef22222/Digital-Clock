
namespace Digital_clock
{
    partial class Form3
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
            this.timerPicker = new System.Windows.Forms.DateTimePicker();
            this.saveAlarm = new System.Windows.Forms.Button();
            this.snoozeAlarm = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerPicker
            // 
            this.timerPicker.CalendarForeColor = System.Drawing.SystemColors.Highlight;
            this.timerPicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.timerPicker.Font = new System.Drawing.Font("Dubai", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timerPicker.Location = new System.Drawing.Point(72, 22);
            this.timerPicker.Name = "timerPicker";
            this.timerPicker.Size = new System.Drawing.Size(382, 116);
            this.timerPicker.TabIndex = 1;
            this.timerPicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // saveAlarm
            // 
            this.saveAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAlarm.Location = new System.Drawing.Point(12, 242);
            this.saveAlarm.Name = "saveAlarm";
            this.saveAlarm.Size = new System.Drawing.Size(165, 35);
            this.saveAlarm.TabIndex = 2;
            this.saveAlarm.Text = "SAVE ALARM";
            this.saveAlarm.UseVisualStyleBackColor = true;
            this.saveAlarm.Click += new System.EventHandler(this.saveAlarm_Click);
            // 
            // snoozeAlarm
            // 
            this.snoozeAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snoozeAlarm.Location = new System.Drawing.Point(362, 242);
            this.snoozeAlarm.Name = "snoozeAlarm";
            this.snoozeAlarm.Size = new System.Drawing.Size(146, 35);
            this.snoozeAlarm.TabIndex = 3;
            this.snoozeAlarm.Text = "SNOOZE";
            this.snoozeAlarm.UseVisualStyleBackColor = true;
            this.snoozeAlarm.Click += new System.EventHandler(this.cancelAlarm_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.status.Location = new System.Drawing.Point(42, 163);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 24);
            this.status.TabIndex = 4;
            // 
            // currentTimer
            // 
            this.currentTimer.Interval = 1000;
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(207, 242);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(128, 35);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "STOP";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(527, 375);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.status);
            this.Controls.Add(this.snoozeAlarm);
            this.Controls.Add(this.saveAlarm);
            this.Controls.Add(this.timerPicker);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeAlarm);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timerPicker;
        private System.Windows.Forms.Button saveAlarm;
        private System.Windows.Forms.Button snoozeAlarm;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.Button btnOk;
    }
}