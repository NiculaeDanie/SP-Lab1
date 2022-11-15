using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface AlignStrategy
    {
        void render(string paragraph,string context);
    }
}
