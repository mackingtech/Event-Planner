namespace Event_Planner
{
    partial class MainCalendar
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.createEventPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.amPm = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.ComboBox();
            this.eventDate = new System.Windows.Forms.Label();
            this.eventDateLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.eventDescriptionLabel = new System.Windows.Forms.Label();
            this.eventTitleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.LBDATE = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.deleteCancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteTxtBox = new System.Windows.Forms.TextBox();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showAllButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.createEventPanel.SuspendLayout();
            this.deletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.BackColor = System.Drawing.Color.RosyBrown;
            this.daycontainer.Location = new System.Drawing.Point(12, 64);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(861, 422);
            this.daycontainer.TabIndex = 0;
            // 
            // createEventPanel
            // 
            this.createEventPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.createEventPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createEventPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.createEventPanel.Controls.Add(this.cancelButton);
            this.createEventPanel.Controls.Add(this.clearButton);
            this.createEventPanel.Controls.Add(this.saveButton);
            this.createEventPanel.Controls.Add(this.amPm);
            this.createEventPanel.Controls.Add(this.timePicker);
            this.createEventPanel.Controls.Add(this.eventDate);
            this.createEventPanel.Controls.Add(this.eventDateLabel);
            this.createEventPanel.Controls.Add(this.monthCalendar1);
            this.createEventPanel.Controls.Add(this.descriptionTextBox);
            this.createEventPanel.Controls.Add(this.eventDescriptionLabel);
            this.createEventPanel.Controls.Add(this.eventTitleLabel);
            this.createEventPanel.Controls.Add(this.titleTextBox);
            this.createEventPanel.Location = new System.Drawing.Point(0, -1);
            this.createEventPanel.Name = "createEventPanel";
            this.createEventPanel.Size = new System.Drawing.Size(408, 529);
            this.createEventPanel.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(316, 387);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(316, 358);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(316, 329);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // amPm
            // 
            this.amPm.FormattingEnabled = true;
            this.amPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.amPm.Location = new System.Drawing.Point(312, 248);
            this.amPm.Name = "amPm";
            this.amPm.Size = new System.Drawing.Size(67, 21);
            this.amPm.TabIndex = 8;
            // 
            // timePicker
            // 
            this.timePicker.FormattingEnabled = true;
            this.timePicker.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.timePicker.Location = new System.Drawing.Point(237, 248);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(69, 21);
            this.timePicker.TabIndex = 7;
            // 
            // eventDate
            // 
            this.eventDate.AutoSize = true;
            this.eventDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDate.Location = new System.Drawing.Point(279, 218);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(57, 21);
            this.eventDate.TabIndex = 6;
            this.eventDate.Text = "DATE";
            // 
            // eventDateLabel
            // 
            this.eventDateLabel.AutoSize = true;
            this.eventDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateLabel.Location = new System.Drawing.Point(7, 219);
            this.eventDateLabel.Name = "eventDateLabel";
            this.eventDateLabel.Size = new System.Drawing.Size(126, 20);
            this.eventDateLabel.TabIndex = 5;
            this.eventDateLabel.Text = "Date and Time";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(3, 248);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 71);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(380, 139);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Text = "";
            // 
            // eventDescriptionLabel
            // 
            this.eventDescriptionLabel.AutoSize = true;
            this.eventDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDescriptionLabel.Location = new System.Drawing.Point(7, 48);
            this.eventDescriptionLabel.Name = "eventDescriptionLabel";
            this.eventDescriptionLabel.Size = new System.Drawing.Size(100, 20);
            this.eventDescriptionLabel.TabIndex = 2;
            this.eventDescriptionLabel.Text = "Description";
            // 
            // eventTitleLabel
            // 
            this.eventTitleLabel.AutoSize = true;
            this.eventTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitleLabel.Location = new System.Drawing.Point(7, 2);
            this.eventTitleLabel.Name = "eventTitleLabel";
            this.eventTitleLabel.Size = new System.Drawing.Size(43, 20);
            this.eventTitleLabel.TabIndex = 1;
            this.eventTitleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(3, 25);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(227, 20);
            this.titleTextBox.TabIndex = 0;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(817, 492);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 0;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(736, 492);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(75, 23);
            this.btnprevious.TabIndex = 1;
            this.btnprevious.Text = "Previous";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // LBDATE
            // 
            this.LBDATE.BackColor = System.Drawing.Color.RosyBrown;
            this.LBDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDATE.ForeColor = System.Drawing.Color.Black;
            this.LBDATE.Location = new System.Drawing.Point(313, 9);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(274, 28);
            this.LBDATE.TabIndex = 6;
            this.LBDATE.Text = "MONTH YEAR";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 492);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(108, 23);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Create Event";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletePanel.Controls.Add(this.deleteCancelButton);
            this.deletePanel.Controls.Add(this.deleteButton);
            this.deletePanel.Controls.Add(this.deleteTxtBox);
            this.deletePanel.Controls.Add(this.deleteLabel);
            this.deletePanel.Controls.Add(this.dataGridView1);
            this.deletePanel.Location = new System.Drawing.Point(472, -1);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(420, 529);
            this.deletePanel.TabIndex = 10;
            // 
            // deleteCancelButton
            // 
            this.deleteCancelButton.Location = new System.Drawing.Point(330, 492);
            this.deleteCancelButton.Name = "deleteCancelButton";
            this.deleteCancelButton.Size = new System.Drawing.Size(75, 22);
            this.deleteCancelButton.TabIndex = 3;
            this.deleteCancelButton.Text = "Cancel";
            this.deleteCancelButton.UseVisualStyleBackColor = true;
            this.deleteCancelButton.Click += new System.EventHandler(this.deleteCancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(257, 492);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 22);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteTxtBox
            // 
            this.deleteTxtBox.Location = new System.Drawing.Point(98, 495);
            this.deleteTxtBox.Name = "deleteTxtBox";
            this.deleteTxtBox.Size = new System.Drawing.Size(153, 20);
            this.deleteTxtBox.TabIndex = 2;
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.Location = new System.Drawing.Point(3, 494);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(97, 20);
            this.deleteLabel.TabIndex = 1;
            this.deleteLabel.Text = "Enter Title:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Event Title";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(126, 493);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(108, 23);
            this.showAllButton.TabIndex = 11;
            this.showAllButton.Text = "Show All Events";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sunday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Monday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(530, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Thursday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(405, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Wednesday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(285, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tuesday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(781, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Saturday";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(662, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Friday";
            // 
            // MainCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Event_Planner.Properties.Resources.christmasBetter;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 528);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.createEventPanel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.daycontainer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.createEventPanel.ResumeLayout(false);
            this.createEventPanel.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Label LBDATE;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Panel createEventPanel;
        private System.Windows.Forms.Label eventDate;
        private System.Windows.Forms.Label eventDateLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label eventDescriptionLabel;
        private System.Windows.Forms.Label eventTitleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox amPm;
        private System.Windows.Forms.ComboBox timePicker;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button deleteCancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteTxtBox;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

