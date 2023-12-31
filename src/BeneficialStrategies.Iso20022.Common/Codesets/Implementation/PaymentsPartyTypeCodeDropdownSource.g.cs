﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentsPartyTypeCode.  ISO2002 ID# _0lBckKHFEeagRbKvRt3LnA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// CodeSet identifying parties involved in a payments transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentsPartyTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0lBckKHFEeagRbKvRt3LnA")]
public partial class PaymentsPartyTypeCodeDropdownSource : EnumMetadataManager<PaymentsPartyTypeCode,IPaymentsPartyTypeCodeDropdownRow,PaymentsPartyTypeCodeDropdownRow>
{
    public PaymentsPartyTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentsPartyTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
