/******************************************************************************

Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem
caso o valor seja inválido e continue pedindo até que o usuário informe um valor
válido.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int num1 = 0;
    Console.WriteLine("Informe uma nota de 0 a 10:");
    num1 = int.Parse(Console.ReadLine());
    while(num1<=0 || num1 >=10)
    {
        Console.WriteLine("Nota incorreta digite novamente!");
        num1 = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Fim");
    Console.ReadLine();
  }
}

