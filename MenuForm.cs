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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LastProject
{
    public partial class MenuForm : Form
    {
        List<Menu> listMenu = new List<Menu>();
        public MenuForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menuform = new Form1();
            menuform.ShowDialog();

            if (menuform.DialogResult == DialogResult.OK)
            {
                Menu menu = menuform.getMenu();
                //Add new Player to List
                this.listMenu.Add(menu);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listMenu;
                //Add list to Datagrid view
                menuform.Close();
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.RowTemplate.Height = 200;

            //dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 100;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)column).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }

            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "imageColumn") // ชื่อ column ของรูปภาพ
            {
                if (e.Value != null)
                {
                    Image image = (Image)e.Value;
                    int maxsize = 100; // ขนาดภาพสูงสุดที่ต้องการ
                    int h = image.Height;
                    int w = image.Width;

                    if (h > maxsize || w > maxsize) // ตรวจสอบว่าภาพมีขนาดเกิน 100x100 หรือไม่
                    {
                        int newh = h, neww = w;
                        if (h > w) // ถ้าสูงกว่ากว้าง ให้ปรับความสูงเป็น 100 และปรับความกว้างให้สัดส่วน
                        {
                            newh = maxsize;
                            neww = (int)Math.Round((double)w / h * maxsize);
                        }
                        else // ถ้ากว้างกว่าสูง ให้ปรับความกว้างเป็น 100 และปรับความสูงให้สัดส่วน
                        {
                            neww = maxsize;
                            newh = (int)Math.Round((double)h / w * maxsize);
                        }
                        // ปรับขนาดภาพด้วยฟังก์ชัน GetThumbnailImage
                        e.Value = image.GetThumbnailImage(neww, newh, null, IntPtr.Zero);
                    }
                }
            }
        }
    }
}
