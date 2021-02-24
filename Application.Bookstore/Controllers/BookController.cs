using Application.Bookstore.Models;
using Application.Bookstore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository __bookRepository = null;
        public BookController()
        {
            __bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return __bookRepository.GetAllBooks();
        }
        public BookModel GetBook(int id)
        {
            return __bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return __bookRepository.SearchBook(bookName,authorName);
        }
    }
}
