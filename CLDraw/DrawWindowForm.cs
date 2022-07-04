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
            pots.Pot1.Add(new Club("dupa", Country.TURKEY));
            pots.Pot1.Add(new Club("dupa", Country.TURKEY));
        }

        private void DrawWindowForm_Load(object sender, EventArgs e)
        {

            RefreshPotsView();
        }

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
        /// Button which clears all pots
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
    }
}
