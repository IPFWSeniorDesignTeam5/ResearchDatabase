using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_Research_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'researchDatabaseDataSet.Platform' table. You can move, or remove it, as needed.
            this.platformTableAdapter.Fill(this.researchDatabaseDataSet.Platform);

            // TODO: This line of code loads data into the 'researchDatabaseDataSet.Application' table. You can move, or remove it, as needed.
            this.applicationTableAdapter.Fill(this.researchDatabaseDataSet.Application);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
