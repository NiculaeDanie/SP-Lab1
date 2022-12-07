using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DocumentManager
    {
        private static DocumentManager instance;
        private Book book;
        private DocumentManager()
        {

        }
        public static DocumentManager getInstance()
        {
            if (instance == null)
            {
                instance = new DocumentManager();
            }
            return instance;
        }
        public void setBook(Book book)
        {
            this.book = book; 
        }
        public Book getBook()
        {
            return this.book;
        }
    }
}
