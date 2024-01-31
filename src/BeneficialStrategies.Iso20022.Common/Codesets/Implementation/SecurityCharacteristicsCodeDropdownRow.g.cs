﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SecurityCharacteristicsCode.  ISO2002 ID# _X8tNUEqzEeenp6hmNprBHg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Security characteristics of the communication link between a cardholder and a card acceptor.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SecurityCharacteristicsCodeDropdownSource"/>.
/// Implements <seealso cref="ISecurityCharacteristicsCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_X8tNUEqzEeenp6hmNprBHg")]
public partial class SecurityCharacteristicsCodeDropdownRow : EnumMetadataItem<SecurityCharacteristicsCode>, ISecurityCharacteristicsCodeDropdownRow
{
    /// <summary>
    /// Security characteristics of the communication link between a cardholder and a card acceptor.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SecurityCharacteristicsCodeDropdownRow(SecurityCharacteristicsCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
