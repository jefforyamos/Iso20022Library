﻿using System.Text;
using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

public abstract class Generator<T>: IGenerate
    where T : IsoRepoElement
{
    private readonly Func<IsoRepository, IEnumerable<T>> Selector;

    public Generator(Func<IsoRepository, IEnumerable<T>> selector)
    {
        Selector = selector;
    }

    public void Generate(IsoRepository repo, DirectoryInfo projectDirectoryRoot)
    {
        foreach (var item in Selector.Invoke(repo))
        {
            var outputFilePath = DetermineOutputFile(item, projectDirectoryRoot);
            using var outputFileStream = new FileStream(outputFilePath.FullName, FileMode.Create);
            using var outputWriter = new StreamWriter(outputFileStream, Encoding.UTF8);
            WriteContents(item, outputWriter);
            outputWriter.Flush();
            outputWriter.Close();
        }
    }

    protected virtual void WriteContents(T item, TextWriter textWriter)
    {
        textWriter.WriteLine($"// {item.Name} ({item.Id})");
        textWriter.WriteLine($"// {this.GetType().Name} should override WriteContents() ");
    }

    protected virtual DirectoryInfo DetermineTargetDirectory(DirectoryInfo projectDirectoryRoot)
    {
        return projectDirectoryRoot; // Return project root by default
    }

    protected virtual FileInfo DetermineOutputFile(T item, DirectoryInfo projectDirectoryRoot)
    {
        var targetFolder = DetermineTargetDirectory(projectDirectoryRoot);
        if (!targetFolder.Exists) throw new DirectoryNotFoundException(targetFolder.FullName);
        return new FileInfo( Path.Combine(targetFolder.FullName,$"{item.Name}.g.cs"));
    }
}
