﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyType20Code.  ISO2002 ID# _VnZwkE0pEeea0Mdu1TOzDQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Card domain type of party.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyType20CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VnZwkE0pEeea0Mdu1TOzDQ")]
public partial class PartyType20CodeDropdownSource : EnumMetadataManager<PartyType20Code,IPartyType20CodeDropdownRow,PartyType20CodeDropdownRow>
{
    public PartyType20CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyType20CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
