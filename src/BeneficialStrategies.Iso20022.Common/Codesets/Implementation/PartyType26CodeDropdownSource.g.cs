﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyType26Code.  ISO2002 ID# _SBhCMJmMEee_M7tURHTZTQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of entity acting as a Payment Initiation Service Provider.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyType26CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SBhCMJmMEee_M7tURHTZTQ")]
public partial class PartyType26CodeDropdownSource : EnumMetadataManager<PartyType26Code,IPartyType26CodeDropdownRow,PartyType26CodeDropdownRow>
{
    public PartyType26CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyType26CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
