﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace начало_работы.Models
{
    public class book
    {
        // ID книги
        public int Id { get; set; }
        // название книги
        public string Name { get; set; }
        // автор книги
        public string Author { get; set; }
        // цена
        public int Price { get; set; }
    }
}