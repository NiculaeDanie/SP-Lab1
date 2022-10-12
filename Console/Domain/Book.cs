namespace Domain
{
    public class Book
    {
        string Title { get; set; }
        Author Author { get; set; }
        TableOfContents TableOfContents { get; set; }
        List<Chapter> Chapters { get; set; }
        public Book(string title)
        {
            this.Title = title;
            TableOfContents = new TableOfContents();
            Chapters = new List<Chapter>();
        }
        public Chapter getChapter(int index)
        {
            return Chapters[index];
        }
        public int createChapter(string title)
        {
            Chapter chapter = new Chapter(title);
            Chapters.Add(chapter);
            return Chapters.Count-1;
        }
        public void addAuthor(Author author)
        {
            this.Author = author;
        }
        public void print()
        {
            Console.WriteLine(this.Title);
            this.Author.print();
            this.TableOfContents.print();
            foreach(Chapter chapter in Chapters)
            {
                chapter.print();
            }
        }

    }
}