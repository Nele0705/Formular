﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formular2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string fVorname, fNachname, geschlecht, fBeruf;

      
        private void buttonSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void buttonSpeichernSenden_Click(object sender, EventArgs e)
        {
            fVorname = txtVorname.Text;
            fNachname = txtNachname.Text;
            fBeruf = txtBeruf.Text;

            if (radioButtonMännlich.Checked == false)
            {
                geschlecht = "weiblich";
            }
            else
            {
                geschlecht = "männlich";
            }

            MessageBox.Show("Name: " + fVorname + "\nNachname: " + fNachname + "\nGeschlecht: " + geschlecht + "\nBeruf: " + fBeruf);
        }
    }
}
