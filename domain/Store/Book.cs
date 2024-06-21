using System;
using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; }
        public string Isbn { get; }
        // краще якщо поле автор не стрінг, а код автора !!!
        public string Author { get; }
        public Book(int id, string isbn, string author, string title)
        {
            Id = id;
            Title = title;
            Isbn = isbn;
            Author = author;
        }
        // цей метод вперше був потрібен нам в класі BookService, однак краще його розмістити тут,
        // бо він знадобиться і в тестах, і якщо в майбутньому ми дамо користувачам право змінювати 
        // ісбн код (в такому разі потрібно буде здійснювати перевірки чи валідний код)
        internal static bool IsIsbn(string s)
        {
            if(s == null)
            {
                return false;
            }
            else
            {
                s = s.Replace("-", "")
                    .Replace(" ", "")
                    .ToUpper();
                return Regex.IsMatch(s, "^ISBN\\d{10}(\\d{3})?$");
            }
        }
    }
}
