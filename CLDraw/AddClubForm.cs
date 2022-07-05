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
    /// Window to add clubs to pots
    /// </summary>
    public partial class AddClubForm : Form
    {
        public DrawWindowForm mainWindow { get; }

        public AddClubForm(DrawWindowForm mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));
        }

        /// <summary>
        /// Adds new club with properties from comboBoxes and textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClubButton_Click(object sender, EventArgs e)
        {
            if (countryComboBox.SelectedValue != null && !string.IsNullOrWhiteSpace(clubNameTextBox.Text) && potNumberComboBox.SelectedItem != null)
            {
                Country newClubCountry;
                //Parse selected country to enum
                Enum.TryParse<Country>(countryComboBox.SelectedValue.ToString(), out newClubCountry);

                Club newClub = new Club(clubNameTextBox.Text, newClubCountry);

                //Parse chosen pot number to int
                int potNumber = Int32.Parse(potNumberComboBox.SelectedItem.ToString());

                try
                {
                    mainWindow.AddClubToPot(potNumber, newClub);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Club cannot be added. Invalid pot number", "Invalid pot number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show($"Club cannot be added. Pot {potNumber} is full", "Pot is full", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("All details must be provided. No field can be empty", "Invalid club details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Clearing comboBoxes and textBox
            clubNameTextBox.Clear();
            countryComboBox.SelectedItem = null;
            potNumberComboBox.SelectedItem = null;

            
        }

        /// <summary>
        /// Closes window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelAddingClubButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
