1) Basicamente oque precisa se feito é criar uma classe base (itensbiblioteca) e três classes que herdam dessa base (cd,livro,midiasdigitais)
2) Logo em seguida, a biblioteca genérica receberá um constraint/restrição na sua declaração "public class BibliotecaGenerica<T> where T : ItensBiblioteca"
	2.1) Isso faz com que uma instância possa receber "mais de um tipo de objeto", contanto que esse objeto herde da classe itensbiblioteca
	2.2) Normalmente a classe genérica só pode receber um tipo de "objeto" mas do jeito acima será possível