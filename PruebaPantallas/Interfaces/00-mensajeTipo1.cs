﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPdeDiseño
{
    public partial class mensajeTipo1 : Form
    {

        public string mensaje;
        
        public mensajeTipo1()
        {
            InitializeComponent();
        }

        private void mensajeTipo1_Load(object sender, EventArgs e)
        {
            lExito.ForeColor = Color.Green;
            lExito.Text = mensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
