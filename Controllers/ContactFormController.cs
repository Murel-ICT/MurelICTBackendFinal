using Microsoft.AspNetCore.Mvc;
using MurelICTBackend.Models;
using MurelICTBackend.Data;

namespace MurelICTBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactFormController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactFormController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult PostForm(ContactForm form)
        {
            _context.ContactForms.Add(form);
            _context.SaveChanges();
            return Ok(new { message = "Form submitted successfully!" });
        }
    }
}


