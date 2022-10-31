namespace Event_Planner
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbdays = new System.Windows.Forms.Label();
            this.eventContainer = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.eventContainer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(3, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(27, 20);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // eventContainer
            // 
            this.eventContainer.AutoSize = true;
            this.eventContainer.BackColor = System.Drawing.Color.OrangeRed;
            this.eventContainer.Location = new System.Drawing.Point(4, 20);
            this.eventContainer.Name = "eventContainer";
            this.eventContainer.Size = new System.Drawing.Size(0, 13);
            this.eventContainer.TabIndex = 1;
            this.eventContainer.Click += new System.EventHandler(this.eventContainer_Click);
            this.eventContainer.MouseHover += new System.EventHandler(this.eventContainer_MouseHover);
            // 
            // eventContainer2
            // 
            this.eventContainer2.AutoSize = true;
            this.eventContainer2.BackColor = System.Drawing.Color.OrangeRed;
            this.eventContainer2.Location = new System.Drawing.Point(4, 35);
            this.eventContainer2.Name = "eventContainer2";
            this.eventContainer2.Size = new System.Drawing.Size(0, 13);
            this.eventContainer2.TabIndex = 2;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.eventContainer2);
            this.Controls.Add(this.eventContainer);
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(117, 63);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Label eventContainer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label eventContainer2;
    }
}
