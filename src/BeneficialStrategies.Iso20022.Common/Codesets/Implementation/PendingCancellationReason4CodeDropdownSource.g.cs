﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingCancellationReason4Code.  ISO2002 ID# _Z-QW4Np-Ed-ak6NoX_4Aeg_2142368384.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Standard code to specify.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingCancellationReason4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z-QW4Np-Ed-ak6NoX_4Aeg_2142368384")]
public partial class PendingCancellationReason4CodeDropdownSource : EnumMetadataManager<PendingCancellationReason4Code,IPendingCancellationReason4CodeDropdownRow,PendingCancellationReason4CodeDropdownRow>
{
    public PendingCancellationReason4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingCancellationReason4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
