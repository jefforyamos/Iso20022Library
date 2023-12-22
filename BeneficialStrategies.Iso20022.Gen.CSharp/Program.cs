using System.IO;
using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Initializing repository...");
        var repo = IsoRepository.Load();
        foreach (var codeSet in repo.DataDictionary.CodeSets)
        {
            Console.WriteLine($"{codeSet.Name}");
        }
        var currentDirectory = new DirectoryInfo(Environment.CurrentDirectory);
        var solutionDirectory = currentDirectory?.Parent?.Parent?.Parent?.Parent;
        var targetProjectRoot = solutionDirectory?.GetDirectories()
            .Where(d => d.Name == "BeneficialStrategies.Iso20022.Common")
            .FirstOrDefault();
        if (targetProjectRoot is null || !targetProjectRoot.Exists)
            throw new DirectoryNotFoundException($"Project folder {targetProjectRoot?.FullName} not found.") ;

        var generatorList = new List<IGenerate>
        {
            new ExternalCodesetGenerator(),
            new CodesetEnumGenerator(),
        };

        foreach( var generator in generatorList)
        {
            generator.Generate(repo, targetProjectRoot);
        }
    }
}
