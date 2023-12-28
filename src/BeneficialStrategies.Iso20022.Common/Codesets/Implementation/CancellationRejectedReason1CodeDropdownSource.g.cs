﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancellationRejectedReason1Code.  ISO2002 ID# _bYjKotp-Ed-ak6NoX_4Aeg_-534177110.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a cancellation rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancellationRejectedReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bYjKotp-Ed-ak6NoX_4Aeg_-534177110")]
public partial class CancellationRejectedReason1CodeDropdownSource : EnumMetadataManager<CancellationRejectedReason1Code,ICancellationRejectedReason1CodeDropdownRow,CancellationRejectedReason1CodeDropdownRow>
{
    public CancellationRejectedReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancellationRejectedReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}