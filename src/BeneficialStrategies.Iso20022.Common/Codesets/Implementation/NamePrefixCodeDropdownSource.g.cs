﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NamePrefixCode.  ISO2002 ID# _GP3GkIMmEeeBDNMiErKunw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the terms used to formally address a person.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INamePrefixCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GP3GkIMmEeeBDNMiErKunw")]
public partial class NamePrefixCodeDropdownSource : EnumMetadataManager<NamePrefixCode,INamePrefixCodeDropdownRow,NamePrefixCodeDropdownRow>
{
    public NamePrefixCodeDropdownSource()
        : base( (enumValue, memberInfo) => new NamePrefixCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
