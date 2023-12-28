﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason69Code.  ISO2002 ID# _K_rZwCtUEeyhipY4f42fZQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason69CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_K_rZwCtUEeyhipY4f42fZQ")]
public partial class RejectionReason69CodeDropdownSource : EnumMetadataManager<RejectionReason69Code,IRejectionReason69CodeDropdownRow,RejectionReason69CodeDropdownRow>
{
    public RejectionReason69CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason69CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
