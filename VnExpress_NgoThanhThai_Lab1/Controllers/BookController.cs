using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VnExpress_NgoThanhThai_Lab1.Models;

namespace VnExpress_NgoThanhThai_Lab1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTML5 & CSS3 The complete Manual - Author Name Book 1");
            books.Add("HTML5 & CSS3 Responsive web Design cookbook - Author Name Book 2");
            books.Add("Professional ASP.NET MVC5 - Author Name Book 3");
            ViewBag.Books = books;
            return View();
        }
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 The complete Manual", "Author Name Book 1", "/Content/Image/book1.jpg"));
            books.Add(new Book(1, "HTML5 & CSS3 Responsive web Design cookbook", "Author Name Book 2", "/Content/Image/book2.jpg"));
            books.Add(new Book(1, "Professional ASP.NET MVC5", "Author Name Book 3", "/Content/Image/book3.jpg"));
            return View(books);
        }
        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 The complete Manual", "Author Name Book 1", "/Content/Image/book1.jpg"));
            books.Add(new Book(1, "HTML5 & CSS3 Responsive web Design cookbook", "Author Name Book 2", "/Content/Image/book2.jpg"));
            books.Add(new Book(1, "Professional ASP.NET MVC5", "Author Name Book 3", "/Content/Image/book3.jpg"));
            Book book = new Book();
            foreach( Book b in books)
            {
                if(b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if(book == null)
            {
                return HttpNotFound();

            }
            return View(books);
        }
    }
}