using _04_ContaGenérica;

ContaCorrente conta1 = new ContaCorrente
{
    Banco = "Nulo",
    Agencia = "Nubank",
    Conta = "125425",
    Saldo = 1000.68
};

ContaCorrente conta2 = new ContaCorrente
{
    Banco = "Banco do Brasil",
    Agencia = "BB",
    Conta = "785696",
    Saldo = 3694.75
};

ContaCorrente conta3 = new ContaCorrente
{
    Banco = "Itaú Unibanco",
    Agencia = "Itaú",
    Conta = "895304",
    Saldo = 2368.89
};

Console.WriteLine($"Seu banco é: { conta1.Agencia}, sua conta é: {conta1.Conta} e você está com o saldo de R${conta1.Saldo}");
conta1.depositar();
conta1.sacar();
Console.WriteLine($"Seu banco é: {conta2.Agencia}, sua conta é: {conta2.Conta} e você está com o saldo de R${conta2.Saldo}");
conta2.depositar();
conta2.sacar();
Console.WriteLine($"Seu banco é: {conta3.Agencia}, sua conta é: {conta3.Conta} e você está com o saldo de R${conta3.Saldo}");
conta3.depositar();
conta3.sacar();

Console.ReadKey();


