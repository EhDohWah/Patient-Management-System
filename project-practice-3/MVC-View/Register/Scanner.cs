using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_practice_3.MVC_View.Register
{
    public partial class Scanner : Form
    {
        public string fingerType;

        public Scanner(string fingerType)
        {
            InitializeComponent();

            this.fingerType = fingerType;
            this.lblVariable.Text = fingerType.ToLower();

            
        }

        private void PbxClose_Click(object sender, EventArgs e)
        {

        }
    }
}
