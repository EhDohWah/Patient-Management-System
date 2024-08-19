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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lblFI_Click(object sender, EventArgs e)
        {

        }

        private void btnRT_Click(object sender, EventArgs e)
        {
            // define singer variable
            string fingerType = "Right Thumb";
            Scanner scanner = new Scanner(fingerType);
            scanner.ShowDialog();

        }

        private void BtnRI_Click(object sender, EventArgs e)
        {
            // define singer variable
            string fingerType = "Right Index";
            Scanner scanner = new Scanner(fingerType);
            scanner.ShowDialog();
        }

        private void BtnRM_Click(object sender, EventArgs e)
        {
            // define singer variable
            string fingerType = "Right Middle";
            Scanner scanner = new Scanner(fingerType);
            scanner.ShowDialog();
        }

        private void BtnRR_Click(object sender, EventArgs e)
        {
            // define singer variable
            string fingerType = "Right Ring";
            Scanner scanner = new Scanner(fingerType);
            scanner.ShowDialog();
        }

        private void BtnRP_Click(object sender, EventArgs e)
        {
            // define singer variable
            string fingerType = "Right Pinkie";
            Scanner scanner = new Scanner(fingerType);
            scanner.ShowDialog();
        }

        private void BtnTestViewDetail_Click(object sender, EventArgs e)
        {
            PatientRecordForm frm = new PatientRecordForm();
            frm.ShowDialog();
        }
    }
}
