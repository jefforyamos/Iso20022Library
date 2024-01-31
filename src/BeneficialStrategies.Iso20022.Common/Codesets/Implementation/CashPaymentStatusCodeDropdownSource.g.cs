﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CashPaymentStatusCode.  ISO2002 ID# _a7MgQNp-Ed-ak6NoX_4Aeg_1461915358.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of a payment instruction at a specified time.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICashPaymentStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a7MgQNp-Ed-ak6NoX_4Aeg_1461915358")]
public partial class CashPaymentStatusCodeDropdownSource : EnumMetadataManager<CashPaymentStatusCode,ICashPaymentStatusCodeDropdownRow,CashPaymentStatusCodeDropdownRow>
{
    public CashPaymentStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CashPaymentStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
