﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Image
    {
        public string imageName { get; set; }

        public Image(string imageName) { this.imageName = imageName; }

        public void print()
        {
            Console.WriteLine(imageName);
        }
    }
}
