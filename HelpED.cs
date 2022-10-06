using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGost
{
    public partial class HelpED : Form
    {
        public HelpED()
        {
            InitializeComponent();

            var uri = new Uri(Application.StartupPath + "/2.htm");

            webBrowser1.Navigate(uri);
        }
    }
}
