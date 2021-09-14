using BuilderMVC.Models;
using BuilderMVC.Services.Interfaces;

namespace BuilderMVC.Services.Contratos
{
    public class PlanoBasicoBuilder : IPlanoBuilder
    {
        public Plano Plano = new();

        public PlanoBasicoBuilder()
        {
            Resetar();
        }

        public void Resetar()
        {
            Plano = new() { Nome = "Basico", Preco = 19 };
        }

        public void BuildRecursoBancoDados()
        {
            Plano.AdicionarRecurso(new() { Titulo = "Tamanho Base de Dados", Valor = "5 GB" });
        }

        public void BuildRecursoBandaLarga()
        {
            Plano.AdicionarRecurso(new() { Titulo = "Banda Larga", Valor = "10 GB" });
        }

        public void BuildRecursoEspacoDisco()
        {
            Plano.AdicionarRecurso(new() { Titulo = "Espaço em Disco", Valor = "1 GB" });
        }

        public void BuildRecursoSSL()
        {
            Plano.AdicionarRecurso(new() { Titulo = "SSL", Valor = "Não de graça" });
        }

        public Plano GetPlano()
        {
            var plano = Plano;
            Resetar();
            return plano;
        }
    }
}