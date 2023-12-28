﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentsPartyType1Code.  ISO2002 ID# _U1e2wKHHEeagRbKvRt3LnA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// CodeSet identifying parties involved in a payments transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentsPartyType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_U1e2wKHHEeagRbKvRt3LnA")]
public partial class PaymentsPartyType1CodeDropdownSource : EnumMetadataManager<PaymentsPartyType1Code,IPaymentsPartyType1CodeDropdownRow,PaymentsPartyType1CodeDropdownRow>
{
    public PaymentsPartyType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentsPartyType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
