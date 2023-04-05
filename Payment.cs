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

namespace LastProject
{
    public partial class Payment : Form
    {
        List<Payments> paymentlist = new List<Payments>();

        public Payment()
        {
            InitializeComponent();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment ap = new AddPayment();
            ap.ShowDialog();

            if (ap.DialogResult == DialogResult.OK)
            {
                Payments newPayment = ap.getPayment();
                //Add new Payment to List
                this.paymentlist.Add(newPayment);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = paymentlist;

                ap.Close();
            }
        }
    }
}
