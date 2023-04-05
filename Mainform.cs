using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace LastProject
{
    public partial class Mainform : Form
    {
        List<Customer> customerlist = new List<Customer>();

        public Mainform()
        {
            InitializeComponent();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Draw100chairs()
        {
            int chair = 1;
            for (int i = 0; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    Label label = new Label();
                    label.Text = chair + "";
                    label.AutoSize = false;
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.BackColor = Color.White;

                    table.Controls.Add(label, i, j);

                    chair++;

                    label.Click += Label_Click;
                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label.BackColor == Color.White)
            {
                label.BackColor = Color.SkyBlue;
            }
            else if (label.BackColor == Color.SkyBlue)
            {
                label.BackColor = Color.White;
            }
            else if (label.BackColor == Color.YellowGreen)
            {
                MessageBox.Show("The chair" + label.Text + "is choose");
            }
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            Draw100chairs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo();



            if (ci.ShowDialog() == DialogResult.OK)
            {
                Customer c = new Customer();
                c.Name = ci.textBox1.Text;
                c.Phone = ci.textBox3.Text;

                for (int i = 0; i < table.Controls.Count; i++)
                {
                    Label label = table.Controls[i] as Label;
                    if (label.BackColor == Color.SkyBlue)
                    {
                        label.BackColor = Color.YellowGreen;
                        int chair = int.Parse(label.Text);
                        c.chairs.Add(chair);
                    }
                }
                price.Text = c.Price + "บาท";
                customerlist.Add(c);

                DisplayTotalMoney();
                DisplayCustomeinListbox();
            }
        }
        private void DisplayTotalMoney()
        {

            double totalMoney = 0;
            foreach (Customer c in customerlist)
            {
                totalMoney += c.Price;
                totalprice.Text = totalMoney + "บาท";
            }
        }

        private void DisplayCustomeinListbox()
        {
            NameList.Items.Clear();
            foreach (Customer c in customerlist)
            {
                NameList.Items.Add(c);
            }
        }

        private void NameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameList.SelectedIndex != -1)
            {
                Customer c = NameList.SelectedItem as Customer;
                price.Text = c.Price + "บาท";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = NameList.SelectedItem as Customer;
            if(NameList.SelectedIndex != -1)
            {
                for(int i = 0; i < table.Controls.Count; i++) 
                { 
                    Label label = table.Controls[i] as Label;
                    int Cchair = int.Parse(label.Text);
                    int flag = 0;
                    while(c.chairs.Count > 0 && flag < c.chairs.Count) 
                    {
                        int orderedchair = c.chairs[0];
                        if(Cchair == orderedchair)
                        {
                            table.BackColor = Color.White;
                            c.chairs.Remove(orderedchair);
                        }
                        flag++;
                    }
                }
                customerlist.Remove(c);
                DisplayTotalMoney();
                DisplayCustomeinListbox();
            }
            else
            {
                MessageBox.Show("โปรดเลือก");
            }
        }
    }
}
