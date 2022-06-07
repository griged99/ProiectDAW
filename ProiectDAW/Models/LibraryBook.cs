﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Models
{
    public class LibraryBook
    {
        public Guid BookId { get; set; }

        public Book Book { get; set; }

        public Guid LibraryId { get; set; }

        public Library Library { get; set; }
    }
}
