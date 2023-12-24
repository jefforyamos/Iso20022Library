using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

/// <summary>
/// Generates interfaces to be used concerning codeset values maintained externally.
/// </summary>
public class DropdownRowInterfaceGenerator : Generator<CodeSet>
{
    public DropdownRowInterfaceGenerator()
        : base(repo => repo.DataDictionary.CodeSets
        .Where(GlobalCodesetFilter)
        )
    {

    }

    protected override DirectoryInfo DetermineTargetDirectory(DirectoryInfo projectDirectoryRoot)
    {
        var combinedPath = Path.Combine(projectDirectoryRoot.FullName, "Codesets/Interface");
        return new DirectoryInfo(combinedPath);
    }

    protected override FileInfo DetermineOutputFile(CodeSet item, DirectoryInfo projectDirectoryRoot)
    {
        var targetFolder = DetermineTargetDirectory(projectDirectoryRoot);
        if (!targetFolder.Exists) throw new DirectoryNotFoundException(targetFolder.FullName);
        return new FileInfo(Path.Combine(targetFolder.FullName, $"{item.GenNames.IDropdownRow}.g.cs"));
    }

    protected override void WriteContents(CodeSet item, TextWriter textWriter)
    {
        var inheritance = item.IsExternal
            ? "IDropdownRow"
            : $"IEnumMetadataDropdownRow<{item.GenNames.Enum}>";
        WriteStandardHeader(item, textWriter);
        textWriter.WriteLine("namespace BeneficialStrategies.Iso20222.Common;");
        textWriter.WriteLine($@"
/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface {item.GenNames.IDropdownRow} : {inheritance}
{{
}}
");
    }
}

