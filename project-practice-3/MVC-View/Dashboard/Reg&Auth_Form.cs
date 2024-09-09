using project_practice_3.MVC_View.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_practice_3.MVC_View.Authenticate.FingerPrint;

namespace project_practice_3.MVC_View.Dashboard
{
    public partial class Reg_Auth_Form : Form
    {
        public Reg_Auth_Form()
        {
            InitializeComponent();
        }

        private void BtnREG_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void BtnAuth_Click(object sender, EventArgs e)
        {
            FingerPrint_Authentication fingerPrint_Authentication = new FingerPrint_Authentication();
            fingerPrint_Authentication.ShowDialog();
        }
    }
}
