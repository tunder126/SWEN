using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelonixRegia_HMS_
{
    public partial class Form1 : Form
    {
        public string key = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (key == "")
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            key = "Hello";
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            //Check the availability of the hotel rooms
            //Display all results using database
                        
            
            lblAvailability.ForeColor = System.Drawing.Color.ForestGreen;
            lblAvailability.ForeColor = System.Drawing.Color.Crimson;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added Successfully");
            MessageBox.Show("Added Unsuccessfully");

            //clear all textbox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Checked Out");
        }

        private void btnRetrieveH_Click(object sender, EventArgs e)
        {
            btnViewStaff.Visible = true;
        }

    }
}
