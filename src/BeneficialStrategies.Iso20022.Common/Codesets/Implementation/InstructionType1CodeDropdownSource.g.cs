﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstructionType1Code.  ISO2002 ID# _aYn-tdp-Ed-ak6NoX_4Aeg_-377371572.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the action that the TSU must take on a baseline.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstructionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aYn-tdp-Ed-ak6NoX_4Aeg_-377371572")]
public partial class InstructionType1CodeDropdownSource : EnumMetadataManager<InstructionType1Code,IInstructionType1CodeDropdownRow,InstructionType1CodeDropdownRow>
{
    public InstructionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstructionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}