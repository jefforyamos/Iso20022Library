﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyType9Code.  ISO2002 ID# _2fUvkHrTEeSfJf8ETXpBxg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of entity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyType9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2fUvkHrTEeSfJf8ETXpBxg")]
public partial class PartyType9CodeDropdownSource : EnumMetadataManager<PartyType9Code,IPartyType9CodeDropdownRow,PartyType9CodeDropdownRow>
{
    public PartyType9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyType9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
