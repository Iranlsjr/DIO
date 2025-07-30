using ExemplosFundamentos.Models;

//classes -------
//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Iran";
//pessoa1.Idade = 32;
//pessoa1.Apresentar();

//Variáveis ---------
//string apresentacao = "Olá, seja bem vindo";
//int quantidade = 1;
//quantidade = 10;
//double altura = 1.80;
//decimal preco = 1.80M;
//bool condicao = true;

//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
//Console.WriteLine("Valor da variável preço: " + preco);
//Console.WriteLine("Valor da variável condição: " + condicao);

//Date Time
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
//adicionando mais dias
DateTime dataAtualDias = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtualDias.ToString("dd/MM/yyyy"));
