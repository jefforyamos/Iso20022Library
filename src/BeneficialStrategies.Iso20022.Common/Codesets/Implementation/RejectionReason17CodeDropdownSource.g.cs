﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason17Code.  ISO2002 ID# _ZiY6RNp-Ed-ak6NoX_4Aeg_-1381519795.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason17CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZiY6RNp-Ed-ak6NoX_4Aeg_-1381519795")]
public partial class RejectionReason17CodeDropdownSource : EnumMetadataManager<RejectionReason17Code,IRejectionReason17CodeDropdownRow,RejectionReason17CodeDropdownRow>
{
    public RejectionReason17CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason17CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
