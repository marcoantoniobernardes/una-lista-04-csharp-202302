/******************************************************************************

Faça um programa que leia um nome de usuário e a sua senha e não aceite a
senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a
pedir as informações.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Para logar digite usuario e senha");
    string senha, usuario;
    usuario = Console.ReadLine();
    senha = Console.ReadLine();
    
    while(senha.Equals(usuario))
    {
        Console.WriteLine("Usuário e senha não podem ser iguais, digite novamente");
        usuario = Console.ReadLine();
        senha = Console.ReadLine();
    }
    Console.WriteLine("Carregando...");
    Console.ReadLine();
  }
}

