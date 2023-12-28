﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for NamePrefixCode.  ISO2002 ID# _GP3GkIMmEeeBDNMiErKunw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the terms used to formally address a person.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="NamePrefixCodeDropdownSource"/>.
/// Implements <seealso cref="INamePrefixCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GP3GkIMmEeeBDNMiErKunw")]
public partial class NamePrefixCodeDropdownRow : EnumMetadataItem<NamePrefixCode>, INamePrefixCodeDropdownRow
{
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public NamePrefixCodeDropdownRow(NamePrefixCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}