﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason71Code.  ISO2002 ID# _dEaVCitVEeyhipY4f42fZQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason71CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dEaVCitVEeyhipY4f42fZQ")]
public partial class RejectionReason71CodeDropdownSource : EnumMetadataManager<RejectionReason71Code,IRejectionReason71CodeDropdownRow,RejectionReason71CodeDropdownRow>
{
    public RejectionReason71CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason71CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
