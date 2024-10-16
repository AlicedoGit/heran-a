namespace _03_Livro
{
    public class Livro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public string AdLanc { get; set; }

        public Livro(string titulo, string autor, string editora, string adLanc) 
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            AdLanc = adLanc;
        }
    }
}
