﻿using System;
using System.Text;
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

    protected virtual void WriteStandardHeader(T item, TextWriter textWriter)
    {
        WriteLines(textWriter, 0,
            "//",
            "// GENERATED CODE, DO NOT EDIT THIS FILE!",
            "//",
            @$"// Generated by {this.GetType().Name} for {item.Name}.  ISO2002 ID# {item.Id}.",
            "//",
            "");
    }

    protected void WriteClassComments(IsoRepoElement item, TextWriter textWriter, int indent=0, params string[] additionalComments)
    {
        var scoot = "".PadLeft(indent, ' ');
        textWriter.WriteLine($"{scoot}/// <summary>");
        var cleanedUpLines = item.Definition.RemoveOrReplaceFunkyCharacters().Select(s => $"/// {s}").ToArray();
        WriteLines(textWriter, indent, cleanedUpLines);
        WriteLines(textWriter, indent, additionalComments.Select(s => $"/// {s}").ToArray());
        // foreach (var line in additionalComments) textWriter.WriteLine($"{scoot}/// {line}");
        textWriter.WriteLine($"{scoot}/// </summary>");
    }

    protected void WriteUsings(T item, TextWriter textWriter, params string[] usingNamesSpaces)
    {
        foreach( var usingDirective in usingNamesSpaces)
        {
            textWriter.WriteLine($"using {usingDirective};");
        }
        textWriter.WriteLine();
    }

    protected void WriteNamespace(T item, TextWriter textWriter, string namespaceName = "BeneficialStrategies.Iso20222.Common")
    {
        textWriter.WriteLine($"namespace {namespaceName};");
        textWriter.WriteLine();
    }

    protected void WriteLines(TextWriter textWriter, int indent, params string[] linesToWrite)
    {
        var scoot = "".PadLeft(indent, ' ');
        foreach (var line in linesToWrite)
        {
            textWriter.WriteLine($"{scoot}{line}");
        }
    }

    protected void WriteClosingBracket(TextWriter textWriter, int indent) => WriteLines(textWriter, indent, "}");

    protected void WriteOpenCloseBrackets(TextWriter textWriter, int indent) => WriteLines(textWriter, indent, "{", "}");

    // protected static Func<CodeSet, bool> GlobalCodesetFilter => row => true; //  row.Name == "someValue";

    protected static Func<CodeSet, bool> GlobalCodesetFilter => row => row.Name == "ExternalOrganisationIdentificationCode";

}
