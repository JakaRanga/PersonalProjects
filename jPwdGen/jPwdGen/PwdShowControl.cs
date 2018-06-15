using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jPwdGen.EntityF;

namespace jPwdGen
{
    public partial class PwdShowControl : UserControl
    {
        public PwdShowControl(PwdUser pwdUser, int loop)
        {
            this.Location = new Point(0, 50 * loop);
            InitializeComponent();
            this.softLabel.Text = pwdUser.LB_SOFT;
            this.pwdLabel.Text = pwdUser.LB_PWD;
            //295
        }
    }
}
