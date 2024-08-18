using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_practice_3.MVC_View.Login
{
    public partial class LoginForm : UserControl
    {
        public Master masterForm;
        public LoginForm(Master masterForm)
        {
            InitializeComponent();
            this.masterForm = masterForm;
        }
    }
}
