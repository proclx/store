using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new Book[]
        {
            new Book(1, "ISBN 12345-67890", "D. Knutt", "Art of programming"),
            new Book(2, "ISBN 12345-67891", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN 12345-67892", "M. Ritchie", "C programming language")
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn.ToUpper().Equals(isbn))
                .ToArray();
        }

        public Book[] GetAllByTitleOfAuthor(string titlePart)
        {
            return books.Where(book => book.Title.ToLower().Contains(titlePart.ToLower())
                || book.Author.ToLower().Contains(titlePart.ToLower()))
                .ToArray();
        }
    }
}
