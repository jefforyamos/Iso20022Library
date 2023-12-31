﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyType33Code.  ISO2002 ID# _pHKm8Q0wEeqUVL7sB4m7NA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of entity involved in a transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyType33CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyType33CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pHKm8Q0wEeqUVL7sB4m7NA")]
public partial class PartyType33CodeDropdownRow : EnumMetadataItem<PartyType33Code>, IPartyType33CodeDropdownRow
{
    /// <summary>
    /// Identification of the type of entity involved in a transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyType33CodeDropdownRow(PartyType33Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
