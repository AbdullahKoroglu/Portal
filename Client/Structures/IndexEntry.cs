﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Structures
{
    public class IndexEntry
    {
        public string FileName { get; set; }
        public string FileHash { get; set; }
        public bool Delete { get; set; }
    }
}
