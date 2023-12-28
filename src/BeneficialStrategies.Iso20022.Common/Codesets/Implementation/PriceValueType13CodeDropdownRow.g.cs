﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PriceValueType13Code.  ISO2002 ID# _K3qasA-zEeuE0Pnt-OcNOA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of price is unspecified.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PriceValueType13CodeDropdownSource"/>.
/// Implements <seealso cref="IPriceValueType13CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_K3qasA-zEeuE0Pnt-OcNOA")]
public partial class PriceValueType13CodeDropdownRow : EnumMetadataItem<PriceValueType13Code>, IPriceValueType13CodeDropdownRow
{
    /// <summary>
    /// Type of price is unspecified.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PriceValueType13CodeDropdownRow(PriceValueType13Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}