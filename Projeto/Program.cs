using Projeto.Classes;
using Projeto.obj.Classes;

PessoaFisica pessoaF01 = new PessoaFisica();

pessoaF01.nome = "Moira";
pessoaF01.cpf = "00011100010";
pessoaF01.rendimento = 5000;
pessoaF01.dataNascimento = new DateTime (1994/04/20);

PessoaJuridica pessoaJ01 = new PessoaJuridica();
pessoaJ01.nome = "Talon";
pessoaJ01.cnpj = "25413265447";
pessoaJ01.rendimento = 9300;

Endereco novoEndPF = new Endereco();
novoEndPF.logradouro = "Rua dos Cogumelos, Toca do Coelho, Narnia";
novoEndPF.numero = 420;
novoEndPF.complemento = "Laboratório";
novoEndPF.Comercio = true;

pessoaF01.endereco = novoEndPF;

//---------------------------------------------------
System.Console.WriteLine("-----------------------------------");
System.Console.WriteLine("O CPF de " +pessoaF01.nome+ " é " +pessoaF01.cpf);
System.Console.WriteLine("O Rendimento de " +pessoaF01.nome+ " é " +pessoaF01.CalcularImposto(pessoaF01.rendimento).ToString("C"));
System.Console.WriteLine("-----------------------------------");
System.Console.WriteLine("O CNPJ da " +pessoaJ01.nome+ " é " +pessoaJ01.cnpj);
System.Console.WriteLine("O Rendimento da " +pessoaJ01.nome+ " é " +pessoaJ01.CalcularImposto(pessoaJ01.rendimento).ToString("C"));
System.Console.WriteLine("-----------------------------------");
System.Console.WriteLine($"O {pessoaF01.endereco.complemento} de Moira está na: {pessoaF01.endereco.logradouro}, numero: {pessoaF01.endereco.numero}");
//---------------------------------------------------
