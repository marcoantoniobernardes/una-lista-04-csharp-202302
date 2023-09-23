/******************************************************************************

Faça um programa que peça 10 números inteiros, calcule e mostre a quantidade
de números pares e a quantidade de números impares.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[] numeros = new int[10];
    int somaP = 0, somaI = 0;
    Console.WriteLine("Digite 10 numeros:");
    for(int i = 0; i<numeros.Length-1; i++)
    {
        numeros[i] = int.Parse(Console.ReadLine());
        if(numeros[i]%2 ==0)
            somaP++;
        else
            somaI++;
    }
    Console.WriteLine($"Numeros impar: {somaI}\nNumeros pares: {somaP}");
    Console.ReadLine();
  }
}
