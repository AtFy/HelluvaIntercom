using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelluvaIntercom
{
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
            textBox1.Text = "312";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
