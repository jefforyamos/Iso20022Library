﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstructionQueryType1Code.  ISO2002 ID# _jjvIle5NEeCisYr99QEiWA_173504363.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of instruction queried.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstructionQueryType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jjvIle5NEeCisYr99QEiWA_173504363")]
public partial class InstructionQueryType1CodeDropdownSource : EnumMetadataManager<InstructionQueryType1Code,IInstructionQueryType1CodeDropdownRow,InstructionQueryType1CodeDropdownRow>
{
    public InstructionQueryType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstructionQueryType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
