﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    internal class CheckRepeat
    {
        public HashSet<int> hash = new HashSet<int>();

        public void CreateHash(int id)
        {
            hash.Add(id);
        }

        public String HashString()
        {
            String hashString = "Коллекция хэша: ";
            foreach (var e in hash) { hashString = hashString + e + ", "; }
            return hashString;
        }
    }
}
