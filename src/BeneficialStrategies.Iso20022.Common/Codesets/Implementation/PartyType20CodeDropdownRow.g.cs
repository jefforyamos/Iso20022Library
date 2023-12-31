﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyType20Code.  ISO2002 ID# _VnZwkE0pEeea0Mdu1TOzDQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Card domain type of party.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyType20CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyType20CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VnZwkE0pEeea0Mdu1TOzDQ")]
public partial class PartyType20CodeDropdownRow : EnumMetadataItem<PartyType20Code>, IPartyType20CodeDropdownRow
{
    /// <summary>
    /// Card domain type of party.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyType20CodeDropdownRow(PartyType20Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
