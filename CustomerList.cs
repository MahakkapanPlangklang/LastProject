using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProject
{
    public partial class CustomerList : Form
    {
        bool isFirstTime = true;
        public CustomerList()
        {
            InitializeComponent();
        }

        private void บนทกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ใช้ OpenFileDialog เพื่อเลือกไฟล์ CSV
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // อ่านข้อมูลจากไฟล์ CSV และเก็บไว้ใน DataTable
                DataTable dataTable = new DataTable();
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string[] headers = reader.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                    while (!reader.EndOfStream)
                    {
                        string[] rows = reader.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }

                // ใส่ข้อมูลใน DataTable ไปยัง DataGridView
                dataGridView1.DataSource = dataTable;

                // กำหนด HeaderText ของคอลัมน์
                dataGridView1.Columns[0].HeaderText = "ชื่อ";
                dataGridView1.Columns[1].HeaderText = "เบอร์โทรศัพท์";
            }

        }
    }
}

