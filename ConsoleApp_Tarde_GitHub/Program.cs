﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde_GitHub;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;


Produto p1 = new Produto(1, "Mouse xing ling", 10.90M);
Produto p2 = new Produto(2, "Teclado Multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());



