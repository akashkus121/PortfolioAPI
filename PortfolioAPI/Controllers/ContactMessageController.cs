using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Data;
using PortfolioAPI.Models;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactMessageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ContactMessageController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<ContactMessage>>PostMessage(ContactMessage message)
        {
                   _context.ContactMessages.Add(message);
            await _context.SaveChangesAsync();
            return Ok(message);
        }
    }
}
