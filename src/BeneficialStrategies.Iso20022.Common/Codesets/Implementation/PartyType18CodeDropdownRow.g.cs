﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyType18Code.  ISO2002 ID# _ewumAEqLEeenp6hmNprBHg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of role assigned.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyType18CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyType18CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ewumAEqLEeenp6hmNprBHg")]
public partial class PartyType18CodeDropdownRow : EnumMetadataItem<PartyType18Code>, IPartyType18CodeDropdownRow
{
    /// <summary>
    /// Type of role assigned.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyType18CodeDropdownRow(PartyType18Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
