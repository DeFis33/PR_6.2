﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2
{
    public partial class Studio : Form
    {
        public Studio()
        {
            InitializeComponent();
        }
        private void btnEntrance_Click(object sender, EventArgs e)
        {
            AtelierWork atelierWork = new AtelierWork();
            atelierWork.Show();
            Hide();
        }
    }
}