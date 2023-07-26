using CrudBucketMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace CrudBucketMVC.Controllers
{
    public class OwnerController : Controller
    {
        private readonly CrudBucketContext _context;

        public OwnerController(CrudBucketContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var owner = _context.Owners;

            return View(owner);
        }
    }
}
