﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectedCancellationStatusReason1Code.  ISO2002 ID# _ZbPJZtp-Ed-ak6NoX_4Aeg_1035998628.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for which a cancellation is rejected.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectedCancellationStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZbPJZtp-Ed-ak6NoX_4Aeg_1035998628")]
public partial class RejectedCancellationStatusReason1CodeDropdownSource : EnumMetadataManager<RejectedCancellationStatusReason1Code,IRejectedCancellationStatusReason1CodeDropdownRow,RejectedCancellationStatusReason1CodeDropdownRow>
{
    public RejectedCancellationStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectedCancellationStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}