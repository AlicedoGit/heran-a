using Ex5_Funcionarios;

//instanciando a classe funcionário
Funcionario funcionario1 = new Funcionario { Nome = "Giovanne", Idade = 30 };
Funcionario funcionario2 = new Funcionario { Nome = "Esther", Idade = 45 };
Funcionario funcionario3 = new Funcionario { Nome = "Bianca", Idade = 26 };
Funcionario funcionario4 = new Funcionario { Nome = "Victor", Idade = 57 };

//Chamando o método Envelhecer

funcionario1.Envelhecer(10);//Somar a idade que você passou para a variável funcionario1 mais 10

//Chamando o método Rejuvenecer

funcionario2.Rejuvenecer(20);
funcionario3.Rejuvenecer(20);
funcionario4.Rejuvenecer(20);

//Exibindo as informações dos funcionarios

Console.WriteLine($"Nome: {funcionario1.Nome}, Idade: {funcionario1.Idade}");

Console.WriteLine($"Nome: {funcionario2.Nome}, Idade: {funcionario2.Idade}");
Console.WriteLine($"Nome: {funcionario3.Nome}, Idade: {funcionario3.Idade}");
Console.WriteLine($"Nome: {funcionario4.Nome}, Idade: {funcionario4.Idade}");

Console.WriteLine("Pressione qualquer tecla para encerrar");
Console.ReadKey();
