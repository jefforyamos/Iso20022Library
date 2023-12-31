﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstructionProcessingStatusCode.  ISO2002 ID# _aYLSwdp-Ed-ak6NoX_4Aeg_-433562560.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstructionProcessingStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aYLSwdp-Ed-ak6NoX_4Aeg_-433562560")]
public partial class InstructionProcessingStatusCodeDropdownSource : EnumMetadataManager<InstructionProcessingStatusCode,IInstructionProcessingStatusCodeDropdownRow,InstructionProcessingStatusCodeDropdownRow>
{
    public InstructionProcessingStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstructionProcessingStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
