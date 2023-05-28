using KominApp.Core.Entities;
using KominApp.Core.Interfaces;
using KominApp.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KominApp.Infrastructure.Services
{
    public class BookService : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<Book>>> GetBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<ActionResult<List<Book>>> AddRecordToBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }


    }
}
