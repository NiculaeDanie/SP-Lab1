using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Domain
{
    public class SubChapter
    {
        public string Name { get; set; }
        public List<Paragraph> paragraph { get; set; }
        public List<Image> image { get; set; }
        public List<Table> table { get; set; }
        public SubChapter(string Name)
        {
            this.Name = Name;
            paragraph = new List<Paragraph>();
            image = new List<Image>();
            table = new List<Table>();
        }

        public void createNewParagraph(string paragraph)
        {
            this.paragraph.Add(new Paragraph(paragraph));
        }
        public void createNewImage(string image)
        {
            this.image.Add(new Image(image));
        }
        public void createNewTable(string table)
        {
            this.table.Add(new Table(table));
        }
        public void print()
        {
            Console.WriteLine(this.Name);
            foreach(Paragraph paragraph in this.paragraph)
            {
                paragraph.print();
            }
            foreach (Image image in this.image)
            {
                image.print();
            }
            foreach (Table table in this.table)
            {
                table.print();
            }
        }
    }
}
