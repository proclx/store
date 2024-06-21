using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface IBookRepository
    {
        // prefix All when we expect multiple results;
        Book[] GetAllByIsbn(string isbn);
        Book[] GetAllByTitleOfAuthor(string titlePart);
    }
}
