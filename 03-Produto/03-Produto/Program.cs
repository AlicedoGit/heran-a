using _03_Produto;

Produto produto1 = new Produto(3653, "Nike", 119.99, 150);
Produto produto2 = new Produto(3653, "Puma", 329.79, 60);
Produto produto3 = new Produto(3653, "Vans", 89.90, 90);
Produto produto4 = new Produto(3653, "AllStar", 239.80, 220);

Console.WriteLine($"Produto 1 tem o código {produto1.Codigo} com o valor de {produto1.Preco} e");
produto1.valorEstoque();

Console.WriteLine($"\nProduto 2 tem o código {produto2.Codigo} com o valor de {produto2.Preco} e");
produto2.valorEstoque();

Console.WriteLine($"\nProduto 3 tem o código {produto3.Codigo} com o valor de {produto3.Preco} e");
produto3.valorEstoque();

Console.WriteLine($"\nProduto 4 tem o código {produto4.Codigo} com o valor de {produto4.Preco} e");
produto4.valorEstoque();

Console.ReadKey();