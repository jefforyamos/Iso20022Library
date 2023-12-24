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
        .Where(GlobalCodesetFilter)
        )
    {
    }

    protected override DirectoryInfo DetermineTargetDirectory(DirectoryInfo projectDirectoryRoot)
    {
        var combinedPath = Path.Combine(projectDirectoryRoot.FullName, "Codesets/Enum");
        return new DirectoryInfo(combinedPath);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <param name="textWriter"></param>
    protected override void WriteContents(CodeSet item, TextWriter textWriter)
    {
        WriteStandardHeader(item, textWriter);
        WriteUsings(item, textWriter,
            "System.Reflection",
            "System.Runtime.Serialization");
        WriteNamespace(item, textWriter);
        WriteClassComments(item, textWriter);
        WriteLines(textWriter, 0,
            "[DataContract]",
            "[Serializable]",
            $@"[IsoId(""{item.Id}"")]",
            $@"[Description(@""{item.Definition.FixStringForEnclusionInQuotedAttribute()}"")]",
            $@"public enum {item.GenNames.Enum}",
            "{"
            );
        foreach(var codeItem in item.Codes)
        {
            WriteClassComments(codeItem, textWriter, 4);
            WriteLines(textWriter, 4,
                $@"[EnumMember(Value = ""{codeItem.CodeName}"")]",
                $@"[IsoId(""{codeItem.Id}"")]",
                $@"[Description(@""{codeItem.Definition.FixStringForEnclusionInQuotedAttribute()}"")]",
                $@"{codeItem.LegalCodeName},",
                ""
                );
        }
        textWriter.WriteLine("}");

        WriteMetadataExtensions(item, textWriter);
        // WriteIDropdownRow(item, textWriter);
        // WriteDropdownRow(item, textWriter);
        // WriteIDropdownSource(item, textWriter);
        // WriteDropdownSource(item, textWriter);
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
    public static {item.GenNames.IDropdownRow} GetMetadata(this {item.Name} code)
    {{
        return _dropdownSource.Lookup(code) ;
    }}
}}

");
    }

    internal static void WriteDropdownRow(CodeSet item, TextWriter textWriter)
    {
        textWriter.WriteLine($@"
/// <summary>
/// Default implementation of <seealso cref=""{item.GenNames.IDropdownRow}""/> that contains metadata embedded in the code.
/// </summary>
public partial class {item.GenNames.DropdownRow} : EnumMetadataItem<{item.GenNames.Enum}>, {item.GenNames.IDropdownRow}
{{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name=""value"">Enum value for this row.</param>
    /// <param name=""memberInfo"">Reflected values specific to this row.</param>
    public {item.GenNames.DropdownRow}({item.GenNames.Enum} value, MemberInfo memberInfo) : base( value, memberInfo)
    {{
    }}
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
public partial class {item.GenNames.DropdownSource} : EnumMetadataManager<{item.GenNames.Enum},{item.GenNames.IDropdownRow},{item.GenNames.DropdownRow}>
{{
    public {item.GenNames.DropdownSource}()
        : base( (enumValue, memberInfo) => new {item.GenNames.DropdownRow}(enumValue, memberInfo))
    {{
    }}
}}
");
    }

}

