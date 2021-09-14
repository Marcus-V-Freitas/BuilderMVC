using BuilderMVC.Models;

namespace BuilderMVC.Services.Interfaces
{
    public interface IPlanoBuilder
    {
        void BuildRecursoEspacoDisco();

        void BuildRecursoBancoDados();

        void BuildRecursoBandaLarga();

        void BuildRecursoSSL();

        Plano GetPlano();
    }
}