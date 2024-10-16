using _03_Aluno;

Aluno aluno1 = new Aluno(1365, "Júlia", "07/05/2000","JuliaBlog@gmail.com" );
Aluno aluno2 = new Aluno(2516, "Antônio", "07/05/2010", "TonhãoFliz@gmail.com");
Aluno aluno3 = new Aluno(8691, "Rafaela", "07/05/2009", "Ela2.0@gmail.com");

Console.WriteLine($"O RM da aluna {aluno1.Nome} é {aluno1.RM}, ela naceu em {aluno1.Nascimento}" +
    $" e seu email é {aluno1.Email}");
/*************************************************************************************************/

Console.WriteLine($"\nO RM do aluno {aluno2.Nome} é {aluno2.RM}, ele naceu em {aluno2.Nascimento}" +
    $" e seu email é {aluno2.Email}");

/*************************************************************************************************/

Console.WriteLine($"\nO RM da aluna {aluno3.Nome} é {aluno3.RM}, ela naceu em {aluno3.Nascimento}" +
    $" e seu email é {aluno3.Email}");

Console.ReadKey();