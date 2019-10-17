//****************************************************************
// Programmer: Delya Peter
// 
// Programming in Visual Studio 2019
// Date: 25 September 2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64­bit
// Purpose: Assesment 1b
//****************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1b
{
    public partial class Course : Form
    {
        //Array 
        MyCourse[] mycourses= new MyCourse[3];
        int Count = 0;
        public Course()
        {
            InitializeComponent();
                    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
                        
            if (Count < 3)
            {
                MyCourse course = new MyCourse();
                course.name = txtBx1.Text;
                course.courseId = Convert.ToInt32(txtBx2.Text);
                course.fee = Convert.ToDouble(txtBx3.Text);
                course.duration = txtBx4.Text;
                mycourses[Count] = course;
                Count++;
                //To display the contents in the text box
                displayTxtBx.Items.Add(txtBx1.Text);
                displayTxtBx.Items.Add(txtBx2.Text);
                displayTxtBx.Items.Add(txtBx3.Text);
                displayTxtBx.Items.Add(txtBx4.Text);
            }
            else
            {
                lblMsg.Text = "You reached maximum courses";
            }

            //To clear the text box
            txtBx1.Clear();
            txtBx2.Clear();
            txtBx3.Clear();
            txtBx4.Clear();
        }
        //To Exit from the application
            private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBx4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
