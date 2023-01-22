using Microsoft.AspNetCore.Mvc;
using MVCEliminarEnfermosAzure.Repositories;
using MVCEliminarEnfermosAzure.Models;


namespace MVCEliminarEnfermosAzure.Controllers
{    
    public class EnfermosController : Controller
    {
        RepositoryEnfermos repo;

        public EnfermosController(RepositoryEnfermos repo)
        {
            this.repo = repo;   
        }
        public IActionResult Index()
        {
            List<Enfermo> enfermos = this.repo.GetEnfermos();
            return View(enfermos);
        }

        [HttpPost]

        public IActionResult Index(int inscripcion)
        {
            this.repo.EliminarEnfermos(inscripcion);
            List<Enfermo> enfermos = this.repo.GetEnfermos();
            return View(enfermos);
        }

    }
}
