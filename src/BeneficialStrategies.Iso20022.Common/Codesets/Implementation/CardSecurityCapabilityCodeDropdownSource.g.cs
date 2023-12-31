﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardSecurityCapabilityCode.  ISO2002 ID# _w7olUJitEeefZKJHxQTztg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies security capabilties of the card.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardSecurityCapabilityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_w7olUJitEeefZKJHxQTztg")]
public partial class CardSecurityCapabilityCodeDropdownSource : EnumMetadataManager<CardSecurityCapabilityCode,ICardSecurityCapabilityCodeDropdownRow,CardSecurityCapabilityCodeDropdownRow>
{
    public CardSecurityCapabilityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardSecurityCapabilityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
