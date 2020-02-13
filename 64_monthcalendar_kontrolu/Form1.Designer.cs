namespace _64_monthcalendar_kontrolu
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar3 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar4 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2020, 2, 2, 0, 0, 0, 0)};
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2020, 2, 3, 0, 0, 0, 0),
        new System.DateTime(2020, 2, 10, 0, 0, 0, 0),
        new System.DateTime(2020, 2, 2, 0, 0, 0, 0)};
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.FirstDayOfWeek = System.Windows.Forms.Day.Wednesday;
            this.monthCalendar2.Location = new System.Drawing.Point(388, 18);
            this.monthCalendar2.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.monthCalendar2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            // 
            // monthCalendar3
            // 
            this.monthCalendar3.Location = new System.Drawing.Point(388, 309);
            this.monthCalendar3.MonthlyBoldedDates = new System.DateTime[] {
        new System.DateTime(2020, 2, 15, 0, 0, 0, 0)};
            this.monthCalendar3.Name = "monthCalendar3";
            this.monthCalendar3.TabIndex = 2;
            // 
            // monthCalendar4
            // 
            this.monthCalendar4.Location = new System.Drawing.Point(717, 189);
            this.monthCalendar4.Name = "monthCalendar4";
            this.monthCalendar4.ScrollChange = 3;
            this.monthCalendar4.ShowToday = false;
            this.monthCalendar4.TabIndex = 3;
            this.monthCalendar4.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar4_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 513);
            this.Controls.Add(this.monthCalendar4);
            this.Controls.Add(this.monthCalendar3);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar3;
        private System.Windows.Forms.MonthCalendar monthCalendar4;
    }
}

