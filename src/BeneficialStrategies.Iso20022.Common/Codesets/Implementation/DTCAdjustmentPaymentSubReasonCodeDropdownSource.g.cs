﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCAdjustmentPaymentSubReasonCode.  ISO2002 ID# _9k5cgGfhEeOB5r-GpjGdRQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the subtype of the payment adjustment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCAdjustmentPaymentSubReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_9k5cgGfhEeOB5r-GpjGdRQ")]
public partial class DTCAdjustmentPaymentSubReasonCodeDropdownSource : EnumMetadataManager<DTCAdjustmentPaymentSubReasonCode,IDTCAdjustmentPaymentSubReasonCodeDropdownRow,DTCAdjustmentPaymentSubReasonCodeDropdownRow>
{
    public DTCAdjustmentPaymentSubReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCAdjustmentPaymentSubReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
