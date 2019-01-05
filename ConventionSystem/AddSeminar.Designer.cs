namespace ConventionSystem
{
    partial class AddSeminar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSeminarDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTimeFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAudience = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPresenter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SavePresenterAutience = new System.Windows.Forms.Button();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(125, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(205, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seminar Date";
            // 
            // dtSeminarDate
            // 
            this.dtSeminarDate.CustomFormat = "dd-MM-yyyy";
            this.dtSeminarDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSeminarDate.Location = new System.Drawing.Point(125, 89);
            this.dtSeminarDate.Name = "dtSeminarDate";
            this.dtSeminarDate.Size = new System.Drawing.Size(123, 20);
            this.dtSeminarDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time";
            // 
            // cbTimeFormat
            // 
            this.cbTimeFormat.FormattingEnabled = true;
            this.cbTimeFormat.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbTimeFormat.Location = new System.Drawing.Point(393, 139);
            this.cbTimeFormat.Name = "cbTimeFormat";
            this.cbTimeFormat.Size = new System.Drawing.Size(75, 21);
            this.cbTimeFormat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Room";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(125, 263);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Duration";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Seminar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(125, 140);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "(HH:MM)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Audiences";
            // 
            // btnAudience
            // 
            this.btnAudience.Location = new System.Drawing.Point(125, 323);
            this.btnAudience.Name = "btnAudience";
            this.btnAudience.Size = new System.Drawing.Size(112, 23);
            this.btnAudience.TabIndex = 16;
            this.btnAudience.Text = "Browse Audience";
            this.btnAudience.UseVisualStyleBackColor = true;
            this.btnAudience.Click += new System.EventHandler(this.btnAudience_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
            this.dataGridView1.Location = new System.Drawing.Point(14, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 276);
            this.dataGridView1.TabIndex = 17;
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "";
            this.chkSelect.Name = "chkSelect";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Presenter";
            // 
            // btnPresenter
            // 
            this.btnPresenter.Location = new System.Drawing.Point(125, 386);
            this.btnPresenter.Name = "btnPresenter";
            this.btnPresenter.Size = new System.Drawing.Size(112, 23);
            this.btnPresenter.TabIndex = 19;
            this.btnPresenter.Text = "Browse Presenter";
            this.btnPresenter.UseVisualStyleBackColor = true;
            this.btnPresenter.Click += new System.EventHandler(this.btnPresenter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SavePresenterAutience);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(269, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 338);
            this.panel1.TabIndex = 20;
            // 
            // SavePresenterAutience
            // 
            this.SavePresenterAutience.Location = new System.Drawing.Point(65, 305);
            this.SavePresenterAutience.Name = "SavePresenterAutience";
            this.SavePresenterAutience.Size = new System.Drawing.Size(113, 23);
            this.SavePresenterAutience.TabIndex = 18;
            this.SavePresenterAutience.Text = "Save Presenter";
            this.SavePresenterAutience.UseVisualStyleBackColor = true;
            this.SavePresenterAutience.Click += new System.EventHandler(this.SavePresenterAutience_Click);
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(125, 198);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(121, 21);
            this.cbRoom.TabIndex = 21;
            // 
            // AddSeminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 506);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPresenter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAudience);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTimeFormat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtSeminarDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "AddSeminar";
            this.Text = "Add Seminar";
            this.Load += new System.EventHandler(this.AddSeminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSeminarDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTimeFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAudience;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPresenter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SavePresenterAutience;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private System.Windows.Forms.ComboBox cbRoom;
    }
}