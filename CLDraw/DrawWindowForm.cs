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
        private int leftTeams { get; set; }

        private int drawRound { get; set;}

        private Groups groups { get; set; }

        private List<PictureBox> GroupsPictureBoxes { get; set; }

        public DrawWindowForm()
        {
            InitializeComponent();
            pots = new Pots();
            drawRound = 1;
            groups = new Groups();
            GroupsPictureBoxes = new List<PictureBox>();
            GroupsPictureBoxes.Add(groupBall1pictureBox);
            GroupsPictureBoxes.Add(groupBall2pictureBox);
            GroupsPictureBoxes.Add(groupBall3pictureBox);
            GroupsPictureBoxes.Add(groupBall4pictureBox);
            GroupsPictureBoxes.Add(groupBall5pictureBox);
            GroupsPictureBoxes.Add(groupBall6pictureBox);
            GroupsPictureBoxes.Add(groupBall7pictureBox);
            GroupsPictureBoxes.Add(groupBall8pictureBox);
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
            foreach (Club club in pots.PotsList[0]) {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot1ListView.Items.Add(listItem);
             }

            //Loop refreshing pot 2
            pot2ListView.Items.Clear();
            foreach (Club club in pots.PotsList[1])
            {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot2ListView.Items.Add(listItem);
            }

            //Loop refreshing pot 3
            pot3ListView.Items.Clear();
            foreach (Club club in pots.PotsList[2])
            {

                //Creates country name from uppercase string to only first letter uppercase string
                string countryName = club.Country.ToString();

                var listItem = new ListViewItem(new[] { club.Name, countryName });
                pot3ListView.Items.Add(listItem);
            }

            //Loop refreshing pot 4
            pot4ListView.Items.Clear();
            foreach (Club club in pots.PotsList[3])
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
            foreach(var pot in pots.PotsList)
            {
                pot.Clear();
            }
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
                Club clubToDelete = pots.PotsList[0].FirstOrDefault(name => name.Name == pot1Item.Text);
                pots.PotsList[0].Remove(clubToDelete);
            }

            foreach(ListViewItem pot2Item in pot2ListView.SelectedItems)
            {
                Club clubToDelete = pots.PotsList[1].FirstOrDefault(name => name.Name == pot2Item.Text);
                pots.PotsList[1].Remove(clubToDelete);
            }

            foreach(ListViewItem pot3Item in pot3ListView.SelectedItems)
            {
                Club clubToDelete = pots.PotsList[2].FirstOrDefault(name => name.Name == pot3Item.Text);
                pots.PotsList[2].Remove(clubToDelete);
            }

            foreach(ListViewItem pot4Item in pot4ListView.SelectedItems)
            {
                Club clubToDelete = pots.PotsList[3].FirstOrDefault(name => name.Name == pot4Item.Text);
                pots.PotsList[3].Remove(clubToDelete);
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
            startDrawButton.Enabled = false;

            drawnTeamTextBox.Visible = true;

            //Set number of teams left in the pot
            leftTeams = 8;
            ResetTeamBalls();
        }


        /// <summary>
        /// Adds team to group list view according to given groupNumber
        /// </summary>
        /// <param name="groupNumber">group number to which club is add</param>
        /// <param name="club">club to be add to group</param>
        private void AddTeamToGroup(int groupNumber, Club club)
        {
            groups.GroupsList[groupNumber].Add(club);
            ListViewItem team = new ListViewItem(new[] { club.Name });


            switch (groupNumber)
            {
                case 0: groupAListView.Items.Add(team); break;
                case 1: groupBListView.Items.Add(team); break;
                case 2: groupCListView.Items.Add(team); break;
                case 3: groupDListView.Items.Add(team); break;
                case 4: groupEListView.Items.Add(team); break;
                case 5: groupFListView.Items.Add(team); break;
                case 6: groupGListView.Items.Add(team); break;
                case 7: groupHListView.Items.Add(team); break;

            }
        }

        /// <summary>
        /// Randomly sets with ints from 0 to 7 new tags for ball pictureboxes, and set viisibility of pictureboxes to true
        /// </summary>
        private void ResetTeamBalls()
        {

            //Generate list with ints from 0 to 7
            List<int> drawPool = Randomizer.GenerateDrawPool();

            //Sets tags using shuffled list
            ball1PictureBox.Tag = pots.PotsList[drawRound - 1][drawPool[0]].Name;
            ball2PictureBox.Tag = pots.PotsList[drawRound - 1][drawPool[1]].Name;
            ball3PictureBox.Tag = pots.PotsList[drawRound - 1][drawPool[2]].Name;
            ball4PictureBox.Tag = pots.PotsList[drawRound - 1][drawPool[3]].Name;
            ball5PictureBox.Tag = pots.PotsList[drawRound - 1][drawPool[4]].Name;
            ball6PictureBox.Tag = pots.PotsList[drawRound - 1][drawPool[5]].Name;
            ball7PictureBox.Tag = pots.PotsList[drawRound - 1][drawPool[6]].Name;
            ball8PictureBox.Tag = pots.PotsList[drawRound - 1][drawPool[7]].Name;

            //Show balls
            ball1PictureBox.Visible = true;
            ball1PictureBox.Refresh();
            ball2PictureBox.Visible = true;
            ball2PictureBox.Refresh();
            ball3PictureBox.Visible = true;
            ball3PictureBox.Refresh();
            ball4PictureBox.Visible = true;
            ball4PictureBox.Refresh();
            ball5PictureBox.Visible = true;
            ball5PictureBox.Refresh();
            ball6PictureBox.Visible = true;
            ball6PictureBox.Refresh();
            ball7PictureBox.Visible = true;
            ball7PictureBox.Refresh();
            ball8PictureBox.Visible = true;
            ball8PictureBox.Refresh();
        }

        /// <summary>
        /// Enables group draw
        /// </summary>
        private void DrawGroup()
        {
            var drawPool = groups.GeneratePoolForGroupDraw(drawRound);
            Randomizer.Shuffle(drawPool);

            for(int i = 0; i < drawPool.Count; i++)
            {
                GroupsPictureBoxes[i].Tag = drawPool[i];
                GroupsPictureBoxes[i].Visible = true;
            }

            drawnGroupTextBox.Visible = true;
        }

        /// <summary>
        /// Disable all team balls
        /// </summary>
        private void DisableTeamBallsPictureBox()
        {
            ball1PictureBox.Enabled = false;
            ball2PictureBox.Enabled = false;
            ball3PictureBox.Enabled = false;
            ball4PictureBox.Enabled = false;
            ball5PictureBox.Enabled = false;
            ball6PictureBox.Enabled = false;
            ball7PictureBox.Enabled = false;
            ball8PictureBox.Enabled = false;
        }

        /// <summary>
        /// Enable all team balls
        /// </summary>
        private void EnableTeamBallsPictureBox()
        {
            ball1PictureBox.Enabled = true;
            ball2PictureBox.Enabled = true;
            ball3PictureBox.Enabled = true;
            ball4PictureBox.Enabled = true;
            ball5PictureBox.Enabled = true;
            ball6PictureBox.Enabled = true;
            ball7PictureBox.Enabled = true;
            ball8PictureBox.Enabled = true;
        }

        /// <summary>
        /// Reads which ball pictureBox is chosen and adds club assigned to it to group. Checks if all teams are drawn, if yes it starts new round
        /// </summary>
        /// <param name="ballPictureBox">chosen picturebox</param>
        private void ClubIsDrawn(PictureBox ballPictureBox)
        {
            Club club = pots.PotsList[drawRound - 1].FirstOrDefault(clubToBeFound => clubToBeFound.Name == ballPictureBox.Tag.ToString());
            ballPictureBox.Visible = false;
            
            //Display name of drawn club
            drawnTeamTextBox.Text = club.Name;
            leftTeams--;

            if (drawRound == 1)
            {
                int groupNumber = 7 - leftTeams;

                AddTeamToGroup(groupNumber, club);

                //Remove club from pot and refresh view
                pots.PotsList[drawRound - 1].Remove(club);
                RefreshPotsView();

                //Check if round is over
                if (drawRound < 4)
                {
                    if (leftTeams == 0)
                    {
                        leftTeams = 8;
                        drawRound++;
                        ResetTeamBalls();
                    }
                }
            }
            else
            {
                drawnGroupTextBox.Text = null;
                DisableTeamBallsPictureBox();
                DrawGroup();
            }


            
        }

        /// <summary>
        /// Hides groups balls and drawn group text box after group is drawn
        /// </summary>
        private void HideGroupBalls()
        {
            foreach(PictureBox groupBallPictureBox in GroupsPictureBoxes)
            {
                if(groupBallPictureBox.Visible == true)
                {
                    groupBallPictureBox.Tag = null;
                    groupBallPictureBox.Visible = false;
                }
            }
        }

        /// <summary>
        /// Reads which team ball pictureBox is chosen and which group ball picturebox is chosen and then assigns chosen team to chosen group
        /// </summary>
        /// <param name="groupBallPictureBox"></param>
        private void GroupIsDrawn(PictureBox groupBallPictureBox)
        {
            Club club = pots.PotsList[drawRound - 1].FirstOrDefault(newClub => newClub.Name == drawnTeamTextBox.Text);

            //Remove club from pot and refresh view
            pots.PotsList[drawRound - 1].Remove(club);
            RefreshPotsView();

            int groupNumber = int.Parse(groupBallPictureBox.Tag.ToString());

            //Calculate group letter from group index
            char groupLetter =(char)(groupNumber + 65);

            drawnGroupTextBox.Text = $"Group {groupLetter}!";


            AddTeamToGroup(groupNumber, club);

            HideGroupBalls();
            EnableTeamBallsPictureBox();

            //Check if round is over
            if (drawRound < 4)
            {
                if (leftTeams == 0)
                {
                    leftTeams = 8;
                    drawRound++;
                    ResetTeamBalls();
                }
            }
        }

        private void ball1PictureBox_Click(object sender, EventArgs e)
        {
            ClubIsDrawn(ball1PictureBox);

        }

        private void ball2PictureBox_Click(object sender, EventArgs e)
        {
            ClubIsDrawn(ball2PictureBox);
        }

        private void ball3PictureBox_Click(object sender, EventArgs e)
        {
            ClubIsDrawn(ball3PictureBox);
        }

        private void ball4PictureBox_Click(object sender, EventArgs e)
        {
            ClubIsDrawn(ball4PictureBox);
        }

        private void ball5PictureBox_Click(object sender, EventArgs e)
        {
            ClubIsDrawn(ball5PictureBox);
        }

        private void ball6PictureBox_Click(object sender, EventArgs e)
        {
            ClubIsDrawn(ball6PictureBox);
        }

        private void ball7PictureBox_Click(object sender, EventArgs e)
        {
            ClubIsDrawn(ball7PictureBox);
        }

        private void ball8PictureBox_Click(object sender, EventArgs e)
        {
            ClubIsDrawn(ball8PictureBox);
        }

        private void groupBall1pictureBox_Click(object sender, EventArgs e)
        {
            GroupIsDrawn(sender as PictureBox);

        }

        private void groupBall2pictureBox_Click(object sender, EventArgs e)
        {
            GroupIsDrawn(sender as PictureBox);
        }

        private void groupBall3pictureBox_Click(object sender, EventArgs e)
        {
            GroupIsDrawn(sender as PictureBox);
        }

        private void groupBall4pictureBox_Click(object sender, EventArgs e)
        {
            GroupIsDrawn(sender as PictureBox);
        }

        private void groupBall5pictureBox_Click(object sender, EventArgs e)
        {
            GroupIsDrawn(sender as PictureBox);
        }

        private void groupBall6pictureBox_Click(object sender, EventArgs e)
        {
            GroupIsDrawn(sender as PictureBox);
        }

        private void groupBall7pictureBox_Click(object sender, EventArgs e)
        {
            GroupIsDrawn(sender as PictureBox);
        }

        private void groupBall8pictureBox_Click(object sender, EventArgs e)
        {
            GroupIsDrawn(sender as PictureBox);
        }
    }
}
