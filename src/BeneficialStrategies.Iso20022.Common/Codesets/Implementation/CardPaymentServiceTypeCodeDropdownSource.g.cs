﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardPaymentServiceTypeCode.  ISO2002 ID# _TWPA4QEcEeCQm6a_G2yO_w_1358541194.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Service provided by a card payment transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardPaymentServiceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TWPA4QEcEeCQm6a_G2yO_w_1358541194")]
public partial class CardPaymentServiceTypeCodeDropdownSource : EnumMetadataManager<CardPaymentServiceTypeCode,ICardPaymentServiceTypeCodeDropdownRow,CardPaymentServiceTypeCodeDropdownRow>
{
    public CardPaymentServiceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardPaymentServiceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}