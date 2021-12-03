using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Northwind_API.Data;
using Northwind_API.Models;

namespace Northwind_API.Controllers
{

    public class ProductController : Controller
    {
        public readonly ILogger<ProductController> _logger;
        public readonly DataContext _context;


        public ProductController(ILogger<ProductController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Info.ToList());
        }

        
    }
}