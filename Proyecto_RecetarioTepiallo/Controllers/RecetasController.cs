using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Proyecto_RecetarioTepiallo.Data;
using System.Threading.Tasks;

namespace Proyecto_RecetarioTepiallo.Controllers
{
    public class RecetasController : Controller
    {
        public readonly RecetasContext _Rcontext;
        public readonly IWebHostEnvironment _Renvironment;

        public RecetasController(RecetasContext context, IWebHostEnvironment environment)
        {
            _Rcontext = context;
            _Renvironment = environment;
        }

        public async Task<IActionResult> Index ()
        {
            return View();
        }
        public IActionResult CrearReceta ()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearReceta ()
        {
            return View();
        }
        private string ArchivoUnico ()
        {

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Eliminar ()
        {
            return View();
        }


    }
}
