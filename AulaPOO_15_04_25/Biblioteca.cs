using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_15_04_25
{
    public class Biblioteca
    {
        private ArrayList livros = new ArrayList();
        
        // Métodos
        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public Livro ObterLivro(int indice)
        {
            return (Livro)livros[indice];
        }

        public ArrayList ObterTodosLivros()
        {
            return livros;
        }

    }
}
