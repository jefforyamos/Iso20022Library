﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCAdjustmentPaymentTypeV2Code.  ISO2002 ID# _cmC3IHxsEeOCOoRiuJeDeg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the payment adjustment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCAdjustmentPaymentTypeV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cmC3IHxsEeOCOoRiuJeDeg")]
public partial class DTCAdjustmentPaymentTypeV2CodeDropdownSource : EnumMetadataManager<DTCAdjustmentPaymentTypeV2Code,IDTCAdjustmentPaymentTypeV2CodeDropdownRow,DTCAdjustmentPaymentTypeV2CodeDropdownRow>
{
    public DTCAdjustmentPaymentTypeV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCAdjustmentPaymentTypeV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
