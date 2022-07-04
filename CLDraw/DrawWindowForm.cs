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
    public partial class DrawWindowForm : Form
    {
        private Pots pots;

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
                string countryName = club.Country.ToString()[0] + club.Country.ToString().Substring(1).ToLower();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot1ListView.Items.Add(listItem);
             }

            //Loop refreshing pot 2
            pot2ListView.Items.Clear();
            foreach (Club club in pots.Pot2)
            {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString()[0] + club.Country.ToString().Substring(1).ToLower();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot2ListView.Items.Add(listItem);
            }

            //Loop refreshing pot 3
            pot3ListView.Items.Clear();
            foreach (Club club in pots.Pot3)
            {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString()[0] + club.Country.ToString().Substring(1).ToLower();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot3ListView.Items.Add(listItem);
            }

            //Loop refreshing pot 4
            pot4ListView.Items.Clear();
            foreach (Club club in pots.Pot4)
            {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString()[0] + club.Country.ToString().Substring(1).ToLower();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot4ListView.Items.Add(listItem);
            }

        }

        /// <summary>
        /// Clears all pots
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearPotsButton_Click(object sender, EventArgs e)
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
        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem pot1Item in pot1ListView.SelectedItems)
            {
                pot1ListView.Items.Remove(pot1Item);
            }

            foreach(ListViewItem pot2Item in pot2ListView.SelectedItems)
            {
                pot2ListView.Items.Remove(pot2Item);
            }

            foreach(ListViewItem pot3Item in pot3ListView.SelectedItems)
            {
                pot3ListView.Items.Remove(pot3Item);
            }

            foreach(ListViewItem pot4Item in pot4ListView.SelectedItems)
            {
                pot4ListView.Items.Remove(pot4Item);
            }

        }
    }
}
