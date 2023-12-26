using System.IO;
using BeneficialStrategies.Iso20022.Repository;
using System.Collections.Generic;

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

        var generatorSet = "doc"; // by default;
        if (args.Length >= 2) generatorSet = args[1];
        var generatorLookup = new GeneratorsGroupedByRequestedNameDictionary();
        if (!generatorLookup.ContainsKey(generatorSet))
        {
            var validValues = String.Join(",", generatorLookup.Keys.ToArray());
            throw new ArgumentException($"Generator set {generatorSet} is invalid. Valid values: [{validValues}]");
        }
        var generatorsToRun = generatorLookup[generatorSet];

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

        Console.WriteLine($@"Running generator set ""{generatorSet}"".");
        foreach( var generator in generatorsToRun)
        {
            Console.Write($"    : {generator.GetType().Name.PadRight(40)}");
            generator.Generate(repo, targetProjectRoot);
            Console.WriteLine("<<==== Done");
        }
    }
}
