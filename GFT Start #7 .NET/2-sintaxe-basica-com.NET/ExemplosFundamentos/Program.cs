using System.Reflection.Metadata;
using ExemplosFundamentos.Models;

// Calculadora calc = new Calculadora();

// calc.Somar(5, 6);
// calc.Subtrair(5, 6);
// calc.Multiplicar(5, 6);
// calc.Dividir(5, 6);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrementando o 10 ");
//numero = numero+ 1;
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20 ");
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);




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
// string a = "15-";
// int b = 0;
// int.TryParse(a, out b);
// Console.WriteLine(b);

//OPERADORES CONDICIONAIS

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Selecione a quantidade desejada.");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

// SWITCH CASE

// Console.WriteLine("Digite uma  letra");
// string letra = Console.ReadLine() ?? "";

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal.");
//         break;

// }

//OPERADORES LOGICOS (OR = ||) 

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada.");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

//(AND = &&) 

// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }

//( NOT = !)
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }

//LAÇOS DE REPETIÇÃO FOR

// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
// Console.WriteLine($"{numero} x {contador} = { numero * contador}");

// }

//LAÇOS DE REPETIÇÃO WHILE

// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1} Execução: {numero} x {contador} = {numero * contador}");
//     contador++;
//     if (contador == 6)
//     {
//     break;
//     }
// }