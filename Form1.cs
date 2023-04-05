using System.Numerics;

namespace LastProject
{
    public partial class Form1 : Form
    {
        private Menu menu;
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string menuname = textBox1.Text;
            string detail = textBox2.Text;
            // string price = textBox3.Text;
            // int p = Int32.Parse(price);
            Bitmap image = new Bitmap(pictureBox1.Image);
            int p = 0;
            try
            {
                string price = textBox3.Text;
                p = Int32.Parse(price);
            }
            catch (FormatException ex)
            {
                //Do something if have some exception
                MessageBox.Show("โปรดป้อนตัวเลข");
                return;
            }
            // สร้างคลาสใหม่
            menu = new Menu(menuname, detail, p, image);
            this.DialogResult = DialogResult.OK;


        }
        public Menu getMenu() { return menu; }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // ตั้งค่าให้ OpenFileDialog แสดงไฟล์รูปภาพเท่านั้น
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

            // เมื่อผู้ใช้กด OK เพื่อเลือกไฟล์
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // อ่านข้อมูลจากไฟล์ภาพที่เลือก
                string selectedFileName = openFileDialog.FileName;

                // แสดงภาพใน PictureBox
                pictureBox1.Image = Image.FromFile(selectedFileName);

            }
            // this.DialogResult = DialogResult.OK;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}