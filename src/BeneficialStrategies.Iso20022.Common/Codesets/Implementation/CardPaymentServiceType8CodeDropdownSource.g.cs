﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardPaymentServiceType8Code.  ISO2002 ID# _CPqhwHsvEeSTS7uHCe8FPQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Main card service transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardPaymentServiceType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CPqhwHsvEeSTS7uHCe8FPQ")]
public partial class CardPaymentServiceType8CodeDropdownSource : EnumMetadataManager<CardPaymentServiceType8Code,ICardPaymentServiceType8CodeDropdownRow,CardPaymentServiceType8CodeDropdownRow>
{
    public CardPaymentServiceType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardPaymentServiceType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
