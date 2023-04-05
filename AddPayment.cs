using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Globalization;

namespace LastProject
{
    public partial class AddPayment : Form
    {
        Payments paymentlist;
        public AddPayment()
        {
            InitializeComponent();
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table = textBox3.Text;
            string paymentDate = textBox2.Text;
            double a = 0;

            try
            {
                string amount = textBox1.Text;
                a = Double.Parse(amount);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("โปรดป้อนตัวเลข");
                return;
            }
            paymentlist=new Payments(a, paymentDate, table);

            this.DialogResult = DialogResult.OK;
        }
        public Payments getPayment()
        {
            return paymentlist;
        }
    }
}
