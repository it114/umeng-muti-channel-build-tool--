using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UmengChannel
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isShow = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is ChangeLabelOnly)
                {
                    isShow = true;
                    f.BringToFront();
                    f.Focus();
                }
            }
            if (!isShow)
            {
                ChangeLabelOnly changeLabel = new ChangeLabelOnly();
                changeLabel.Show();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isShow = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is AllChangeLabel)
                {
                    isShow = true;
                    f.BringToFront();
                    f.Focus();
                }
            }
            if (!isShow)
            {
                AllChangeLabel changeLabel = new AllChangeLabel();
                changeLabel.Show();
            }

        }
    }
}
