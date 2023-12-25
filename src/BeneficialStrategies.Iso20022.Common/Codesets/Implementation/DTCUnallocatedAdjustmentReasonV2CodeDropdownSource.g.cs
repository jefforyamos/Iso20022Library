﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCUnallocatedAdjustmentReasonV2Code.  ISO2002 ID# _n3w1hsMQEee-Vv_OVx0uAQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// DTC Unallocated reason codes for payment adjustments.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCUnallocatedAdjustmentReasonV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_n3w1hsMQEee-Vv_OVx0uAQ")]
public partial class DTCUnallocatedAdjustmentReasonV2CodeDropdownSource : EnumMetadataManager<DTCUnallocatedAdjustmentReasonV2Code,IDTCUnallocatedAdjustmentReasonV2CodeDropdownRow,DTCUnallocatedAdjustmentReasonV2CodeDropdownRow>
{
    public DTCUnallocatedAdjustmentReasonV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCUnallocatedAdjustmentReasonV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
