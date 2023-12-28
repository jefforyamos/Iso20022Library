﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyIdentificationType7Code.  ISO2002 ID# _G1XwkCCOEeWJd9HF2tO7BA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an alternative identification of a party, for example, national registration identification number, passport number, tax identification number.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyIdentificationType7CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyIdentificationType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_G1XwkCCOEeWJd9HF2tO7BA")]
public partial class PartyIdentificationType7CodeDropdownRow : EnumMetadataItem<PartyIdentificationType7Code>, IPartyIdentificationType7CodeDropdownRow
{
    /// <summary>
    /// Specifies an alternative identification of a party, for example, national registration identification number, passport number, tax identification number.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyIdentificationType7CodeDropdownRow(PartyIdentificationType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}