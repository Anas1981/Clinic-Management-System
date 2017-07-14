using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System.PL
{
    public partial class staff_management : Form
    {
        public staff_management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            staff_form frm = new staff_form(true);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staff_form frm = new staff_form(true);
            frm.ShowDialog();
        }
    }
}
