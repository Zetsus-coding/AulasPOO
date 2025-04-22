using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_15_04_25
{
    public class BibliotecaGenerica<T> where T : ItensBiblioteca// Classe genérica <T>
    {
        private List<T> itens = new List<T>(); // Lista genérica <T>

        public void AdicionarItem(T item)
        {
            itens.Add(item);
        }

        public T ObterItem (int indice)
        {
            return itens[indice]; // Sem casting;
        }

        public List<T> ObterTodosItens()
        {
            return itens;
        }
    }
}
