global using TypeCheckTest.Interfaces;
global using TypeCheckTest.Models;
using TypeCheckTest.Classes;

A a = new();

(bool isNull, object? lastObj) = a.IsChainNull();

Console.WriteLine($"{lastObj} is the last object in the chain that is not null");


Console.ReadKey();