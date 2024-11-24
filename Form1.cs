using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmer_Project_Hub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void newLanguageButton_Click(object sender, EventArgs e)
        {
            languageSelectForm f1 = new languageSelectForm();
            f1.ShowDialog();
            if (languageSelectForm.variable.language != null)
            {
                if (button1.Visible == false)
                {
                    button1.Visible = true;
                    button1.Text = languageSelectForm.variable.language;
                }
                else if (button2.Visible == false)
                {
                    button2.Visible = true;
                    button2.Text = languageSelectForm.variable.language;
                }
                else if (button2.Visible == false)
                {
                    button3.Visible = true;
                    button3.Text = languageSelectForm.variable.language;
                }
            }
        }
    }
}
