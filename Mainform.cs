using CsvHelper;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


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
                MessageBox.Show("โต๊ะหมายเลข" + "" + label.Text + "" + "ถูกจองไปแล้ว");
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
                DisplayCustomerinListbox();
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

        private void DisplayCustomerinListbox()
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
            if (NameList.SelectedIndex != -1)
            {
                for (int i = 0; i < table.Controls.Count; i++)
                {
                    Label label = table.Controls[i] as Label;
                    int Cchair = int.Parse(label.Text);
                    int flag = 0;
                    while (c.chairs.Count > 0 && flag < c.chairs.Count)
                    {
                        int orderedchair = c.chairs[0];
                        if (Cchair == orderedchair)
                        {
                            label.BackColor = Color.White;
                            c.chairs.Remove(orderedchair);
                        }
                        flag++;
                    }
                }
                customerlist.Remove(c);
                DisplayTotalMoney();
                DisplayCustomerinListbox();
            }
            else
            {
                MessageBox.Show("โปรดเลือก");
            }
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ลอคเอาทToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); // สร้าง instance ของ log in form
            loginForm.Show(); // เปิด log in form
            this.Hide(); // ซ่อน main form
        }

        private void รายชอToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void บนทกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveListBoxToCSV();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void SaveListBoxToCSV()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (Customer item in NameList.Items)
                    {
                        sw.WriteLine($"{item.Name},{item.Phone}");
                    }
                }
                MessageBox.Show("Saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void OpenCSVToListBox()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NameList.Items.Clear();
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        NameList.Items.Add(line);
                    }
                }
                MessageBox.Show("Opened successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void เปดToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCSVToListBox();
        }

        private void รายชอToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //CustomerList cl = new CustomerList(); 
            //cl.Show(); 
            //this.Hide();
            this.Hide();
            CustomerList cl = new CustomerList();
            cl.ShowDialog();
            cl = null;
            this.Show();
        }
    }
}
