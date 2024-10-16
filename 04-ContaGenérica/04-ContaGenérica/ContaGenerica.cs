namespace _04_ContaGenérica
{
    public abstract class ContaGenerica
    {
        public string Banco { get; set; }

        public string Agencia { get; set; }

        public string Conta { get; set; }

        public double Saldo { get; set; }

        public abstract void depositar();

        public abstract void sacar();
    }

    public class ContaCorrente : ContaGenerica
    {
        public double limit { get; set; }

        public override void depositar()
        {
            Console.WriteLine($"Você depositou o valor de R$100 e seu saldo é de {Saldo}");       
        }

        public override void sacar()
        {
            Console.WriteLine($"Você Sacou o valor de R$100 e seu saldo é de {Saldo}");
        }

    }
}
