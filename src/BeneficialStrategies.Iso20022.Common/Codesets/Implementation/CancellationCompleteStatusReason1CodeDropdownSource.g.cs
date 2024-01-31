﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancellationCompleteStatusReason1Code.  ISO2002 ID# _Vjk7Udp-Ed-ak6NoX_4Aeg_126887481.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a cancellation complete status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancellationCompleteStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vjk7Udp-Ed-ak6NoX_4Aeg_126887481")]
public partial class CancellationCompleteStatusReason1CodeDropdownSource : EnumMetadataManager<CancellationCompleteStatusReason1Code,ICancellationCompleteStatusReason1CodeDropdownRow,CancellationCompleteStatusReason1CodeDropdownRow>
{
    public CancellationCompleteStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancellationCompleteStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
