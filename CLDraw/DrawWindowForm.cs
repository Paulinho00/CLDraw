using CLDraw.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLDraw
{
    /// <summary>
    /// Window where draw takes place, with groups, pots
    /// </summary>
    public partial class DrawWindowForm : Form
    {
        private readonly Pots pots;

        private List<int> drawPool;

        public DrawWindowForm()
        {
            InitializeComponent();
            pots = new Pots();
        }

        private void DrawWindowForm_Load(object sender, EventArgs e)
        {

            RefreshPotsView();
        }

        /// <summary>
        /// Refresh content of all pots
        /// </summary>
        private void RefreshPotsView()
        {

            //Loop refreshing pot 1
            pot1ListView.Items.Clear();
            foreach (Club club in pots.Pot1) {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot1ListView.Items.Add(listItem);
             }

            //Loop refreshing pot 2
            pot2ListView.Items.Clear();
            foreach (Club club in pots.Pot2)
            {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot2ListView.Items.Add(listItem);
            }

            //Loop refreshing pot 3
            pot3ListView.Items.Clear();
            foreach (Club club in pots.Pot3)
            {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot3ListView.Items.Add(listItem);
            }

            //Loop refreshing pot 4
            pot4ListView.Items.Clear();
            foreach (Club club in pots.Pot4)
            {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot4ListView.Items.Add(listItem);
            }

        }

        /// <summary>
        /// Clears all pots
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearPotsButton_Click(object sender, EventArgs e)
        {
            pots.Pot1.Clear();
            pots.Pot2.Clear();
            pots.Pot3.Clear();
            pots.Pot4.Clear();
            RefreshPotsView();
        }

        /// <summary>
        /// Deletes selected clubs from pots
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem pot1Item in pot1ListView.SelectedItems)
            {
                Club clubToDelete = pots.Pot1.FirstOrDefault(name => name.Name == pot1Item.Text);
                pots.Pot1.Remove(clubToDelete);
            }

            foreach(ListViewItem pot2Item in pot2ListView.SelectedItems)
            {
                Club clubToDelete = pots.Pot2.FirstOrDefault(name => name.Name == pot2Item.Text);
                pots.Pot2.Remove(clubToDelete);
            }

            foreach(ListViewItem pot3Item in pot3ListView.SelectedItems)
            {
                Club clubToDelete = pots.Pot3.FirstOrDefault(name => name.Name == pot3Item.Text);
                pots.Pot3.Remove(clubToDelete);
            }

            foreach(ListViewItem pot4Item in pot4ListView.SelectedItems)
            {
                Club clubToDelete = pots.Pot4.FirstOrDefault(name => name.Name == pot4Item.Text);
                pots.Pot4.Remove(clubToDelete);
            }

            RefreshPotsView();
        }

        /// <summary>
        /// Opens window to add club
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAddClubWindowButton_Click(object sender, EventArgs e)
        {
            AddClubForm addClubForm = new AddClubForm(this);
            addClubForm.Show();
        }


        /// <summary>
        /// Adds new club to pot in window
        /// </summary>
        /// <param name="potNumber">>pot which club will be placed in</param>
        /// <param name="club">new club to be placed in pot</param>
        /// <exception cref="ArgumentException">throws exception when pot is full</exception>
        public void AddClubToPot(int potNumber, Club club)
        {

            if (potNumber <= 0 || potNumber > 4) throw new ArgumentOutOfRangeException();

            try
            {
                pots.AddClub(potNumber, club);
                RefreshPotsView();
            } catch(ArgumentException e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        /// <summary>
        /// Start draw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startDrawButton_Click(object sender, EventArgs e)
        {
            if (!pots.CheckPotsReadyForDraw())
            {
                MessageBox.Show("Not enough teams to start draw", "Not enough teams", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Disabling the option to edit pots
            deleteSelectedButton.Enabled = false;
            clearPotsButton.Enabled = false;
            openAddClubWindowButton.Enabled = false;

            drawnTeamTextBox.Visible = true;

            //Show balls
            ball1PictureBox.Visible = true;
            ball2PictureBox.Visible = true;
            ball3PictureBox.Visible = true;
            ball4PictureBox.Visible = true;
            ball5PictureBox.Visible = true;
            ball6PictureBox.Visible = true;
            ball7PictureBox.Visible = true;
            ball8PictureBox.Visible = true;

        }
    }
}
