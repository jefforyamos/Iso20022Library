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
        var attributeLines = new List<string>()
        {
            "[DataContract]",
            "[Serializable]",
            $@"[IsoId(""{item.Id}"")]",
            $@"[Description(@""{item.Definition.FixStringForEnclusionInQuotedAttribute()}"")]",
        };
        if( item.DerivedFrom != null )
        {
            attributeLines.Add(@$"[DerivedFrom(typeof({item.DerivedFrom.GenNames.Enum}))]");
        };

        // TODO: Figure out why all the derivations are not being generated.
        if ( item.Derivations.Length > 0 )
        {
            var attribParams = item.Derivations.Select(item => $@"typeof({item.GenNames.Enum})").ToArray();
            var withCommas = string.Join(",", attribParams);
            // attributeLines.Add($@"[Derivations({withCommas})]");
        }

        WriteLines(textWriter, 0, attributeLines.ToArray());
        WriteLines(textWriter, 0,
            $@"public enum {item.GenNames.Enum}",
            "{"
            );
        foreach(var codeItem in item.Codes)
        {
            var additionalComments = codeItem.LegalNameCodeWasChangedBecauseNameWasDuplicated
                ? new string[]
                {
                    $@"ATTENTION: Name was changed from ""{codeItem.OriginalLegalNameCode}"" to ""{codeItem.LegalCodeName}"" due to a name clash in the published ISO specification.",
                    $@"During deserialization, you may see some ambiguity between this and <seealso cref=""{codeItem.OriginalLegalNameCode}""/>",
                }
                : new string[]
                {
                    $@"Encoded/decoded by serializers as ""{codeItem.LegalCodeName}"".",
                };

            var serializationWarning = codeItem.LegalNameCodeWasChangedBecauseNameWasDuplicated
                ? " // Beware deserialization issues here because of ambiguity"
                : string.Empty;

            WriteClassComments(codeItem, textWriter, 4, additionalComments);
            
            WriteLines(textWriter, 4,
                $@"[EnumMember(Value = ""{codeItem.CodeName}"")]{serializationWarning}", 
                $@"[IsoId(""{codeItem.Id}"")]",
                $@"[Description(@""{codeItem.Definition.FixStringForEnclusionInQuotedAttribute()}"")]",
                $@"{codeItem.EnumMemberName},",
                ""
                );
        }
        textWriter.WriteLine("}");

        WriteMetadataExtensions(item, textWriter);
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

}

