namespace ConventionSystem
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSeminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySeminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addSeminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySeminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSeminarTimetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seminarToolStripMenuItem,
            this.seminarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seminarToolStripMenuItem
            // 
            this.seminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSeminarToolStripMenuItem,
            this.displaySeminarToolStripMenuItem,
            this.viewScheduleToolStripMenuItem});
            this.seminarToolStripMenuItem.Name = "seminarToolStripMenuItem";
            this.seminarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.seminarToolStripMenuItem.Text = "Attendee";
            // 
            // addSeminarToolStripMenuItem
            // 
            this.addSeminarToolStripMenuItem.Name = "addSeminarToolStripMenuItem";
            this.addSeminarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addSeminarToolStripMenuItem.Text = "Add Attendee";
            this.addSeminarToolStripMenuItem.Click += new System.EventHandler(this.addSeminarToolStripMenuItem_Click);
            // 
            // displaySeminarToolStripMenuItem
            // 
            this.displaySeminarToolStripMenuItem.Name = "displaySeminarToolStripMenuItem";
            this.displaySeminarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.displaySeminarToolStripMenuItem.Text = "Display Attendee";
            // 
            // seminarToolStripMenuItem1
            // 
            this.seminarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSeminarToolStripMenuItem1,
            this.displaySeminarToolStripMenuItem1,
            this.viewSeminarTimetableToolStripMenuItem});
            this.seminarToolStripMenuItem1.Name = "seminarToolStripMenuItem1";
            this.seminarToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.seminarToolStripMenuItem1.Text = "Seminar";
            // 
            // addSeminarToolStripMenuItem1
            // 
            this.addSeminarToolStripMenuItem1.Name = "addSeminarToolStripMenuItem1";
            this.addSeminarToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.addSeminarToolStripMenuItem1.Text = "Add Seminar";
            this.addSeminarToolStripMenuItem1.Click += new System.EventHandler(this.addSeminarToolStripMenuItem1_Click);
            // 
            // displaySeminarToolStripMenuItem1
            // 
            this.displaySeminarToolStripMenuItem1.Name = "displaySeminarToolStripMenuItem1";
            this.displaySeminarToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.displaySeminarToolStripMenuItem1.Text = "Display Seminar";
            this.displaySeminarToolStripMenuItem1.Click += new System.EventHandler(this.displaySeminarToolStripMenuItem1_Click);
            // 
            // viewSeminarTimetableToolStripMenuItem
            // 
            this.viewSeminarTimetableToolStripMenuItem.Name = "viewSeminarTimetableToolStripMenuItem";
            this.viewSeminarTimetableToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.viewSeminarTimetableToolStripMenuItem.Text = "View Seminar Timetable";
            this.viewSeminarTimetableToolStripMenuItem.Click += new System.EventHandler(this.viewSeminarTimetableToolStripMenuItem_Click);
            // 
            // viewScheduleToolStripMenuItem
            // 
            this.viewScheduleToolStripMenuItem.Name = "viewScheduleToolStripMenuItem";
            this.viewScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewScheduleToolStripMenuItem.Text = "View Schedule";
            this.viewScheduleToolStripMenuItem.Click += new System.EventHandler(this.viewScheduleToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 369);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSeminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySeminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addSeminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displaySeminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewSeminarTimetableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScheduleToolStripMenuItem;
    }
}

