namespace _01_Herança
{
    /*A CLASSE "ANIMAL" É UMA CLASSE ABSTRATA QUE SERVIRÁ DE MODELO PARA OS OUTROS ANIMAIS*/
    public abstract class Animal
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string TiposAlimentacao { get; set; }

        /*MÉTODO ABSTRATO - NÃO POSSUI IMPLEMENTAÇÃO AQUI, mas as classes que herdarem vão precisar implementar*/

        public abstract void EmitirSom();
    }

    //A classe "Cachorro herda da classe "Animal"
    //Isso significa que o Cachorro terá todos os atributos e comportamentos definidos em animal. Mas tbm
    //pode ter suas próprias características.
    public class Cachorro : Animal
    {
        public string Raca { get; set; }

        //bool significa booleana, ou seja, espera uma resposta verdadeira ou falsa para o atributo
        public bool BuscaObjeto { get; set; }

        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }
    }
}
