using _04_Animal;

Capivara capivara = new Capivara
{
    Especie = "Roedor"
};

Gato gato = new Gato
{
    Especie = "Felino"
};

Porco porco = new Porco
{
    Especie = "Porco Doméstico"
};

Console.WriteLine($"A capivara vem da espécie: {capivara.Especie}");
capivara.emitirSom();

Console.WriteLine($"O Gato é da espécie: {gato.Especie}");
gato.emitirSom();

Console.WriteLine($"O Porco é da espécie: {porco.Especie}");
porco.emitirSom();

Console.ReadKey();
