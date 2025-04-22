using AulaPOO_15_04_25;

Livro l1 = new();
l1.id = 1;
l1.Autor = "Sommerville";
l1.Titulo = "Engenharia de Software";
l1.AnoPublicacao = "2022";

Livro l2 = new();
l2.id = 2;
l2.Autor = "Kelve Alves Gomes";
l2.Titulo = "Os 1000 erros de digitação mais comuns";
l2.AnoPublicacao = "2025";

Livro l3 = new();
l3.id = 3;
l3.Autor = "Desconhecido";
l3.Titulo = "Dragon Ball Shippuden: Em busca do pokémon lendário One Piece";
l3.AnoPublicacao = "2033";

BibliotecaGenerica<Livro> bGenerica = new();
bGenerica.AdicionarItem(l1);
bGenerica.AdicionarItem(l2);
bGenerica.AdicionarItem(l3);

//Console.WriteLine(bGenerica.ObterItem(0).Titulo);

foreach (Livro livro in bGenerica.ObterTodosItens())
{
    Console.WriteLine(livro.Titulo);
}

//Biblioteca b = new();
//b.AdicionarLivro(l1);
//b.AdicionarLivro(l2);
//b.AdicionarLivro(l3);

//Console.WriteLine(b.ObterLivro(2).Titulo);

//foreach (Livro l in b.ObterTodosLivros())
//{
//    Console.WriteLine(l.Titulo);
//}