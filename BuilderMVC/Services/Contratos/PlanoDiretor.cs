using BuilderMVC.Services.Interfaces;

namespace BuilderMVC.Services.Contratos
{
    public class PlanoDiretor : IPlanoDiretor
    {
        private IPlanoBuilder _builder;

        public PlanoDiretor(IPlanoBuilder builder)
        {
            _builder = builder;
        }

        public void BuildPlanoBasico()
        {
            _builder.BuildRecursoEspacoDisco();
            _builder.BuildRecursoBancoDados();
            _builder.BuildRecursoBandaLarga();
        }

        public void BuildPlanoEnterprise()
        {
            _builder.BuildRecursoEspacoDisco();
            _builder.BuildRecursoBancoDados();
            _builder.BuildRecursoBandaLarga();
            _builder.BuildRecursoSSL();
        }

        public void SetPlanoBuilder(IPlanoBuilder builder)
        {
            _builder = builder;
        }
    }
}