﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceType14Code.  ISO2002 ID# _xzEMQFKTEeeFcfYfFkVztg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of balance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceType14CodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceType14CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xzEMQFKTEeeFcfYfFkVztg")]
public partial class BalanceType14CodeDropdownRow : EnumMetadataItem<BalanceType14Code>, IBalanceType14CodeDropdownRow
{
    /// <summary>
    /// Type of balance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceType14CodeDropdownRow(BalanceType14Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}