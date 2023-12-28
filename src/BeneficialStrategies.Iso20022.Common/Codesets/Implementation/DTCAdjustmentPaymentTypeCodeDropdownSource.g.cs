﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCAdjustmentPaymentTypeCode.  ISO2002 ID# _1596AjL3EeKU9IrkkToqcw_604755417.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the payment adjustment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCAdjustmentPaymentTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1596AjL3EeKU9IrkkToqcw_604755417")]
public partial class DTCAdjustmentPaymentTypeCodeDropdownSource : EnumMetadataManager<DTCAdjustmentPaymentTypeCode,IDTCAdjustmentPaymentTypeCodeDropdownRow,DTCAdjustmentPaymentTypeCodeDropdownRow>
{
    public DTCAdjustmentPaymentTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCAdjustmentPaymentTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}