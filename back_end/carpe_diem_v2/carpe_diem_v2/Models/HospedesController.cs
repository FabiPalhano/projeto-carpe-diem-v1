using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace carpe_diem_v2.Models
{
    public class HospedesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HospedesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hospedes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Hospedes.ToListAsync());
        }

        // GET: Hospedes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Hospedes == null)
            {
                return NotFound();
            }

            var hospede = await _context.Hospedes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hospede == null)
            {
                return NotFound();
            }

            return View(hospede);
        }

        // GET: Hospedes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hospedes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeCompHospede,Cpf,DataNascimento,Endereco,Telefone,EmailHospede,Senha,ConfirmarSenha")] Hospede hospede)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hospede);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hospede);
        }

        // GET: Hospedes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Hospedes == null)
            {
                return NotFound();
            }

            var hospede = await _context.Hospedes.FindAsync(id);
            if (hospede == null)
            {
                return NotFound();
            }
            return View(hospede);
        }

        // POST: Hospedes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeCompHospede,Cpf,DataNascimento,Endereco,Telefone,EmailHospede,Senha,ConfirmarSenha")] Hospede hospede)
        {
            if (id != hospede.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hospede);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HospedeExists(hospede.Id))
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
            return View(hospede);
        }

        // GET: Hospedes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Hospedes == null)
            {
                return NotFound();
            }

            var hospede = await _context.Hospedes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hospede == null)
            {
                return NotFound();
            }

            return View(hospede);
        }

        // POST: Hospedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Hospedes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Hospedes'  is null.");
            }
            var hospede = await _context.Hospedes.FindAsync(id);
            if (hospede != null)
            {
                _context.Hospedes.Remove(hospede);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HospedeExists(int id)
        {
          return _context.Hospedes.Any(e => e.Id == id);
        }
    }
}
