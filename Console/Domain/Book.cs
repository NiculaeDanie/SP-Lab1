namespace Domain
{
    public class Book
    {
        string Title { get; set; }
        List<Author> Author { get; set; }
        List<Element> Sections { get; set; }
        public Book(string title)
        {
            this.Title = title;
            Author = new List<Author>();
            Sections = new List<Element>();
        }
        public Element getSections(int index)
        {
            return Sections[index];
        }
        public void addAuthor(Author author)
        {
            this.Author.Add(author);
        }
        public void addContent(Element element)
        {
            Sections.Add(element);
        }
        public void print()
        {
            Console.WriteLine(this.Title);
            foreach (Author author in this.Author)
            {
                author.print();
            }
            foreach(Element section in Sections)
            {
                section.print();
            }
        }

    }
}