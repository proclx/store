using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class BookService
    {
        // до певного моменту в нас був захардкоджений BookRepository який мав метод пошуку за фрагментом 
        // назви, цього недостатньо, оскільки ми хочемо додати пошук по ісбн і по автору, щоб зробити це
        // ми ввели цей клас, обовязком якого буде вирішувати перед нами ісбн, автор чи просто фрагмент 
        // назви книжки
        private readonly IBookRepository bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public Book[] GetAllByQuery(string query)
        {
            if(Book.IsIsbn(query))
            {
                return bookRepository.GetAllByIsbn(query);
            }
            else
            {
                return bookRepository.GetAllByTitleOfAuthor(query);
            }
        }
    }
}
