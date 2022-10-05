namespace Domain
{
    public class Book
    {
        string Title { get; set; }
        List<IBookComponent> Content { get; set; }
        public Book(string title)
        {
            this.Title = title;
            this.Content = new List<IBookComponent>();
        }
        public void createNewParagraph(string paragraph)
        {
            this.Content.Add(new Paragraph(paragraph));
        }
        public void createNewImage(string image)
        {
            this.Content.Add(new Image(image));
        }
        public void createNewTable(string table)
        {
            this.Content.Add(new Table(table));
        }
        public void print()
        {
            Console.WriteLine(this.Title);
            foreach (IBookComponent a in this.Content)
            {
                Console.WriteLine(a.toString());
            }

        }
    }
}