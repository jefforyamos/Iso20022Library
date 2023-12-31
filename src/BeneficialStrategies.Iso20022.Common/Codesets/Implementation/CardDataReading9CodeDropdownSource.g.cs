﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardDataReading9Code.  ISO2002 ID# _ApKlgJlfEeu76rs9yGlfEg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method used to obtain card payment information.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardDataReading9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ApKlgJlfEeu76rs9yGlfEg")]
public partial class CardDataReading9CodeDropdownSource : EnumMetadataManager<CardDataReading9Code,ICardDataReading9CodeDropdownRow,CardDataReading9CodeDropdownRow>
{
    public CardDataReading9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardDataReading9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
