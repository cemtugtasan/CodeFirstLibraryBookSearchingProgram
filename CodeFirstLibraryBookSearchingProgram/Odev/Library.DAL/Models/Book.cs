﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public Author Author { get; set; }
        public int AuthorID { get; set; }
    }
}
