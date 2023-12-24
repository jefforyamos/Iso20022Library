using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

public class DropdownSourceGenerator : Generator<CodeSet>
{
    public DropdownSourceGenerator()
         : base(repo => repo.DataDictionary.CodeSets
        .Where(cs => !cs.IsExternal)
        .Where(GlobalCodesetFilter)
        )
    {
    }

    protected override DirectoryInfo DetermineTargetDirectory(DirectoryInfo projectDirectoryRoot)
    {
        var combinedPath = Path.Combine(projectDirectoryRoot.FullName, "Codesets/Implementation");
        return new DirectoryInfo(combinedPath);
    }

    protected override FileInfo DetermineOutputFile(CodeSet item, DirectoryInfo projectDirectoryRoot)
    {
        var targetFolder = DetermineTargetDirectory(projectDirectoryRoot);
        if (!targetFolder.Exists) throw new DirectoryNotFoundException(targetFolder.FullName);
        return new FileInfo(Path.Combine(targetFolder.FullName, $"{item.GenNames.DropdownSource}.g.cs"));
    }

    protected override void WriteContents(CodeSet item, TextWriter textWriter)
    {
        WriteStandardHeader(item, textWriter);
        // WriteUsings(item, textWriter, "System.Reflection");
        WriteNamespace(item, textWriter);

        WriteClassComments(item, textWriter, 0,
            "Provides values to be used in dropdown select lists and validation logic.",
            $@"Implements <seealso cref=""{item.GenNames.IDropdownSource}""/> by obtaining row data from the metadata contained within the codebase.");

        WriteLines(textWriter, 0,
            $@"[IsoId(""{item.Id}"")]",
            // $@"[Description(@""{item.Definition.FixStringForEnclusionInQuotedAttribute()}"")]",
            $@"public partial class {item.GenNames.DropdownSource} : EnumMetadataManager<{item.GenNames.Enum},{item.GenNames.IDropdownRow},{item.GenNames.DropdownRow}>",
            "{");

        WriteLines(textWriter, 4,
            $@"public {item.GenNames.DropdownSource}()");

        WriteLines(textWriter, 8,
            $@": base( (enumValue, memberInfo) => new {item.GenNames.DropdownRow}(enumValue, memberInfo))"
            );

        WriteOpenCloseBrackets(textWriter, 4); // For the constructor

        WriteClosingBracket(textWriter, 0);
    }
}

