namespace _04_Pessoa
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }

        public string Idade { get; set;}


        public abstract void Envelhecer();
    }
}
