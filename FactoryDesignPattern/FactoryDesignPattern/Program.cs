// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern;

Console.WriteLine("Hello, World!");

CarFactory carFactory = new();
Console.Write("Enter car type : ");
var carInput = Console.ReadLine();

try
{
    Car car = carFactory.CarCreator(carInput);
    car.Assemble();
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}