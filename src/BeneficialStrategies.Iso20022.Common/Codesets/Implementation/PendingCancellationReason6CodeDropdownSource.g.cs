﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingCancellationReason6Code.  ISO2002 ID# _vhob4bLOEemDyeh7tbvg1w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a reason why the cancellation request has a pending status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingCancellationReason6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vhob4bLOEemDyeh7tbvg1w")]
public partial class PendingCancellationReason6CodeDropdownSource : EnumMetadataManager<PendingCancellationReason6Code,IPendingCancellationReason6CodeDropdownRow,PendingCancellationReason6CodeDropdownRow>
{
    public PendingCancellationReason6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingCancellationReason6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
