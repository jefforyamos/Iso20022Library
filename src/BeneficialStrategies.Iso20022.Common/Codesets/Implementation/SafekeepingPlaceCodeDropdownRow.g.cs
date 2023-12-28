﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SafekeepingPlaceCode.  ISO2002 ID# _Y-xP0Np-Ed-ak6NoX_4Aeg_-664604106.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of place of safekeeping.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SafekeepingPlaceCodeDropdownSource"/>.
/// Implements <seealso cref="ISafekeepingPlaceCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y-xP0Np-Ed-ak6NoX_4Aeg_-664604106")]
public partial class SafekeepingPlaceCodeDropdownRow : EnumMetadataItem<SafekeepingPlaceCode>, ISafekeepingPlaceCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of place of safekeeping.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SafekeepingPlaceCodeDropdownRow(SafekeepingPlaceCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}