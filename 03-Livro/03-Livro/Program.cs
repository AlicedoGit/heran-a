using _03_Livro;

Livro livro = new Livro ("Ratobúrguer", "David Walliams", "Intrínseca", "2012");

Console.WriteLine($"O primeiro livro chama-se {livro.Titulo}, seu autor é o {livro.Autor} da editora " +
    $"{livro.Editora}, e ele foi lançado em {livro.AdLanc}.");

/**********************************************************************************************/

Livro livro1 = new Livro("Vovó Vigarista", "David Walliams", "Intrínseca", "2011");

Console.WriteLine($"\nO segundo livro chama-se {livro1.Titulo}, seu autor é o {livro.Autor} da editora " +
    $"{livro.Editora}, e ele foi lançado em {livro1.AdLanc}.");

/**********************************************************************************************/

Livro livro2 = new Livro("Senhor Fedor", "David Walliams", "Intrínseca", "2009");

Console.WriteLine($"\nO terceiro livro chama-se {livro2.Titulo}, seu autor é o {livro.Autor} da editora " +
    $"{livro.Editora}, e ele foi lançado em {livro2.AdLanc}.");

Console.ReadKey();