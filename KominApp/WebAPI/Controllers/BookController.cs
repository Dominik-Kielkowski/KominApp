using KominApp.Core.Entities;
using KominApp.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KominApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookRepository bookRepository, ILogger<BookController> logger)
        {
            _bookRepository = bookRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            return await _bookRepository.GetBooksAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Book>> AddRecordToBooks()
        {
            var record = await _bookRepository.AddRecordToBooksAsync(); 

            return Ok(record);
        }
    }
}