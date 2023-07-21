using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteCliente.Models;

namespace TesteCliente.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Contexto _contexto;

        public ClienteController(Contexto contexto)
        {
            _contexto = contexto;
            
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> PegarClientes()
        {
            return Json(await _contexto.Clientes.ToListAsync());
        }

        [HttpPost]
        public async Task<JsonResult> NovosClientes(Clientes clientes)
        {
            if(ModelState.IsValid)
            {
                await _contexto.Clientes.AddAsync(clientes);
                await _contexto.SaveChangesAsync();
                return Json(clientes);
            }
            return Json(ModelState);
        }
    }
}
