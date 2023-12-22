using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

/// <summary>
/// Generates enums and classes for CodeSet values that have explicit entries defined in the specification.
/// </summary>
public class CodesetEnumGenerator : Generator<CodeSet>
{
    public CodesetEnumGenerator()
        : base(repo => repo.DataDictionary.CodeSets
        .Where(cs => !cs.IsExternal)
        .Take(10) // Todo: Remove this
        )
    {
    }

    protected override DirectoryInfo DetermineTargetDirectory(DirectoryInfo projectDirectoryRoot)
    {
        var combinedPath = Path.Combine(projectDirectoryRoot.FullName, "Codesets");
        return new DirectoryInfo(combinedPath);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <param name="textWriter"></param>
    protected override void WriteContents(CodeSet item, TextWriter textWriter)
    {
        textWriter.WriteLine(@$"
namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// {item.Definition}
/// </summary>
[Serializable]
[IsoId(""{item.Id}"")]
[Description(@""{item.Definition.FixStringForEnclusionInQuotedAttribute()}"")]
public enum {item.GenNames.Enum}
{{
");
        foreach(var codeItem in item.Codes)
        {
            textWriter.WriteLine($@"
    /// <summary>
    /// {codeItem.Definition}
    /// </summary>
    [IsoId(""{codeItem.Id}"")]
    [Description(@""{codeItem.Definition.FixStringForEnclusionInQuotedAttribute()}"")]
    {codeItem.CodeName ?? codeItem.Name},
");
        }
        textWriter.WriteLine("}");

        WriteMetadataExtensions(item, textWriter);
        WriteIDropdownRow(item, textWriter);
        WriteIDropdownSource(item, textWriter);
        WriteDropdownSource(item, textWriter);
    }

    internal static void WriteMetadataExtensions(CodeSet item, TextWriter textWriter)
    {
        textWriter.WriteLine($@"

/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class {item.Name}MetadataExtensions
{{
    private static readonly {item.GenNames.DropdownSource} _dropdownSource = new {item.GenNames.DropdownSource}();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static EnumMetadataItem GetMetadata(this {item.Name} code)
    {{
        return _dropdownSource.Lookup(code) ;
    }}
}}

");
    }

    internal static void WriteIDropdownSource(CodeSet item, TextWriter textWriter)
    {
        textWriter.WriteLine($@"
/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref=""{item.Name}""/>.
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
public partial interface {item.GenNames.IDropdownRow} : IEnumMetadataDropdownRow
{{
}}
");
    }


    internal static void WriteDropdownSource(CodeSet item, TextWriter textWriter)
    {
        textWriter.WriteLine($@"
/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref=""{item.GenNames.IDropdownSource}""/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class {item.GenNames.DropdownSource} : EnumMetadataManager<{item.GenNames.Enum}> // , {item.GenNames.IDropdownSource}
{{
}}
");
    }

}