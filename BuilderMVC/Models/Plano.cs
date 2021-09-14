using System.Collections.Generic;

namespace BuilderMVC.Models
{
    public class Plano
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }
        public List<Recurso> Recursos { get; set; } = new();

        public void AdicionarRecurso(Recurso recurso)
        {
            Recursos.Add(recurso);
        }
    }
}