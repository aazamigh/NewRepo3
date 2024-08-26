// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


Firefox firefox = new Firefox();
foreach (var item in firefox.Names())
{
    Console.WriteLine(item);
}
