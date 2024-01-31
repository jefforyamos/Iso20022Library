﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardFallbackCode.  ISO2002 ID# _Rr44gGkCEeS7zPBpvm732w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information about card entry mode fallback.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardFallbackCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Rr44gGkCEeS7zPBpvm732w")]
public partial class CardFallbackCodeDropdownSource : EnumMetadataManager<CardFallbackCode,ICardFallbackCodeDropdownRow,CardFallbackCodeDropdownRow>
{
    public CardFallbackCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardFallbackCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
