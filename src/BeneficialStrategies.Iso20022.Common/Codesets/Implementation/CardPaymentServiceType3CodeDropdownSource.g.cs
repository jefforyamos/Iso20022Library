﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardPaymentServiceType3Code.  ISO2002 ID# _TSz5ZgEcEeCQm6a_G2yO_w_-878282467.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Additional attributes of the service provided by the card payment transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardPaymentServiceType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TSz5ZgEcEeCQm6a_G2yO_w_-878282467")]
public partial class CardPaymentServiceType3CodeDropdownSource : EnumMetadataManager<CardPaymentServiceType3Code,ICardPaymentServiceType3CodeDropdownRow,CardPaymentServiceType3CodeDropdownRow>
{
    public CardPaymentServiceType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardPaymentServiceType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
