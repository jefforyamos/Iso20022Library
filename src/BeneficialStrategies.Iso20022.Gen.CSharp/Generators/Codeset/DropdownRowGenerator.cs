﻿using System.Reflection;
using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

public class DropdownRowGenerator : Generator<CodeSet>
{
    public DropdownRowGenerator()
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
        return new FileInfo(Path.Combine(targetFolder.FullName, $"{item.GenNames.DropdownRow}.g.cs"));
    }

    protected override void WriteContents(CodeSet item, TextWriter textWriter)
    {
        WriteStandardHeader(item, textWriter);
        WriteUsings(item, textWriter,
            "System.Reflection");
        WriteNamespace(item, textWriter);

        WriteClassComments(item, textWriter, 0,
            $@"Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref=""{item.GenNames.DropdownSource}""/>.",
            $@"Implements <seealso cref=""{item.GenNames.IDropdownRow}""/> by obtaining row data from the metadata contained within the codebase.");

        WriteLines(textWriter, 0,
            $@"[IsoId(""{item.Id}"")]",
            // $@"[Description(@""{item.Definition.FixStringForEnclusionInQuotedAttribute()}"")]",
            $@"public partial class {item.GenNames.DropdownRow} : EnumMetadataItem<{item.GenNames.Enum}>, {item.GenNames.IDropdownRow}",
            "{"
            );

        WriteClassComments(item, textWriter, 4,
            $@"Constructs row state using the specified enum value and reflected values."
            );

        WriteLines(textWriter, 4,
            @"/// <param name=""value"">Enum value for this row.</param>",
            @"/// <param name=""memberInfo"">Reflected values specific to this row.</param>",
            $@"public {item.GenNames.DropdownRow}({item.GenNames.Enum} value, MemberInfo memberInfo) : base(value, memberInfo)");

        WriteOpenCloseBrackets(textWriter, 4);

        WriteClosingBracket(textWriter, 0);
    }
}
