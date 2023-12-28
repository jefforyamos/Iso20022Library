﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceType15Code.  ISO2002 ID# _r56MocSqEeuBjv5G5kw00g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of balance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceType15CodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceType15CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_r56MocSqEeuBjv5G5kw00g")]
public partial class BalanceType15CodeDropdownRow : EnumMetadataItem<BalanceType15Code>, IBalanceType15CodeDropdownRow
{
    /// <summary>
    /// Type of balance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceType15CodeDropdownRow(BalanceType15Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}