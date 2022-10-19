using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Author
    {
        private string Name { get; set; }
        public Author(string name)
        {
            Name = name;
        }
        public void print()
        {
            Console.WriteLine(this.Name);
        }
    }
}
