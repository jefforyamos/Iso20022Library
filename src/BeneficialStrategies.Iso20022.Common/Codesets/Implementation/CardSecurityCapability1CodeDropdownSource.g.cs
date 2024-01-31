﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardSecurityCapability1Code.  ISO2002 ID# _zyCVQJiuEeefZKJHxQTztg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card security code list.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardSecurityCapability1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zyCVQJiuEeefZKJHxQTztg")]
public partial class CardSecurityCapability1CodeDropdownSource : EnumMetadataManager<CardSecurityCapability1Code,ICardSecurityCapability1CodeDropdownRow,CardSecurityCapability1CodeDropdownRow>
{
    public CardSecurityCapability1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardSecurityCapability1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
