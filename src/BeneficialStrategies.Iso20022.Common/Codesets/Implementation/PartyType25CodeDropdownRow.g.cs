﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyType25Code.  ISO2002 ID# _bs2o4XbLEeef9c2nwgY9Xw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of entity submitting a card fraud report.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyType25CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyType25CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bs2o4XbLEeef9c2nwgY9Xw")]
public partial class PartyType25CodeDropdownRow : EnumMetadataItem<PartyType25Code>, IPartyType25CodeDropdownRow
{
    /// <summary>
    /// Type of entity submitting a card fraud report.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyType25CodeDropdownRow(PartyType25Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
