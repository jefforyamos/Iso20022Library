﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyType23Code.  ISO2002 ID# _NFZZYFBBEeedyPuM0kK2EQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Party in charge of clearing payment or related transactions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyType23CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NFZZYFBBEeedyPuM0kK2EQ")]
public partial class PartyType23CodeDropdownSource : EnumMetadataManager<PartyType23Code,IPartyType23CodeDropdownRow,PartyType23CodeDropdownRow>
{
    public PartyType23CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyType23CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
