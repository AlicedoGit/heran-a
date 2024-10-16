using _01_Herança;

Cachorro cachorro1 = new Cachorro
{
    Nome = "Noah",
    Idade = 3,
    TiposAlimentacao = "Carnívoro",
    Raca = "Lulu da Pomerânia",
    BuscaObjeto = true
};

Console.WriteLine($"Nome: {cachorro1.Nome}, Idade: {cachorro1.Idade}, Ele é {cachorro1.TiposAlimentacao}, da raça {cachorro1.Raca} e ele {cachorro1.BuscaObjeto} pega bolinha");
Console.ReadKey();