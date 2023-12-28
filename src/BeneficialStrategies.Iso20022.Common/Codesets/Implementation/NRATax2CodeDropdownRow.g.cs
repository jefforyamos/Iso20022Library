﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for NRATax2Code.  ISO2002 ID# _DwDwj6bHEeSDHtMWsSZVOg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Non resident alien U.S. tax codes.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="NRATax2CodeDropdownSource"/>.
/// Implements <seealso cref="INRATax2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DwDwj6bHEeSDHtMWsSZVOg")]
public partial class NRATax2CodeDropdownRow : EnumMetadataItem<NRATax2Code>, INRATax2CodeDropdownRow
{
    /// <summary>
    /// Non resident alien U.S. tax codes.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public NRATax2CodeDropdownRow(NRATax2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}