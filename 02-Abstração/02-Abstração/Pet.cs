namespace _02_Abstração
{
    public class Pet
    {
        public string Nome { get; set; }

        public string Raca { get; set;}

        public int Idade { get; set;}

        /*É NECESSÁRIO UM MÉTODO CONTRUTOR PARA ACESSAR AS PROPRIEDADES E MANIPULA-LAS*/
        public Pet (string nome, string raca, int idade)
        {
            Nome = nome;
            Raca = raca;
            Idade = idade;
        }

        /*MÉTODO PARA ALIMENTAR*/
        public void Alimentar()
        {
            Console.WriteLine($"O Pet {Nome} está alimentado");
        }
    }    
}
