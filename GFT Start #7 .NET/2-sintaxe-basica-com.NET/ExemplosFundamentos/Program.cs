using ExemplosFundamentos.Models;

//CLASSES
//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Iran";
//pessoa1.Idade = 32;
//pessoa1.Apresentar();

//VARIÁVEIS
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

//DATETIME
//DateTime dataAtual = DateTime.Now;
//Console.WriteLine(dataAtual);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
//adicionando mais dias
//DateTime dataAtualDias = DateTime.Now.AddDays(5);
//Console.WriteLine(dataAtualDias.ToString("dd/MM/yyyy"));



//OPERADORES

// int a = 10;
// int b = 20;
// int c = a + b;
// //c = c + 5; 
// c += 5;
// c -= 5;
// Console.WriteLine(c);

//CONVERTENDO VARIÁVEIS Cast - Casting

//inteiros
//int a = Convert.ToInt32("5");
//int a = int.Parse("5");
//Console.WriteLine(a);

//String
//int inteiro = 5;
//string a = inteiro.ToString();
//Console.WriteLine(a);

//Implicito
// int a = 5;
// double b = a;
// Console.WriteLine(b);


//CONVERTENDO DA FORMA SEGURA
string a = "15-";
int b = 0;
int.TryParse(a, out b);
Console.WriteLine(b);

