﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCUnallocatedAdjustmentReason4Code.  ISO2002 ID# _SN44AMMSEee-Vv_OVx0uAQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// DTC Unallocated reason codes for payment adjustments.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCUnallocatedAdjustmentReason4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SN44AMMSEee-Vv_OVx0uAQ")]
public partial class DTCUnallocatedAdjustmentReason4CodeDropdownSource : EnumMetadataManager<DTCUnallocatedAdjustmentReason4Code,IDTCUnallocatedAdjustmentReason4CodeDropdownRow,DTCUnallocatedAdjustmentReason4CodeDropdownRow>
{
    public DTCUnallocatedAdjustmentReason4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCUnallocatedAdjustmentReason4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
