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
            this.clearPotsButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.openAddClubWindowButton = new System.Windows.Forms.Button();
            this.groupAGroupBox = new System.Windows.Forms.GroupBox();
            this.groupAListView = new System.Windows.Forms.ListView();
            this.clubName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupCGroupBox = new System.Windows.Forms.GroupBox();
            this.groupCListView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupDGroupBox = new System.Windows.Forms.GroupBox();
            this.groupDListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupEGroupBox = new System.Windows.Forms.GroupBox();
            this.groupEListView = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupFGroupBox = new System.Windows.Forms.GroupBox();
            this.groupFListView = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pot1GroupBox.SuspendLayout();
            this.pot2GroupBox.SuspendLayout();
            this.pot3GroupBox.SuspendLayout();
            this.pot4GroupBox.SuspendLayout();
            this.groupAGroupBox.SuspendLayout();
            this.groupBGroupBox.SuspendLayout();
            this.groupCGroupBox.SuspendLayout();
            this.groupDGroupBox.SuspendLayout();
            this.groupEGroupBox.SuspendLayout();
            this.groupFGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.pot1ListView.Size = new System.Drawing.Size(175, 174);
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
            this.pot1GroupBox.Size = new System.Drawing.Size(187, 199);
            this.pot1GroupBox.TabIndex = 2;
            this.pot1GroupBox.TabStop = false;
            this.pot1GroupBox.Text = "Pot 1";
            // 
            // pot2GroupBox
            // 
            this.pot2GroupBox.Controls.Add(this.pot2ListView);
            this.pot2GroupBox.Location = new System.Drawing.Point(228, 12);
            this.pot2GroupBox.Name = "pot2GroupBox";
            this.pot2GroupBox.Size = new System.Drawing.Size(187, 199);
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
            this.pot2ListView.Size = new System.Drawing.Size(175, 174);
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
            this.pot3GroupBox.Size = new System.Drawing.Size(187, 199);
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
            this.pot3ListView.Size = new System.Drawing.Size(175, 174);
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
            this.pot4GroupBox.Size = new System.Drawing.Size(187, 199);
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
            this.pot4ListView.Size = new System.Drawing.Size(175, 174);
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
            // clearPotsButton
            // 
            this.clearPotsButton.Location = new System.Drawing.Point(944, 12);
            this.clearPotsButton.Name = "clearPotsButton";
            this.clearPotsButton.Size = new System.Drawing.Size(75, 23);
            this.clearPotsButton.TabIndex = 6;
            this.clearPotsButton.Text = "Clear Pots";
            this.clearPotsButton.UseVisualStyleBackColor = true;
            this.clearPotsButton.Click += new System.EventHandler(this.ClearPotsButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Location = new System.Drawing.Point(848, 12);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(90, 23);
            this.deleteSelectedButton.TabIndex = 7;
            this.deleteSelectedButton.Text = "Delete selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // openAddClubWindowButton
            // 
            this.openAddClubWindowButton.Location = new System.Drawing.Point(1025, 12);
            this.openAddClubWindowButton.Name = "openAddClubWindowButton";
            this.openAddClubWindowButton.Size = new System.Drawing.Size(75, 23);
            this.openAddClubWindowButton.TabIndex = 8;
            this.openAddClubWindowButton.Text = "Add club";
            this.openAddClubWindowButton.UseVisualStyleBackColor = true;
            this.openAddClubWindowButton.Click += new System.EventHandler(this.OpenAddClubWindowButton_Click);
            // 
            // groupAGroupBox
            // 
            this.groupAGroupBox.Controls.Add(this.groupAListView);
            this.groupAGroupBox.Location = new System.Drawing.Point(24, 271);
            this.groupAGroupBox.Name = "groupAGroupBox";
            this.groupAGroupBox.Size = new System.Drawing.Size(187, 126);
            this.groupAGroupBox.TabIndex = 9;
            this.groupAGroupBox.TabStop = false;
            this.groupAGroupBox.Text = "Group A";
            // 
            // groupAListView
            // 
            this.groupAListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clubName});
            this.groupAListView.HideSelection = false;
            this.groupAListView.Location = new System.Drawing.Point(6, 19);
            this.groupAListView.Name = "groupAListView";
            this.groupAListView.Size = new System.Drawing.Size(175, 102);
            this.groupAListView.TabIndex = 1;
            this.groupAListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBGroupBox
            // 
            this.groupBGroupBox.Controls.Add(this.groupBListView);
            this.groupBGroupBox.Location = new System.Drawing.Point(228, 271);
            this.groupBGroupBox.Name = "groupBGroupBox";
            this.groupBGroupBox.Size = new System.Drawing.Size(187, 126);
            this.groupBGroupBox.TabIndex = 10;
            this.groupBGroupBox.TabStop = false;
            this.groupBGroupBox.Text = "Group B";
            // 
            // groupBListView
            // 
            this.groupBListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.groupBListView.HideSelection = false;
            this.groupBListView.Location = new System.Drawing.Point(6, 19);
            this.groupBListView.Name = "groupBListView";
            this.groupBListView.Size = new System.Drawing.Size(175, 102);
            this.groupBListView.TabIndex = 1;
            this.groupBListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupCGroupBox
            // 
            this.groupCGroupBox.Controls.Add(this.groupCListView);
            this.groupCGroupBox.Location = new System.Drawing.Point(435, 271);
            this.groupCGroupBox.Name = "groupCGroupBox";
            this.groupCGroupBox.Size = new System.Drawing.Size(187, 126);
            this.groupCGroupBox.TabIndex = 11;
            this.groupCGroupBox.TabStop = false;
            this.groupCGroupBox.Text = "Group C";
            // 
            // groupCListView
            // 
            this.groupCListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8});
            this.groupCListView.HideSelection = false;
            this.groupCListView.Location = new System.Drawing.Point(6, 19);
            this.groupCListView.Name = "groupCListView";
            this.groupCListView.Size = new System.Drawing.Size(175, 102);
            this.groupCListView.TabIndex = 1;
            this.groupCListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupDGroupBox
            // 
            this.groupDGroupBox.Controls.Add(this.groupDListView);
            this.groupDGroupBox.Location = new System.Drawing.Point(643, 271);
            this.groupDGroupBox.Name = "groupDGroupBox";
            this.groupDGroupBox.Size = new System.Drawing.Size(187, 126);
            this.groupDGroupBox.TabIndex = 12;
            this.groupDGroupBox.TabStop = false;
            this.groupDGroupBox.Text = "Group D";
            // 
            // groupDListView
            // 
            this.groupDListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.groupDListView.HideSelection = false;
            this.groupDListView.Location = new System.Drawing.Point(6, 19);
            this.groupDListView.Name = "groupDListView";
            this.groupDListView.Size = new System.Drawing.Size(175, 102);
            this.groupDListView.TabIndex = 1;
            this.groupDListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupEGroupBox
            // 
            this.groupEGroupBox.Controls.Add(this.groupEListView);
            this.groupEGroupBox.Location = new System.Drawing.Point(24, 421);
            this.groupEGroupBox.Name = "groupEGroupBox";
            this.groupEGroupBox.Size = new System.Drawing.Size(187, 126);
            this.groupEGroupBox.TabIndex = 10;
            this.groupEGroupBox.TabStop = false;
            this.groupEGroupBox.Text = "Group E";
            // 
            // groupEListView
            // 
            this.groupEListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10});
            this.groupEListView.HideSelection = false;
            this.groupEListView.Location = new System.Drawing.Point(6, 19);
            this.groupEListView.Name = "groupEListView";
            this.groupEListView.Size = new System.Drawing.Size(175, 102);
            this.groupEListView.TabIndex = 1;
            this.groupEListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupFGroupBox
            // 
            this.groupFGroupBox.Controls.Add(this.groupBox1);
            this.groupFGroupBox.Controls.Add(this.groupFListView);
            this.groupFGroupBox.Location = new System.Drawing.Point(228, 421);
            this.groupFGroupBox.Name = "groupFGroupBox";
            this.groupFGroupBox.Size = new System.Drawing.Size(187, 126);
            this.groupFGroupBox.TabIndex = 11;
            this.groupFGroupBox.TabStop = false;
            this.groupFGroupBox.Text = "Group F";
            // 
            // groupFListView
            // 
            this.groupFListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11});
            this.groupFListView.HideSelection = false;
            this.groupFListView.Location = new System.Drawing.Point(6, 19);
            this.groupFListView.Name = "groupFListView";
            this.groupFListView.Size = new System.Drawing.Size(175, 102);
            this.groupFListView.TabIndex = 1;
            this.groupFListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 126);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group F";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(175, 102);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // DrawWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 559);
            this.Controls.Add(this.groupFGroupBox);
            this.Controls.Add(this.groupEGroupBox);
            this.Controls.Add(this.groupDGroupBox);
            this.Controls.Add(this.groupCGroupBox);
            this.Controls.Add(this.groupBGroupBox);
            this.Controls.Add(this.groupAGroupBox);
            this.Controls.Add(this.openAddClubWindowButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.clearPotsButton);
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
            this.groupAGroupBox.ResumeLayout(false);
            this.groupBGroupBox.ResumeLayout(false);
            this.groupCGroupBox.ResumeLayout(false);
            this.groupDGroupBox.ResumeLayout(false);
            this.groupEGroupBox.ResumeLayout(false);
            this.groupFGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button clearPotsButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button openAddClubWindowButton;
        private System.Windows.Forms.GroupBox groupAGroupBox;
        private System.Windows.Forms.ListView groupAListView;
        private System.Windows.Forms.ColumnHeader clubName;
        private System.Windows.Forms.GroupBox groupBGroupBox;
        private System.Windows.Forms.ListView groupBListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupCGroupBox;
        private System.Windows.Forms.ListView groupCListView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupDGroupBox;
        private System.Windows.Forms.ListView groupDListView;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupEGroupBox;
        private System.Windows.Forms.ListView groupEListView;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupFGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView groupFListView;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}

