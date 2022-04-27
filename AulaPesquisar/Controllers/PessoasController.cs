using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AulaPesquisar.Controllers
{
    public class PessoasController : Controller
    {
        private readonly Contexto db;

        public PessoasController(Contexto _db)
        {
            db = _db;   
        }

        public IActionResult Index(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return View(db.PESSOAS.ToList());
            }
            else
            {
                return View(db.PESSOAS.Where(a =>
                    a.nome.Contains(texto) ||
                    a.cpf.Contains(texto) ||
                    a.rg.Contains(texto) ||
                    a.idade.Contains(texto)
                    ) );
            }
            

        }
    }
}
