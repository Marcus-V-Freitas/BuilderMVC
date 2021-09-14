using BuilderMVC.Models.ViewModels;
using BuilderMVC.Services.Contratos;
using BuilderMVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BuilderMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlanoDiretor _planoDiretor;

        public HomeController(IPlanoDiretor planoDiretor)
        {
            _planoDiretor = planoDiretor;
        }

        public IActionResult Index()
        {
            PlanosPrecoViewModel model = new();

            //Contruir plano Básico
            IPlanoBuilder builder = new PlanoBasicoBuilder();
            _planoDiretor.SetPlanoBuilder(builder);
            _planoDiretor.BuildPlanoBasico();
            model.PlanoBasico = builder.GetPlano();

            //Contruir plano Enterprise
            builder = new PlanoEnterpriseBuilder();
            _planoDiretor.SetPlanoBuilder(builder);
            _planoDiretor.BuildPlanoEnterprise();
            model.PlanoEnterprise = builder.GetPlano();

            //Contruir plano básico
            builder = new PlanoBasicoBuilder();
            builder.BuildRecursoEspacoDisco();
            builder.BuildRecursoBandaLarga();
            model.PlanoCustomizado = builder.GetPlano();
            return View(model);
        }
    }
}