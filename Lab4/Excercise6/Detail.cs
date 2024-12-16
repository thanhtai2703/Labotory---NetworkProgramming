using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise6
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }
        public Detail(Panel panel,string t)
        {
            InitializeComponent();
            panel.Dock = DockStyle.Fill;
            groupBox1.Text = t;
            groupBox1.Controls.Add(panel);
         
        }
    }
}
