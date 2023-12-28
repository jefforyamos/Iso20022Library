﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Payment2Code.  ISO2002 ID# _-qqGELXOEeiTob_PrFFUxA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPayment2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-qqGELXOEeiTob_PrFFUxA")]
public partial class Payment2CodeDropdownSource : EnumMetadataManager<Payment2Code,IPayment2CodeDropdownRow,Payment2CodeDropdownRow>
{
    public Payment2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Payment2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
