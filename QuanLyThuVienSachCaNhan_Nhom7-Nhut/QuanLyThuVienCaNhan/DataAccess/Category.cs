﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Category(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public Category()
        {

        }
    }
}
