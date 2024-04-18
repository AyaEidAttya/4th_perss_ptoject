using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4th_perss_ptoject
{
    public partial class pressure : Form
    {
        public pressure()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            // Panel1
            Panel panel1 = new Panel();
            panel1.Dock = DockStyle.Right;
            panel1.Width = (int)(this.Width * 0.25); // 25% of the form's width
            this.Controls.Add(panel1);
            panel1.BackColor = Color.Red;

            // Panel2
            Panel panel2 = new Panel();
            panel2.Dock = DockStyle.Left;
            panel2.Width = (int)(this.Width * 0.75); // 25% of the form's width
            this.Controls.Add(panel2);
            panel2.BackColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
