using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class MenuForm : Form
    {
        AboutForm myF3;

        CalcUI calcUI;        

        // DRY refactoring
        private void coloredChecker (CheckBox cb)
        {
            if (cb.Checked)
            {
                cb.ForeColor = Color.Black;
            }
            else
            {
                cb.ForeColor = Color.Gray;
            }
        } 

        private void groupCheckerForCheckBoxes (CheckBox cb1, CheckBox cb2, CheckBox cb3)
        {
            if (cb1.Checked)
            {
                cb2.Checked = cb3.Checked = false;
            }
            else if (cb2.Checked)
            {
                cb1.Checked = cb3.Checked = false;
            }
            else
            {
                cb1.Checked = cb2.Checked = false;
            }
        }

        public MenuForm()
        {           
            InitializeComponent();            

            AboutCheckBox.ForeColor = Color.Gray;
            myF3 = new AboutForm();
            //myF3.StartPosition = FormStartPosition.Manual;
            //myF3.Location = new Point(this.Location.X, this.Location.Y + 466);
            myF3.Hide();

            

            coloredChecker(AboutCheckBox);
            coloredChecker(checkBox2);
            coloredChecker(checkBox3);                

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutForm myF3 = new AboutForm();
            myF3.StartPosition = FormStartPosition.Manual;
            myF3.Location = new Point(this.Location.X, this.Location.Y + 466);
            myF3.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                calcUI = new CalcUI();
                calcUI = this.Owner as CalcUI;
                calcUI.ResizeForm(372, 440);
                calcUI.ExtraPanelViewer(0);

                checkBox2.ForeColor = Color.Black;
                checkBox3.Checked = false;
                checkBox3.ForeColor = Color.Gray;                
            }
            else
            {
                
            }
        }        

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                calcUI = new CalcUI();
                calcUI = this.Owner as CalcUI;
                calcUI.ResizeForm(472, 440);
                calcUI.ExtraPanelViewer(1);

                checkBox3.ForeColor = Color.Black;
                checkBox2.Checked = false;
                checkBox2.ForeColor = Color.Gray;
               
            }
            else
            {
                
            }            
        }

        private void AboutCheckBox_Click(object sender, EventArgs e)
        {
            //AboutForm myF3 = new AboutForm();
            myF3.StartPosition = FormStartPosition.Manual;
            myF3.Location = new Point(this.Location.X, this.Location.Y + 445);

            if (AboutCheckBox.Checked)
            {
                AboutCheckBox.ForeColor = Color.Black;
                myF3.Show();
            }
            else
            {
                AboutCheckBox.ForeColor = Color.Gray;
                myF3.Hide();
            }
        }

        private void AboutCheckBox_MouseLeave(object sender, EventArgs e)
        {            
            AboutCheckBox.Checked = false;
            AboutCheckBox.ForeColor = Color.Gray;
            myF3.Hide();
        }
    }
}
