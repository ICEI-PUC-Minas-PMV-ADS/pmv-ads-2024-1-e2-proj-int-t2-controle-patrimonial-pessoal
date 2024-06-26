using economus_cpp.Models;
using economus_cpp.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace economus_cpp.Controllers
{
    [Authorize]
    public class ExpenseController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _context;
        private readonly ILogger<ExpenseController> _logger;

        public ExpenseController(UserManager<ApplicationUser> userManager, AppDbContext context, ILogger<ExpenseController> logger)
        {
            _userManager = userManager;
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            ViewData["UserName"] = user.Name;

            var expenses = await _context.Expenses.Where(r => r.ApplicationUserId == user.Id).ToListAsync();
            return View(expenses);
        }

        public IActionResult Create()
        {
            ViewBag.ExpenseTypes = new SelectList(Enum.GetValues(typeof(ExpenseType)).Cast<ExpenseType>());
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ExpenseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    _logger.LogError("User not found");
                    return RedirectToAction(nameof(Index));
                }

                var expense = new Expense
                {
                    ApplicationUserId = user.Id,
                    Description = model.Description,
                    Type = model.Type,
                    ExpenseAmount = model.ExpenseAmount,
                    ExpenseDate = model.ExpenseDate
                };
                _context.Add(expense);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Expense added successfully.");
                return RedirectToAction(nameof(Index));
            }

            foreach (var state in ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    _logger.LogError("ModelState error in {Field}: {Error}", state.Key, error.ErrorMessage);
                }
            }

            ViewBag.ExpenseTypes = new SelectList(Enum.GetValues(typeof(ExpenseType)).Cast<ExpenseType>());
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }

            ViewBag.ExpenseTypes = new SelectList(Enum.GetValues(typeof(ExpenseType)).Cast<ExpenseType>());

            var viewModel = new ExpenseViewModel
            {
                Id = expense.Id,
                Description = expense.Description,
                Type = expense.Type,
                ExpenseAmount = expense.ExpenseAmount,
                ExpenseDate = expense.ExpenseDate
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ExpenseViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var expense = await _context.Expenses.FindAsync(id);
                    if (expense == null)
                    {
                        return NotFound();
                    }

                    expense.Description = model.Description;
                    expense.Type = model.Type;
                    expense.ExpenseAmount = model.ExpenseAmount;
                    expense.ExpenseDate = model.ExpenseDate;

                    _context.Update(expense);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpenseExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpenseExists(int id)
        {
            return _context.Expenses.Any(e => e.Id == id);
        }
    }
}
