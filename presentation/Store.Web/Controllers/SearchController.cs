using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    // все працює так, що коли сервер отримує запит /search?query="..."
    // то програма знайде цей контроллер, знайде метод Index(за замовчуванням)
    // і запустить його, він в свою чергу викликає метод View який і генерує сторінку
    public class SearchController : Controller
    {
        private readonly BookService bookService;
        public SearchController(BookService bookService)
        {
            this.bookService = bookService;
        }
        public IActionResult Index(string query)
        {
            var books = bookService.GetAllByQuery(query);
            return View(books);
        }
    }
}
