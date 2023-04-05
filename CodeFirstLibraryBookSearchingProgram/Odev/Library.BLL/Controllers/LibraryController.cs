using Library.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Odev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Controllers
{
    public static class LibraryController
    {
        public static LibraryEntities _context = new LibraryEntities();

        public static void AddBook(string bookName, string authorName)
        {
            Book book = new Book();
            book.BookName= bookName;
            var author = _context.Authors.FirstOrDefault(x => x.AuthorFullName == authorName);
            if (author == null)
            {
                author = new Author();
                author.AuthorFullName = authorName;                
                _context.Authors.Add(author);
                _context.SaveChanges();
            }
            book.AuthorID = author.AuthorID;
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        
        public static bool UpdateData(int id, string bookName, string authorName)
        {
            try
            {
                var book = _context.Books.Include(x => x.Author).Where(x => x.BookID == id).First();
                book.BookName = bookName;
                book.Author.AuthorFullName = authorName;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool DeleteBook(int bookID)
        {
            var deletedBook = _context.Books.Where(x => x.BookID == bookID).FirstOrDefault();
            _context.Books.Remove(deletedBook);
            _context.SaveChanges();
            return true;
        }
        public static List<BookViewModel> GetBooks()
        {
            return _context.Books.Select(x => new BookViewModel { ID = x.BookID, AuthorName = x.Author.AuthorFullName, BookName = x.BookName }).ToList();

        }
    }
}
