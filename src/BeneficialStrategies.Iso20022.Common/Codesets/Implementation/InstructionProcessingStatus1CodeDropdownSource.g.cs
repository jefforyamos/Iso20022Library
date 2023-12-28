﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstructionProcessingStatus1Code.  ISO2002 ID# _aXlc6dp-Ed-ak6NoX_4Aeg_486709953.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstructionProcessingStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aXlc6dp-Ed-ak6NoX_4Aeg_486709953")]
public partial class InstructionProcessingStatus1CodeDropdownSource : EnumMetadataManager<InstructionProcessingStatus1Code,IInstructionProcessingStatus1CodeDropdownRow,InstructionProcessingStatus1CodeDropdownRow>
{
    public InstructionProcessingStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstructionProcessingStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}