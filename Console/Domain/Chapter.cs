using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Chapter
    {
        public string Name { get; set; }
        public List<SubChapter> chapters { get; set; }
        public Chapter(string Name)
        {
            this.Name = Name;
            chapters = new List<SubChapter>();
        }

        public int createSubChapter(string title)
        {
            SubChapter chapter = new SubChapter(title);
            chapters.Add(chapter);
            return chapters.Count - 1;
        }

        public SubChapter getSubChapter(int index)
        {
            return chapters[index];
        }
        public void print()
        {
            Console.WriteLine(Name);
            foreach(SubChapter chapter in chapters)
            {
                chapter.print();
            }
        }
    }
}
