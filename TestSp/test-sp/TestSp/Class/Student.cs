using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSp.Class
{
    public class Student: Element
    {
        public string name { get; set; }
        public string email { get; set; }
        public Student(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public Element add(Element element)
        {
            throw new NotImplementedException();
        }

        public Element get(int pos)
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            Console.WriteLine(this.name);
        }

        public void remove(Element element)
        {
            throw new NotImplementedException();
        }
        public void accept(Visitor visitor)
        {
            visitor.visitStudent(this);
        }
    }
}
