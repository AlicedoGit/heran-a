namespace _04_Animal
{
    public abstract class Animal
    {
        public string Especie { get; set; }

        public abstract void emitirSom();
    }

    public class Capivara : Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine("Rmmmmmmm");
        }
    }

    public class Gato : Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine("Miww Miw");
        }
    }

    public class Porco : Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine("Onc Onc");
        }
    }
}
