using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new Book[]
        {
            new Book(1, "Art of programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C programming language")
        };
        public Book[] GetAllByTitle(string titlePart)
        {
            if(titlePart == null)
            {
                return null;
            }
            return books.Where(book => book.Title.ToLower().Contains(titlePart.ToLower())).ToArray();
        }
    }
}
