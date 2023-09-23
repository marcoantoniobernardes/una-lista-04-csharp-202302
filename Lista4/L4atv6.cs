/******************************************************************************

Faça um programa que receba dois números inteiros e gere os números inteiros
que estão no intervalo compreendido por eles

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int num1 = 0, num2 = 0;
    Console.WriteLine("Escreva dois numeros para gerar ver o intevalo entre eles: ");
    num1 = int.Parse(Console.ReadLine());
    num2 = int.Parse(Console.ReadLine());
    if( num1 >= num2)
    {
        for(int i = num2; i<=num1; i++ )
        {
            Console.WriteLine(i);
        }
    }
    else
        for(int i = num1; i <= num2; i++ )
        {
            Console.WriteLine(i);
        }
    Console.ReadLine();
  }
}
