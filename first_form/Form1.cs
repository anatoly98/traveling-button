using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_form
{
    public partial class Form : System.Windows.Forms.Form
    {
       private Random r = new Random();

        public Form()
        {
            InitializeComponent();
        }

 
        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void button_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control) return;

            button.Location = new Point(r.Next(ClientRectangle.Width - 5), r.Next(ClientRectangle.Height - 5));
        }
    }
}