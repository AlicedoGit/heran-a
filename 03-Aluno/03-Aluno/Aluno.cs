namespace _03_Aluno
{
    public class Aluno
    {
        public int RM {get; set;}

        public string Nome { get; set;}

        public string Nascimento {get; set;}

        public string Email {get; set;}

        public Aluno (int rm, string nome, string nascimento, string email)
        {
            RM = rm;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }
    }
}
