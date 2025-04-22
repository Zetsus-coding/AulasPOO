using System;

namespace AulaPOO_15_04_25
{
    public class Livro : ItensBiblioteca
	{
		public string? Autor { get; set; }
		public string AnoPublicacao { get; set; }
	}
}