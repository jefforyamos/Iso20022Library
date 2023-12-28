﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCAdjustmentPaymentSubReasonV2Code.  ISO2002 ID# _xxT_AL_kEeeb2ZBoAlSG1Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the subtype of the payment adjustment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCAdjustmentPaymentSubReasonV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xxT_AL_kEeeb2ZBoAlSG1Q")]
public partial class DTCAdjustmentPaymentSubReasonV2CodeDropdownSource : EnumMetadataManager<DTCAdjustmentPaymentSubReasonV2Code,IDTCAdjustmentPaymentSubReasonV2CodeDropdownRow,DTCAdjustmentPaymentSubReasonV2CodeDropdownRow>
{
    public DTCAdjustmentPaymentSubReasonV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCAdjustmentPaymentSubReasonV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}