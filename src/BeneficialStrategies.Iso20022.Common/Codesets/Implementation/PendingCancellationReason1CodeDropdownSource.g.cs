﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingCancellationReason1Code.  ISO2002 ID# _Z-Gl4dp-Ed-ak6NoX_4Aeg_332106838.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingCancellationReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z-Gl4dp-Ed-ak6NoX_4Aeg_332106838")]
public partial class PendingCancellationReason1CodeDropdownSource : EnumMetadataManager<PendingCancellationReason1Code,IPendingCancellationReason1CodeDropdownRow,PendingCancellationReason1CodeDropdownRow>
{
    public PendingCancellationReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingCancellationReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
