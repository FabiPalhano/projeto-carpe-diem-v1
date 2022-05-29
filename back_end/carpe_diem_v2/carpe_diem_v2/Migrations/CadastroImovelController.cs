using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using carpe_diem_v2.Models;

namespace carpe_diem_v2.Migrations
{
    public class CadastroImovelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CadastroImovelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CadastroImovel
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CadastroImovel.Include(c => c.Hospede);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CadastroImovel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CadastroImovel == null)
            {
                return NotFound();
            }

            var cadastroImovel = await _context.CadastroImovel
                .Include(c => c.Hospede)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroImovel == null)
            {
                return NotFound();
            }

            return View(cadastroImovel);
        }

        // GET: CadastroImovel/Create
        public IActionResult Create()
        {
            ViewData["HospedeId"] = new SelectList(_context.Hospedes, "Id", "ConfirmarSenha");
            return View();
        }

        // POST: CadastroImovel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fotos,Endereco,TipoEspaco,TipoAcomodacao,QuantHospedes,QuantCamas,QuantBanheiros,OpOferecer,HoraCheckin,HoraCheckout,DistPraia,ValorDiaria,InfAdicionais,DisponibilizarImovel,DesativarImovel,HospedeId")] CadastroImovel cadastroImovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroImovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HospedeId"] = new SelectList(_context.Hospedes, "Id", "ConfirmarSenha", cadastroImovel.HospedeId);
            return View(cadastroImovel);
        }

        // GET: CadastroImovel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CadastroImovel == null)
            {
                return NotFound();
            }

            var cadastroImovel = await _context.CadastroImovel.FindAsync(id);
            if (cadastroImovel == null)
            {
                return NotFound();
            }
            ViewData["HospedeId"] = new SelectList(_context.Hospedes, "Id", "ConfirmarSenha", cadastroImovel.HospedeId);
            return View(cadastroImovel);
        }

        // POST: CadastroImovel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fotos,Endereco,TipoEspaco,TipoAcomodacao,QuantHospedes,QuantCamas,QuantBanheiros,OpOferecer,HoraCheckin,HoraCheckout,DistPraia,ValorDiaria,InfAdicionais,DisponibilizarImovel,DesativarImovel,HospedeId")] CadastroImovel cadastroImovel)
        {
            if (id != cadastroImovel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroImovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroImovelExists(cadastroImovel.Id))
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
            ViewData["HospedeId"] = new SelectList(_context.Hospedes, "Id", "ConfirmarSenha", cadastroImovel.HospedeId);
            return View(cadastroImovel);
        }

        // GET: CadastroImovel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CadastroImovel == null)
            {
                return NotFound();
            }

            var cadastroImovel = await _context.CadastroImovel
                .Include(c => c.Hospede)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroImovel == null)
            {
                return NotFound();
            }

            return View(cadastroImovel);
        }

        // POST: CadastroImovel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CadastroImovel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CadastroImovel'  is null.");
            }
            var cadastroImovel = await _context.CadastroImovel.FindAsync(id);
            if (cadastroImovel != null)
            {
                _context.CadastroImovel.Remove(cadastroImovel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroImovelExists(int id)
        {
          return _context.CadastroImovel.Any(e => e.Id == id);
        }
    }
}
