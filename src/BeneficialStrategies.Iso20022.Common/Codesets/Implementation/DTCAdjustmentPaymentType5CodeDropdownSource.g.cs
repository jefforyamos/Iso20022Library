﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCAdjustmentPaymentType5Code.  ISO2002 ID# _LqTzEMMOEee-Vv_OVx0uAQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the payment adjustment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCAdjustmentPaymentType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_LqTzEMMOEee-Vv_OVx0uAQ")]
public partial class DTCAdjustmentPaymentType5CodeDropdownSource : EnumMetadataManager<DTCAdjustmentPaymentType5Code,IDTCAdjustmentPaymentType5CodeDropdownRow,DTCAdjustmentPaymentType5CodeDropdownRow>
{
    public DTCAdjustmentPaymentType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCAdjustmentPaymentType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
