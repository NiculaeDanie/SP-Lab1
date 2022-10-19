namespace Domain
{
    public class Book: Section
    {
        public Book(string title) : base(title)
        {
            this.Author=new List<Author>();
        }

        List<Author> Author { get; set; }

        
       
        public void addAuthor(Author author)
        {
            this.Author.Add(author);
        }
      
        public void print()
        {
            Console.WriteLine(this.title);
            foreach (Author author in this.Author)
            {
                author.print();
            }
            foreach(Element section in this.element)
            {
                section.print();
            }
        }

    }
}