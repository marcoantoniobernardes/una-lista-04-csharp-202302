/******************************************************************************

Faça um programa que leia e valide as seguintes informações:
 Nome: maior que 3 caracteres;
 Idade: entre 0 e 150;
 Salário: maior que zero;
 Sexo: 'f' ou 'm';
 Estado Civil: 's', 'c', 'v', 'd';

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    string nome, sexo, estadoC;
    double salario = 0, idade = 0;
    Console.WriteLine("Cadastro \nNome: ");
    nome = Console.ReadLine();
    while(nome.Length<3)
    {
        Console.WriteLine("Nome com menos de 3 letras digite novamente.");
        nome = Console.ReadLine();
    }
    Console.WriteLine("Idade: ");
    idade = double.Parse(Console.ReadLine());
    while(idade<0||idade>=150)
    {
        Console.WriteLine("idade incorreta digite novamente(entre 0 e 150)).");
        idade = double.Parse(Console.ReadLine());
    }
    Console.WriteLine("Sexo(f, m): ");
    sexo = Console.ReadLine();
    while(!sexo.Equals("f") && !sexo.Equals("m"))
    {
        Console.WriteLine("Digite f para feminino ou m para masculino.");
        sexo = Console.ReadLine();
    }
    Console.WriteLine("Estado civil(s, c, v, d): ");
    estadoC = Console.ReadLine();
    while(!estadoC.Equals("s") && !estadoC.Equals("c") && !estadoC.Equals("v") && !estadoC.Equals("d"))
    {
        Console.WriteLine("Incorreto, digite s, c, v ou d.");
        estadoC = Console.ReadLine();
    }
    Console.WriteLine("Salário:");
    salario = double.Parse(Console.ReadLine());
    while(salario < 0)
    {
        Console.WriteLine("Incorreto, digite salario maior que 0");
        salario = double.Parse(Console.ReadLine());
    }
    Console.WriteLine("Salvando...");
    Console.ReadLine();
  }
}

