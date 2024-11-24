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
    public partial class languageSelectForm : Form
    {

        public class variable
        {
            private static string languageVar = null;
            public static string language
            {
                get { return languageVar; }
                set { languageVar = value; }
            }
        }

        public languageSelectForm()
        {
            InitializeComponent();
        }

        private void csharpButton_Click(object sender, EventArgs e)
        {
            variable.language = "C#";
        }

    }
}
