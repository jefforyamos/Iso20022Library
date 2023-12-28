﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardPaymentServiceType2Code.  ISO2002 ID# _TSqIbwEcEeCQm6a_G2yO_w_2042569244.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Service provided by the card payment transaction, in addition to the main service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardPaymentServiceType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TSqIbwEcEeCQm6a_G2yO_w_2042569244")]
public partial class CardPaymentServiceType2CodeDropdownSource : EnumMetadataManager<CardPaymentServiceType2Code,ICardPaymentServiceType2CodeDropdownRow,CardPaymentServiceType2CodeDropdownRow>
{
    public CardPaymentServiceType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardPaymentServiceType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
