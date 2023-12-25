using System.IO;
using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1) throw new ArgumentException($"You must pass the folder which contains {IsoRepository.CurrentlySupportedRepoFile}");
        var directoryInfo = new DirectoryInfo(args[0]);
        if (!directoryInfo.Exists) throw new DirectoryNotFoundException($"Folder matching {args[0]} could not be found");
        var file = new FileInfo(Path.Combine(directoryInfo.FullName, IsoRepository.CurrentlySupportedRepoFile));
        if (!file.Exists) throw new FileNotFoundException($"Repo file {file.Name} not found in {directoryInfo.FullName}");
        
        Console.WriteLine("Initializing repository...");
        var repo = IsoRepository.Load(file.FullName);
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
            new DropdownRowInterfaceGenerator(),
            new DropdownSourceInterfaceGenerator(),
            new CodesetEnumGenerator(),
            new DropdownSourceGenerator(),
            new DropdownRowGenerator(),
        };

        foreach( var generator in generatorList)
        {
            generator.Generate(repo, targetProjectRoot);
        }
    }
}
