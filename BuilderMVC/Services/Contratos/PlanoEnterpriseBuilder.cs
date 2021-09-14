using BuilderMVC.Models;
using BuilderMVC.Services.Interfaces;

namespace BuilderMVC.Services.Contratos
{
    public class PlanoEnterpriseBuilder : IPlanoBuilder
    {
        public Plano Plano = new();

        public PlanoEnterpriseBuilder()
        {
            Resetar();
        }

        public void Resetar()
        {
            Plano = new() { Nome = "Enterprise", Preco = 49 };
        }

        public void BuildRecursoBancoDados()
        {
            Plano.AdicionarRecurso(new() { Titulo = "Tamanho Base de Dados", Valor = "300 GB" });
        }

        public void BuildRecursoBandaLarga()
        {
            Plano.AdicionarRecurso(new() { Titulo = "Banda Larga", Valor = "Ilimitada" });
        }

        public void BuildRecursoEspacoDisco()
        {
            Plano.AdicionarRecurso(new() { Titulo = "Espaço em Disco", Valor = "100 GB" });
        }

        public void BuildRecursoSSL()
        {
            Plano.AdicionarRecurso(new() { Titulo = "SSL", Valor = "Gratuita" });
        }

        public Plano GetPlano()
        {
            var plano = Plano;
            Resetar();
            return plano;
        }
    }
}