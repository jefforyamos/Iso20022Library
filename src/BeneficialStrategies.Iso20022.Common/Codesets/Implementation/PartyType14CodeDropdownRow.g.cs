﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyType14Code.  ISO2002 ID# _yq2IkY0YEeWRYffwL7E13A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of entity involved in a transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyType14CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyType14CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yq2IkY0YEeWRYffwL7E13A")]
public partial class PartyType14CodeDropdownRow : EnumMetadataItem<PartyType14Code>, IPartyType14CodeDropdownRow
{
    /// <summary>
    /// Identification of the type of entity involved in a transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyType14CodeDropdownRow(PartyType14Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
