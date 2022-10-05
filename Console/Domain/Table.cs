using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Table : IBookComponent
    {
        public string Content { get; set; }

        public Table(string content) { Content = content; }

        public string toString()
        {
            return this.Content;
        }
    }
}
