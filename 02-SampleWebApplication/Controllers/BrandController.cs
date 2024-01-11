using _02_SampleWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _02_SampleWebApplication.Controllers
{
    public class BrandController : Controller
    {
        private readonly TestContext _context;

        public BrandController(TestContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.ToListAsync());
        }
    }
}
