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
    public partial class PatientRecordForm : Form
    {
        public PatientRecordForm()
        {
            InitializeComponent();
        }

        private void BtnCheckin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added patient successfully.", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
