// See https://aka.ms/new-console-template for more information

using BeneficialStrategies.Iso20022.Repository;
using Microsoft.CodeAnalysis;

namespace ParseCli;
public partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loading....");
        var repo = IsoRepository.Load();
        Console.WriteLine("Loaded, press any key....");
        Console.ReadKey();
    }

    static partial void HelloFrom(string name);
    static partial void HelloFrom2(string name);
    static partial void MethodNotPresent();
}