using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSp.Class
{
    public class PrintVisitor : Visitor
    {
        public void visitAn(An an)
        {
            an.print();
            foreach( Element e in an.elements )
                e.accept(this);
        }

        public void visitGrupa(Grupa grupa)
        {
            grupa.print();
            foreach (Element e in grupa.elements)
                e.accept(this);
        }

        public void visitSemigrupa(Semigrupa semigrupa)
        {
            semigrupa.print();
            foreach (Element e in semigrupa.elements)
                e.accept(this);
        }

        public void visitStudent(Student student)
        {
            student.print();
        }
    }
}
