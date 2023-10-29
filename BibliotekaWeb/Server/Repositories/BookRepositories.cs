using BibliotekaWeb.Server.Repositoires;
using BibliotekaWeb.Shared;
using BibliotekaWeb.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BibliotekaWeb.Server.Repositoires
{
    public class BookRepositories : IBook
    {
        public static string connString = "Data Source=S:\\BibliotekaDB.db";
        readonly DataBaseContext _dbContext = new DataBaseContext();
        
        public BookRepositories()
        {
            _dbContext.Database.EnsureCreated();
        }
        public void AddBook(Book book)
        {
            try
            {
                
                _dbContext.Add(book);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetAllBooks()
        {
            try
            {
                return _dbContext.Books.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void RemoveBook(int id)
        {
            try
            {
                Book? book = _dbContext.Books.Find(id);
                if (book != null)
                {
                    _dbContext.Books.Remove(book);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw new ArgumentException();
            }
        }

        public void UpdateBook(Book book)
        {
            try
            {
                var existingBook = _dbContext.Books.Find(book.ID);
                if (existingBook != null)
                {
                    _dbContext.Entry(existingBook).State = EntityState.Detached;
                }

                _dbContext.Update(book);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw new ArgumentException(); ;
            }
        }
        public Book GetBook(int id)
        {
            try
            {
                Book book = _dbContext.Books.Find(id);
                if(book != null)
                {
                    return book;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
