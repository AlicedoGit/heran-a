namespace _03_Carro
{
    public class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set;}

        public int Velocidade { get; set;}

        public Carro(string marca, string modelo, int velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
        }

        public void acelerar () 
        {
            Console.WriteLine($"do modelo {Modelo} atinge a velocidade de {Velocidade}km/h");
        }

        public void desacelerar () 
        {
            Console.WriteLine($"O modelo {Modelo} está ultrapassando o limite da via");
        }
    }
}
