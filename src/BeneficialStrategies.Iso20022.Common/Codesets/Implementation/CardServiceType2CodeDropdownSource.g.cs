﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardServiceType2Code.  ISO2002 ID# _Xg9gcHvEEeSKFIcWw3l4Yw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of network management service (correspond to the ISO 8583 field 24).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardServiceType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Xg9gcHvEEeSKFIcWw3l4Yw")]
public partial class CardServiceType2CodeDropdownSource : EnumMetadataManager<CardServiceType2Code,ICardServiceType2CodeDropdownRow,CardServiceType2CodeDropdownRow>
{
    public CardServiceType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardServiceType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}