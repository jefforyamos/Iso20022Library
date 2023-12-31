﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyType32Code.  ISO2002 ID# _jjdWAENhEeiut6dbx3wnBg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of party.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyType32CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyType32CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jjdWAENhEeiut6dbx3wnBg")]
public partial class PartyType32CodeDropdownRow : EnumMetadataItem<PartyType32Code>, IPartyType32CodeDropdownRow
{
    /// <summary>
    /// Type of party.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyType32CodeDropdownRow(PartyType32Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
