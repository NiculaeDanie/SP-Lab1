using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AlignCenter : AlignStrategy
    {
        public void render(string paragraph, string context)
        {
            Console.WriteLine("\t\t"+paragraph);
        }
    }
}
