﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProject
{
    public class Customer
    {   public string Name { get; set; }
        public string Phone { get; set; }
        public List<int> chairs { get; set; }
        public Customer() 
        {
            chairs = new List<int>();
        }
        

        public double Price
        {
            get {  return chairs.Count*10; }
        }
        public string PhoneN
        {
            get { return Phone; }
        }
        public string NameC
        {
            get { return Name; }
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
