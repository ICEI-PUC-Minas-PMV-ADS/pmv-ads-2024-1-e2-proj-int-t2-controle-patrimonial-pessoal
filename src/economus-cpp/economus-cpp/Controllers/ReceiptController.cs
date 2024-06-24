using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using economus_cpp.Models;
using economus_cpp.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace economus_cpp.Controllers
{
    [Authorize]
    public class ReceiptController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _context;
        private readonly ILogger<ReceiptController> _logger;

        public ReceiptController(UserManager<ApplicationUser> userManager, AppDbContext context, ILogger<ReceiptController> logger)
        {
            _userManager = userManager;
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            ViewData["UserName"] = user.Name;

            var receipts = await _context.Receipts.Where(r => r.ApplicationUserId == user.Id).ToListAsync();
            return View(receipts);
        }

        public IActionResult Create()
        {
            ViewBag.ReceiptTypes = new SelectList(Enum.GetValues(typeof(ReceiptType)).Cast<ReceiptType>());
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReceiptViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    _logger.LogError("User not found");
                    return RedirectToAction(nameof(Index));
                }

                var receipt = new Receipt
                {
                    ApplicationUserId = user.Id,
                    Description = model.Description,
                    Type = model.Type,
                    ReceiptAmount = model.ReceiptAmount,
                    ReceiptDate = model.ReceiptDate
                };
                _context.Add(receipt);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Receipt added successfully.");
                return RedirectToAction(nameof(Index));
            }

            foreach (var state in ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    _logger.LogError("ModelState error in {Field}: {Error}", state.Key, error.ErrorMessage);
                }
            }

            ViewBag.ReceiptTypes = new SelectList(Enum.GetValues(typeof(ReceiptType)).Cast<ReceiptType>());
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var receipt = await _context.Receipts.FindAsync(id);
            if (receipt == null)
            {
                return NotFound();
            }

            ViewBag.ReceiptTypes = new SelectList(Enum.GetValues(typeof(ReceiptType)).Cast<ReceiptType>());

            var viewModel = new ReceiptViewModel
            {
                Id = receipt.Id,
                Description = receipt.Description,
                Type = receipt.Type,
                ReceiptAmount = receipt.ReceiptAmount,
                ReceiptDate = receipt.ReceiptDate
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ReceiptViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var receipt = await _context.Receipts.FindAsync(id);
                    if (receipt == null)
                    {
                        return NotFound();
                    }

                    receipt.Description = model.Description;
                    receipt.Type = model.Type;
                    receipt.ReceiptAmount = model.ReceiptAmount;
                    receipt.ReceiptDate = model.ReceiptDate;

                    _context.Update(receipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceiptExists(model.Id))
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

            var receipt = await _context.Receipts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receipt == null)
            {
                return NotFound();
            }

            return View(receipt);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receipt = await _context.Receipts.FindAsync(id);
            _context.Receipts.Remove(receipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceiptExists(int id)
        {
            return _context.Receipts.Any(e => e.Id == id);
        }
    }
}