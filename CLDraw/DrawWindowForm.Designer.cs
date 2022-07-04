using CLDraw.Models;
using System.Collections.Generic;

namespace CLDraw
{
    partial class DrawWindowForm
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
            this.pot1ListView = new System.Windows.Forms.ListView();
            this.club = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pot1GroupBox = new System.Windows.Forms.GroupBox();
            this.pot2GroupBox = new System.Windows.Forms.GroupBox();
            this.pot2ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pot3GroupBox = new System.Windows.Forms.GroupBox();
            this.pot3ListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pot4GroupBox = new System.Windows.Forms.GroupBox();
            this.pot4ListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pot1GroupBox.SuspendLayout();
            this.pot2GroupBox.SuspendLayout();
            this.pot3GroupBox.SuspendLayout();
            this.pot4GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pot1ListView
            // 
            this.pot1ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.club,
            this.country});
            this.pot1ListView.HideSelection = false;
            this.pot1ListView.Location = new System.Drawing.Point(6, 19);
            this.pot1ListView.Name = "pot1ListView";
            this.pot1ListView.Size = new System.Drawing.Size(175, 127);
            this.pot1ListView.TabIndex = 0;
            this.pot1ListView.UseCompatibleStateImageBehavior = false;
            this.pot1ListView.View = System.Windows.Forms.View.Details;
            // 
            // club
            // 
            this.club.Text = "Club";
            this.club.Width = 110;
            // 
            // country
            // 
            this.country.Text = "Country";
            // 
            // pot1GroupBox
            // 
            this.pot1GroupBox.Controls.Add(this.pot1ListView);
            this.pot1GroupBox.Location = new System.Drawing.Point(24, 12);
            this.pot1GroupBox.Name = "pot1GroupBox";
            this.pot1GroupBox.Size = new System.Drawing.Size(187, 154);
            this.pot1GroupBox.TabIndex = 2;
            this.pot1GroupBox.TabStop = false;
            this.pot1GroupBox.Text = "Pot 1";
            // 
            // pot2GroupBox
            // 
            this.pot2GroupBox.Controls.Add(this.pot2ListView);
            this.pot2GroupBox.Location = new System.Drawing.Point(228, 12);
            this.pot2GroupBox.Name = "pot2GroupBox";
            this.pot2GroupBox.Size = new System.Drawing.Size(187, 154);
            this.pot2GroupBox.TabIndex = 3;
            this.pot2GroupBox.TabStop = false;
            this.pot2GroupBox.Text = "Pot 2";
            // 
            // pot2ListView
            // 
            this.pot2ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.pot2ListView.HideSelection = false;
            this.pot2ListView.Location = new System.Drawing.Point(6, 19);
            this.pot2ListView.Name = "pot2ListView";
            this.pot2ListView.Size = new System.Drawing.Size(175, 127);
            this.pot2ListView.TabIndex = 0;
            this.pot2ListView.UseCompatibleStateImageBehavior = false;
            this.pot2ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Club";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Country";
            // 
            // pot3GroupBox
            // 
            this.pot3GroupBox.Controls.Add(this.pot3ListView);
            this.pot3GroupBox.Location = new System.Drawing.Point(435, 12);
            this.pot3GroupBox.Name = "pot3GroupBox";
            this.pot3GroupBox.Size = new System.Drawing.Size(187, 154);
            this.pot3GroupBox.TabIndex = 4;
            this.pot3GroupBox.TabStop = false;
            this.pot3GroupBox.Text = "Pot 3";
            // 
            // pot3ListView
            // 
            this.pot3ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.pot3ListView.HideSelection = false;
            this.pot3ListView.Location = new System.Drawing.Point(6, 19);
            this.pot3ListView.Name = "pot3ListView";
            this.pot3ListView.Size = new System.Drawing.Size(175, 127);
            this.pot3ListView.TabIndex = 0;
            this.pot3ListView.UseCompatibleStateImageBehavior = false;
            this.pot3ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Club";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Country";
            // 
            // pot4GroupBox
            // 
            this.pot4GroupBox.Controls.Add(this.pot4ListView);
            this.pot4GroupBox.Location = new System.Drawing.Point(643, 12);
            this.pot4GroupBox.Name = "pot4GroupBox";
            this.pot4GroupBox.Size = new System.Drawing.Size(187, 154);
            this.pot4GroupBox.TabIndex = 5;
            this.pot4GroupBox.TabStop = false;
            this.pot4GroupBox.Text = "Pot 4";
            // 
            // pot4ListView
            // 
            this.pot4ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.pot4ListView.HideSelection = false;
            this.pot4ListView.Location = new System.Drawing.Point(6, 19);
            this.pot4ListView.Name = "pot4ListView";
            this.pot4ListView.Size = new System.Drawing.Size(175, 127);
            this.pot4ListView.TabIndex = 0;
            this.pot4ListView.UseCompatibleStateImageBehavior = false;
            this.pot4ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Club";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Country";
            // 
            // DrawWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.pot4GroupBox);
            this.Controls.Add(this.pot3GroupBox);
            this.Controls.Add(this.pot2GroupBox);
            this.Controls.Add(this.pot1GroupBox);
            this.Name = "DrawWindowForm";
            this.Text = "CLDraw";
            this.Load += new System.EventHandler(this.DrawWindowForm_Load);
            this.pot1GroupBox.ResumeLayout(false);
            this.pot2GroupBox.ResumeLayout(false);
            this.pot3GroupBox.ResumeLayout(false);
            this.pot4GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView pot1ListView;
        private System.Windows.Forms.ColumnHeader club;
        private System.Windows.Forms.ColumnHeader country;
        private System.Windows.Forms.GroupBox pot1GroupBox;
        private System.Windows.Forms.GroupBox pot2GroupBox;
        private System.Windows.Forms.ListView pot2ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox pot3GroupBox;
        private System.Windows.Forms.ListView pot3ListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox pot4GroupBox;
        private System.Windows.Forms.ListView pot4ListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

