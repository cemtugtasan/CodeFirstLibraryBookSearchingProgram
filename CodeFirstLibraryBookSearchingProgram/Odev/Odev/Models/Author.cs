﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Models
{
    internal class Author
    {
        public int AuthorID  { get; set; }
        public string AuthorFullName { get; set; }
        public ICollection<Book> Books { get; set; }    
    }
}
