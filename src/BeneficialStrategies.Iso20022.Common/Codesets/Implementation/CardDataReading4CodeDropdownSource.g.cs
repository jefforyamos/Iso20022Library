﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardDataReading4Code.  ISO2002 ID# _CRJTMIn7EeShMpas3885ww.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Capabilities of the ATM terminal performing the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardDataReading4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CRJTMIn7EeShMpas3885ww")]
public partial class CardDataReading4CodeDropdownSource : EnumMetadataManager<CardDataReading4Code,ICardDataReading4CodeDropdownRow,CardDataReading4CodeDropdownRow>
{
    public CardDataReading4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardDataReading4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
