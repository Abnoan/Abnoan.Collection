internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        #region Biblioteca
        Biblioteca biblioteca = new Biblioteca();

        biblioteca.AdicionarLivro(new Livro("C# para Iniciantes", "Jane Doe", "Educação"));
        biblioteca.AdicionarLivro(new Livro("Aventuras em C#", "John Doe", "Ficção"));

        Console.WriteLine("Buscando 'C# para Iniciantes':");
        var livro = biblioteca.BuscarLivro("C# para Iniciantes");
        if (livro != null)
            Console.WriteLine($"Encontrado: {livro.Titulo} por {livro.Autor}");

        Console.WriteLine("\nListando livros na categoria 'Educação':");
        var livrosEdu = biblioteca.ListarLivrosPorCategoria("Educação");
        foreach (var l in livrosEdu)
            Console.WriteLine($"{l.Titulo} por {l.Autor}");

            #endregion
    }
}