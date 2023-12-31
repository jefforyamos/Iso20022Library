﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyRole3Code.  ISO2002 ID# _xqjtwPRCEeqAradXpAelDQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the party in the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyRole3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xqjtwPRCEeqAradXpAelDQ")]
public partial class PartyRole3CodeDropdownSource : EnumMetadataManager<PartyRole3Code,IPartyRole3CodeDropdownRow,PartyRole3CodeDropdownRow>
{
    public PartyRole3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyRole3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
