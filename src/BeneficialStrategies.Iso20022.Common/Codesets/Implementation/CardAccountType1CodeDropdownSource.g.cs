﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardAccountType1Code.  ISO2002 ID# _TSNcfAEcEeCQm6a_G2yO_w_389240327.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cardholder account used for the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardAccountType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TSNcfAEcEeCQm6a_G2yO_w_389240327")]
public partial class CardAccountType1CodeDropdownSource : EnumMetadataManager<CardAccountType1Code,ICardAccountType1CodeDropdownRow,CardAccountType1CodeDropdownRow>
{
    public CardAccountType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardAccountType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}