using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LastProject
{
    public class Menu
    {
        public string menuname;
        public string detail;
        public int price;
        public Bitmap image;

        public Menu(string menuname, string detail, int price, Bitmap image)
        {
            this.menuname = menuname;
            this.detail = detail;
            this.price = price;
            this.image = image;
        }
        public string Menuname { get => menuname; }
        public string Detail { get => detail; }
        public int Price { get => price; }
        public Bitmap Image { get => image; }
    }
}
