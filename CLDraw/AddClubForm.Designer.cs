namespace CLDraw
{
    partial class AddClubForm
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
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryNameTextBox = new System.Windows.Forms.TextBox();
            this.potNumberComboBox = new System.Windows.Forms.ComboBox();
            this.potNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.clubNameGroupBox = new System.Windows.Forms.GroupBox();
            this.countryGroupBox = new System.Windows.Forms.GroupBox();
            this.potNumberGroupBox.SuspendLayout();
            this.clubNameGroupBox.SuspendLayout();
            this.countryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(6, 14);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(100, 21);
            this.countryComboBox.TabIndex = 0;
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.Location = new System.Drawing.Point(6, 13);
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.countryNameTextBox.TabIndex = 1;
            // 
            // potNumberComboBox
            // 
            this.potNumberComboBox.FormattingEnabled = true;
            this.potNumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.potNumberComboBox.Location = new System.Drawing.Point(6, 14);
            this.potNumberComboBox.Name = "potNumberComboBox";
            this.potNumberComboBox.Size = new System.Drawing.Size(29, 21);
            this.potNumberComboBox.TabIndex = 2;
            // 
            // potNumberGroupBox
            // 
            this.potNumberGroupBox.Controls.Add(this.potNumberComboBox);
            this.potNumberGroupBox.Location = new System.Drawing.Point(12, 12);
            this.potNumberGroupBox.Name = "potNumberGroupBox";
            this.potNumberGroupBox.Size = new System.Drawing.Size(44, 41);
            this.potNumberGroupBox.TabIndex = 3;
            this.potNumberGroupBox.TabStop = false;
            this.potNumberGroupBox.Text = "Pot";
            // 
            // clubNameGroupBox
            // 
            this.clubNameGroupBox.Controls.Add(this.countryNameTextBox);
            this.clubNameGroupBox.Location = new System.Drawing.Point(62, 12);
            this.clubNameGroupBox.Name = "clubNameGroupBox";
            this.clubNameGroupBox.Size = new System.Drawing.Size(189, 41);
            this.clubNameGroupBox.TabIndex = 4;
            this.clubNameGroupBox.TabStop = false;
            this.clubNameGroupBox.Text = "Club name";
            // 
            // countryGroupBox
            // 
            this.countryGroupBox.Controls.Add(this.countryComboBox);
            this.countryGroupBox.Location = new System.Drawing.Point(257, 12);
            this.countryGroupBox.Name = "countryGroupBox";
            this.countryGroupBox.Size = new System.Drawing.Size(116, 41);
            this.countryGroupBox.TabIndex = 5;
            this.countryGroupBox.TabStop = false;
            this.countryGroupBox.Text = "Country";
            // 
            // AddClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 114);
            this.Controls.Add(this.countryGroupBox);
            this.Controls.Add(this.clubNameGroupBox);
            this.Controls.Add(this.potNumberGroupBox);
            this.Name = "AddClubForm";
            this.Text = "Add club";
            this.potNumberGroupBox.ResumeLayout(false);
            this.clubNameGroupBox.ResumeLayout(false);
            this.clubNameGroupBox.PerformLayout();
            this.countryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.TextBox countryNameTextBox;
        private System.Windows.Forms.ComboBox potNumberComboBox;
        private System.Windows.Forms.GroupBox potNumberGroupBox;
        private System.Windows.Forms.GroupBox clubNameGroupBox;
        private System.Windows.Forms.GroupBox countryGroupBox;
    }
}