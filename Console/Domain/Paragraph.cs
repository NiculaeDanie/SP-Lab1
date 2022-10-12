using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Paragraph
    {
        public string text { get; set; }

        public Paragraph(string text) { this.text = text; }

        public void print()
        {
            Console.WriteLine(this.text);
        }
    }
}
