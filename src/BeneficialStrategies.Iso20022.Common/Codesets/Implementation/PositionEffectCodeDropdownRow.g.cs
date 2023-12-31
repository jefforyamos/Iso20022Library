﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PositionEffectCode.  ISO2002 ID# _aHfLYtp-Ed-ak6NoX_4Aeg_336257728.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the resulting position after a trade should be an opening position or closing position.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PositionEffectCodeDropdownSource"/>.
/// Implements <seealso cref="IPositionEffectCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aHfLYtp-Ed-ak6NoX_4Aeg_336257728")]
public partial class PositionEffectCodeDropdownRow : EnumMetadataItem<PositionEffectCode>, IPositionEffectCodeDropdownRow
{
    /// <summary>
    /// Indicates whether the resulting position after a trade should be an opening position or closing position.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PositionEffectCodeDropdownRow(PositionEffectCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
