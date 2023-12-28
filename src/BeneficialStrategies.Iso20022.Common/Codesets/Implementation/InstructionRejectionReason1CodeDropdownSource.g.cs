﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstructionRejectionReason1Code.  ISO2002 ID# _W_GJgMYNEeexPc-mfUU5zQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstructionRejectionReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_W_GJgMYNEeexPc-mfUU5zQ")]
public partial class InstructionRejectionReason1CodeDropdownSource : EnumMetadataManager<InstructionRejectionReason1Code,IInstructionRejectionReason1CodeDropdownRow,InstructionRejectionReason1CodeDropdownRow>
{
    public InstructionRejectionReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstructionRejectionReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}