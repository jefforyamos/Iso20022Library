using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

/// <summary>
/// Generates interfaces to be used concerning codeset values maintained externally.
/// </summary>
public class ExternalCodesetGenerator : Generator<CodeSet>
{
    public ExternalCodesetGenerator()
        : base( repo => repo.DataDictionary.CodeSets
        .Where(cs => cs.IsExternal)
        .Take(10) // Todo: Remove this
        )
    {

    }

    protected override DirectoryInfo DetermineTargetDirectory(DirectoryInfo projectDirectoryRoot)
    {
        var combinedPath = Path.Combine(projectDirectoryRoot.FullName, "Codesets");
        return new DirectoryInfo(combinedPath);
    }

    protected override void WriteContents(CodeSet item, TextWriter textWriter)
    {
        textWriter.WriteLine("namespace BeneficialStrategies.Iso20222.Common;");
        WriteIDropdownRow(item, textWriter);
        WriteIDropdownSource(item, textWriter);
    }

    internal static void WriteIDropdownSource(CodeSet item, TextWriter textWriter)
    {
        textWriter.WriteLine($@"
/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid {item.Name} value.
/// It is the responsibility of the implementers of this interface to conform to the required specifications.
/// </summary>
public partial interface {item.GenNames.IDropdownSource} : IDropdownDataSource<{item.GenNames.IDropdownRow}>
{{
}}
");
    }


    internal static void WriteIDropdownRow(CodeSet item, TextWriter textWriter)
    {
        textWriter.WriteLine($@"
/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface {item.GenNames.IDropdownRow} : IDropdownRow
{{
}}
");
    }

}
