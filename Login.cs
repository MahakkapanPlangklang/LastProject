using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Login : Form
    {
        private List<User> userList = new List<User>();
        public Login()
        {
            InitializeComponent();

            userList.Add(new User { Username = "user1", Password = "password1" });
            userList.Add(new User { Username = "user2", Password = "password2" });
            userList.Add(new User { Username = "user3", Password = "password3" });
            userList.Add(new User { Username = "1", Password = "1" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = userList.FirstOrDefault(u => u.Username == textBox1.Text && u.Password == textBox2.Text);

            if (user != null)
            {
                MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                Mainform mainForm = new Mainform(); // สร้าง instance ของ main form
                mainForm.Show(); // เปิด main form
                this.Hide(); // ซ่อน log in form

            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
            }
        }

        public User GetCurrentUser()
        {
            // ส่งข้อมูลผู้ใช้งานกลับไปยัง Main Form
            string username = textBox1.Text;
            User user = userList.FirstOrDefault(u => u.Username == username);
            return user;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
