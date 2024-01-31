﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCAdjustmentPaymentType3Code.  ISO2002 ID# _RYe2wJ6BEeW1p8WuttdPEw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the payment adjustment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCAdjustmentPaymentType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RYe2wJ6BEeW1p8WuttdPEw")]
public partial class DTCAdjustmentPaymentType3CodeDropdownSource : EnumMetadataManager<DTCAdjustmentPaymentType3Code,IDTCAdjustmentPaymentType3CodeDropdownRow,DTCAdjustmentPaymentType3CodeDropdownRow>
{
    public DTCAdjustmentPaymentType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCAdjustmentPaymentType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
