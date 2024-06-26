using economus_cpp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace economus_cpp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, AppDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    ViewData["UserName"] = user.Name;

                    var totalReceipts = await _context.Receipts
                       .Where(r => r.ApplicationUserId == user.Id)
                       .SumAsync(r => r.ReceiptAmount);

                    var totalExpenses = await _context.Expenses
                        .Where(e => e.ApplicationUserId == user.Id)
                        .SumAsync(e => e.ExpenseAmount);

                    var balance = totalReceipts - totalExpenses;

                    ViewData["TotalReceipts"] = totalReceipts;
                    ViewData["TotalExpenses"] = totalExpenses;
                    ViewData["Balance"] = balance;
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
