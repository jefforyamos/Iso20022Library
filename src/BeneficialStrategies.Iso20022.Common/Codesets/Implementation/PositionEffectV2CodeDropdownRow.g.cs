﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PositionEffectV2Code.  ISO2002 ID# __tJx8tojEeC60axPepSq7g_1840994325.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the resulting position after a trade should be an opening position or closing position.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PositionEffectV2CodeDropdownSource"/>.
/// Implements <seealso cref="IPositionEffectV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__tJx8tojEeC60axPepSq7g_1840994325")]
public partial class PositionEffectV2CodeDropdownRow : EnumMetadataItem<PositionEffectV2Code>, IPositionEffectV2CodeDropdownRow
{
    /// <summary>
    /// Indicates whether the resulting position after a trade should be an opening position or closing position.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PositionEffectV2CodeDropdownRow(PositionEffectV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
