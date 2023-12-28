﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OptionParty3Code.  ISO2002 ID# _X6E8sDzzEeWLuazO9XdCTg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if a trade party is a taker or a maker.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OptionParty3CodeDropdownSource"/>.
/// Implements <seealso cref="IOptionParty3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_X6E8sDzzEeWLuazO9XdCTg")]
public partial class OptionParty3CodeDropdownRow : EnumMetadataItem<OptionParty3Code>, IOptionParty3CodeDropdownRow
{
    /// <summary>
    /// Specifies if a trade party is a taker or a maker.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OptionParty3CodeDropdownRow(OptionParty3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}