using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnusualPlantsOfTheWorld
{
    public partial class Congratulations : Form
    {
        public Congratulations()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About fAb = new About();
            fAb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Close();

            
        }
    }
}
