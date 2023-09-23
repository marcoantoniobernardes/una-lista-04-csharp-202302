/******************************************************************************

Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Numeros impares entre 1 e 50");
    for(int i = 0; i < 50; i++)
    {
        if(i%2 == 1)
            Console.WriteLine(i);
    }
    Console.ReadLine();
  }
}
