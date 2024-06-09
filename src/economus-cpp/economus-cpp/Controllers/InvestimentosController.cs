using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using economus_cpp.Models;

namespace economus_cpp.Controllers
{
    public class InvestimentosController : Controller
    {
        private readonly AppDbContext _context;

        public InvestimentosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Investimentos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Investimento.Include(i => i.usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Investimentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investimento = await _context.Investimento
                .Include(i => i.usuario)
                .FirstOrDefaultAsync(m => m.id == id);
            if (investimento == null)
            {
                return NotFound();
            }

            return View(investimento);
        }

        // GET: Investimentos/Create
        public IActionResult Create()
        {
            ViewData["usuarioId"] = new SelectList(_context.Usuarios, "id", "email");
            return View();
        }

        // POST: Investimentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descricao,tipo,valorInvestido,taxaRendimento,taxaImposto,dataFinal,usuarioId")] Investimento investimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(investimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["usuarioId"] = new SelectList(_context.Usuarios, "id", "email", investimento.usuarioId);
            return View(investimento);
        }

        // GET: Investimentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investimento = await _context.Investimento.FindAsync(id);
            if (investimento == null)
            {
                return NotFound();
            }
            ViewData["usuarioId"] = new SelectList(_context.Usuarios, "id", "email", investimento.usuarioId);
            return View(investimento);
        }

        // POST: Investimentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descricao,tipo,valorInvestido,taxaRendimento,taxaImposto,dataFinal,usuarioId")] Investimento investimento)
        {
            if (id != investimento.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(investimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvestimentoExists(investimento.id))
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
            ViewData["usuarioId"] = new SelectList(_context.Usuarios, "id", "email", investimento.usuarioId);
            return View(investimento);
        }

        // GET: Investimentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investimento = await _context.Investimento
                .Include(i => i.usuario)
                .FirstOrDefaultAsync(m => m.id == id);
            if (investimento == null)
            {
                return NotFound();
            }

            return View(investimento);
        }

        // POST: Investimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var investimento = await _context.Investimento.FindAsync(id);
            if (investimento != null)
            {
                _context.Investimento.Remove(investimento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvestimentoExists(int id)
        {
            return _context.Investimento.Any(e => e.id == id);
        }
    }
}
