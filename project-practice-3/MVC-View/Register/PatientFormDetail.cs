using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace project_practice_3.MVC_View.Register
{
    public partial class PatientFormDetail : Form
    {
        string PID;

        public PatientFormDetail(string PID)
        {
            InitializeComponent();
            this.PID = PID;
            tbxIDcard.Text = this.PID;
        }
    }
}
