using project_practice_3.MVC_View.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_practice_3.MVC_View.Login;

namespace project_practice_3
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();

        }

        private void Master_Load(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm(this);
            loginform.Dock = DockStyle.Fill;
            pnlLogin.Controls.Add(loginform);
        }
    }
}
