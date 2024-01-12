using CrudA.Data;
using CrudA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CrudA.Controllers
{
    public class CadastrarController : Controller
    {

        readonly private ApplicationDbContext _db;

        public CadastrarController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<CadastroModel> Cadastro = _db.Cadastro;
            return View(Cadastro);
        }

        [HttpGet]
        public IActionResult CadastrarInserir()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }

            CadastroModel edit = _db.Cadastro.FirstOrDefault(x => x.ID == ID);

            if (edit == null)
            {
                return NotFound();
            }


            return View(edit);
        }
        [HttpGet]
        public IActionResult Excluir (int? ID)
        { if (ID == null || ID == 0) 
            {
                return NotFound();
            } 
            CadastroModel cadastro = _db.Cadastro.FirstOrDefault (x => x.ID == ID);

            if (cadastro == null) 
            {
                return NotFound();
            }
            return View(cadastro);
        }

        [HttpPost]
        public IActionResult CadastrarInserir(CadastroModel cadastro)
        {
            if(!ModelState.IsValid)
            {
                _db.Cadastro.Add(cadastro);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }

       // [HttpPost]
       // public IActionResult Editar(CadastroModel Cadastro)
       // {
        //    if (!ModelState.IsValid)
        //    {
        //        _db.Cadastro.Update(Cadastro);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
//
        //    return View();
        //}

        [HttpPost]
        public IActionResult Editar(CadastroModel cadastro)
        {
            if (ModelState.IsValid)
            {
                _db.Cadastro.Update(cadastro);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                return RedirectToAction("Index");
            }

            TempData["MensagemErro"] = "Ocorreu algum erro no momento da edição!";
            return View(cadastro);
        }


        [HttpPost]  
        public IActionResult Excluir(CadastroModel Cadastro) 
        { 
        if(Cadastro == null)
            {
                return NotFound();
            }

        _db.Cadastro.Remove(Cadastro);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Remoção realizado com sucesso!";


            return RedirectToAction("Index");
        }
    }
}
