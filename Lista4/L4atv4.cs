/******************************************************************************

Faça um programa que leia 5 números e informe a soma e a média dos números

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    double[] num = new double[5];
    double soma = 0;
    Console.WriteLine("Digite 5 números para saber a soma e a média deles!");
    for(int i = 0; i<=num.Length-1; i++)
    {
        num[i] = double.Parse(Console.ReadLine());
        soma = soma+num[i];
    }
    Console.WriteLine($"A Soma dos numeros é {soma} e a média é {soma/5}");
    Console.ReadLine();
  }
}

