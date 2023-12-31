﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardPaymentServiceType5Code.  ISO2002 ID# _o8xIATAUEeOqioR9srQH1g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Main service provided during the card payment transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardPaymentServiceType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_o8xIATAUEeOqioR9srQH1g")]
public partial class CardPaymentServiceType5CodeDropdownSource : EnumMetadataManager<CardPaymentServiceType5Code,ICardPaymentServiceType5CodeDropdownRow,CardPaymentServiceType5CodeDropdownRow>
{
    public CardPaymentServiceType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardPaymentServiceType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
