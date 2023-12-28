﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyType4Code.  ISO2002 ID# _TTtRQAEcEeCQm6a_G2yO_w_-1492633607.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Entity assigning an identification (for example merchant, acceptor, acquirer, tax authority, etc.).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyType4CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyType4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TTtRQAEcEeCQm6a_G2yO_w_-1492633607")]
public partial class PartyType4CodeDropdownRow : EnumMetadataItem<PartyType4Code>, IPartyType4CodeDropdownRow
{
    /// <summary>
    /// Entity assigning an identification (for example merchant, acceptor, acquirer, tax authority, etc.).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyType4CodeDropdownRow(PartyType4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
