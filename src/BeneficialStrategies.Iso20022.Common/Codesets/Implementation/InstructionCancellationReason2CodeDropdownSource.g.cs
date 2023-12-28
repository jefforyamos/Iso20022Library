﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstructionCancellationReason2Code.  ISO2002 ID# _aXIw9Np-Ed-ak6NoX_4Aeg_-1158791468.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction is cancelled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstructionCancellationReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aXIw9Np-Ed-ak6NoX_4Aeg_-1158791468")]
public partial class InstructionCancellationReason2CodeDropdownSource : EnumMetadataManager<InstructionCancellationReason2Code,IInstructionCancellationReason2CodeDropdownRow,InstructionCancellationReason2CodeDropdownRow>
{
    public InstructionCancellationReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstructionCancellationReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
