using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace SimpleCalculator
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            //AboutForm aForm = new AboutForm();
            //aForm.Size = new Size(624, 50);
            VersionInfo.Text = CalcEngine.GetVersion();            
        }
    }
}
