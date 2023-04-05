using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LastProject
{
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider3.SetError(textBox3, "");
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "you should enter name's customer.");
            }
            else if (textBox3.Text == "")
            {

                errorProvider3.SetError(textBox3, "you should enter PhoneNumber's customer.");

            }
            else
            {
                DialogResult = DialogResult.OK;

            }
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
