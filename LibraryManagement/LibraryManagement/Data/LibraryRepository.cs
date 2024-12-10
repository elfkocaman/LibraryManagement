using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{
    public class LibraryRepository
    {
        private readonly LibraryContext _context;
        public LibraryRepository()
        {
            _context = new LibraryContext();
        }
        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }
        public void UpdateBook(Book book)
        {
            var existingBook = _context.Books.Find(book.BookId);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.PublishedYear = book.PublishedYear;
                existingBook.Genre = book.Genre;
                _context.SaveChanges();
            }

        }
        public void DeleteBook(int bookId)
        {
            var book = _context.Books.Find(bookId);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }



    }
}
