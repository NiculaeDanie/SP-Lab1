using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AlignLeft : AlignStrategy
    {
        public void render(string paragraph, string context)
        {
            Console.Write(paragraph);
        }
    }
}
