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

        }
    }
}
