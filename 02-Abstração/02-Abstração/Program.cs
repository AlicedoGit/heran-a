/*Instanciar a classe e os nomes*/

using _02_Abstração;

Pet pet1 = new Pet("Pipoca", "SRD", 2);

pet1.Alimentar();
Console.WriteLine("\nO nome do seu cachorro é: " + pet1.Nome);
Console.WriteLine("\nA raça do seu cachorro é: " + pet1.Raca);
Console.WriteLine("\nA idade do seu cachorro é: " + pet1.Idade);

Console.ReadKey();