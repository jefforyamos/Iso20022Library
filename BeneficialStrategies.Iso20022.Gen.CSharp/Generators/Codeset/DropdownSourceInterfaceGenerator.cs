using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

/// <summary>
/// Generates interfaces to be used concerning codeset values maintained externally.
/// </summary>
public class DropdownSourceInterfaceGenerator : Generator<CodeSet>
{
    public DropdownSourceInterfaceGenerator()
        : base(repo => repo.DataDictionary.CodeSets
        // .Where(cs => cs.Name == "ExternalOrganisationIdentificationCode") // Todo: Remove this after troubleshooting
        )
    {

    }

    protected override DirectoryInfo DetermineTargetDirectory(DirectoryInfo projectDirectoryRoot)
    {
        var combinedPath = Path.Combine(projectDirectoryRoot.FullName, "Codesets");
        return new DirectoryInfo(combinedPath);
    }

    protected override FileInfo DetermineOutputFile(CodeSet item, DirectoryInfo projectDirectoryRoot)
    {
        var targetFolder = DetermineTargetDirectory(projectDirectoryRoot);
        if (!targetFolder.Exists) throw new DirectoryNotFoundException(targetFolder.FullName);
        return new FileInfo(Path.Combine(targetFolder.FullName, $"{item.GenNames.IDropdownSource}.g.cs"));
    }

    protected override void WriteContents(CodeSet item, TextWriter textWriter)
    {
        WriteStandardHeader(item, textWriter);
        textWriter.WriteLine("namespace BeneficialStrategies.Iso20222.Common;");
        if (item.IsExternal)
        {
            textWriter.WriteLine($@"
/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid {item.Name} value.
/// It is the responsibility of the implementers of this interface to conform to the required specifications.
/// </summary>
");
        }
        else
        {
            textWriter.WriteLine($@"
/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid {item.Name} value.
/// It is strongly urged that you use the provided <seealso cref=""{item.GenNames.DropdownSource}""/> that extracts the ISO20022 specified values from metadata in the codebase.
/// </summary>
");
        }
        textWriter.WriteLine($@"
public partial interface {item.GenNames.IDropdownSource} : IDropdownDataSource<{item.GenNames.IDropdownRow}>
{{
}}
");
    }
}



