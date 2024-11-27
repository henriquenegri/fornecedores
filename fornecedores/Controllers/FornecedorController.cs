using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fornecedores.Data;
using fornecedores.Models.MaisFornec;

namespace ToDo.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly AppCont _appCont;

        public FornecedorController(AppCont appCont)
        {

            _appCont = appCont;
        }

        public IActionResult Index()
        {
            var allTasks = _appCont.Fornecedores.ToList();
            return View(allTasks);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var fornec = await _appCont.Fornecedores.FirstOrDefaultAsync(x => x.Id == id);

            if (fornec == null)
            {
                return BadRequest();
            }
            return View(fornec);
        }

        //GET: Tarefas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _appCont.Add(fornecedor);
                await _appCont.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var fornec= await _appCont.Fornecedores.FirstOrDefaultAsync(x => x.Id == id);
            if (fornec == null)
            {
                return BadRequest();
            }
            return View(fornec);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Fornecedor fornecedor)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _appCont.Update(fornecedor);
                await _appCont.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var fornec= await _appCont.Fornecedores.FirstOrDefaultAsync(x => x.Id == id);

            if (fornec == null)
            {
                return NotFound();
            }
            return View(fornec);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tarefa = await _appCont.Fornecedores.FirstOrDefaultAsync(x => x.Id == id);
            if (tarefa != null)
            {
                _appCont.Fornecedores.Remove(tarefa);
                await _appCont.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }
    }

}
