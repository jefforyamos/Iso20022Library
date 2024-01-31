﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstructionRejectionReason2Code.  ISO2002 ID# _53kiUACpEeqouY-yI_q3qQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstructionRejectionReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_53kiUACpEeqouY-yI_q3qQ")]
public partial class InstructionRejectionReason2CodeDropdownSource : EnumMetadataManager<InstructionRejectionReason2Code,IInstructionRejectionReason2CodeDropdownRow,InstructionRejectionReason2CodeDropdownRow>
{
    public InstructionRejectionReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstructionRejectionReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
