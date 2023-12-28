﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyType15Code.  ISO2002 ID# _XQMV8I33EeWRwov1g9WL_A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Party involved by the data set.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyType15CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyType15CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XQMV8I33EeWRwov1g9WL_A")]
public partial class PartyType15CodeDropdownRow : EnumMetadataItem<PartyType15Code>, IPartyType15CodeDropdownRow
{
    /// <summary>
    /// Party involved by the data set.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyType15CodeDropdownRow(PartyType15Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
