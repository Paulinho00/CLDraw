﻿using CLDraw.Models;
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
    public partial class AddClubForm : Form
    {
        public Pots pots { get; }
        public AddClubForm(Pots pots)
        {
            InitializeComponent();
            this.pots = pots;
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));
        }
    }
}
