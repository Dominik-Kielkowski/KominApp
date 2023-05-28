using KominApp.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KominApp.Core.Interfaces
{
    public interface IBookRepository
    {
        Task<ActionResult<List<Book>>> GetBooksAsync();
        Task<ActionResult<List<Book>>> AddRecordToBooksAsync();
    }
}
