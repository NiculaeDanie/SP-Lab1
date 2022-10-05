using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal interface IBookComponent
    {
        public string Content { get; set; }
        string toString();
    }
}
