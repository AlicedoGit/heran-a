using _03_Carro;

Carro carro1 = new Carro("Nissan", "Versa", 200);
Carro carro2 = new Carro("Nissan", "Kicks", 320);
Carro carro3 = new Carro("Nissan", "Leaf", 220);

Console.WriteLine($"O carro da marca {carro1.Marca}");
carro1.acelerar();
carro1.desacelerar();

Console.WriteLine($"\nO carro da marca {carro2.Marca}");
carro2.acelerar();
carro2.desacelerar();

Console.WriteLine($"\nO carro da marca {carro3.Marca}");
carro3.acelerar();
carro3.desacelerar();

Console.ReadKey();