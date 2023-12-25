﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EnergyQuantityUnitCode.  ISO2002 ID# _Wps_YQ3fEeWc7_0KPiuk6w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an energy quantity unit.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EnergyQuantityUnitCodeDropdownSource"/>.
/// Implements <seealso cref="IEnergyQuantityUnitCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Wps_YQ3fEeWc7_0KPiuk6w")]
public partial class EnergyQuantityUnitCodeDropdownRow : EnumMetadataItem<EnergyQuantityUnitCode>, IEnergyQuantityUnitCodeDropdownRow
{
    /// <summary>
    /// Specifies an energy quantity unit.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EnergyQuantityUnitCodeDropdownRow(EnergyQuantityUnitCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
