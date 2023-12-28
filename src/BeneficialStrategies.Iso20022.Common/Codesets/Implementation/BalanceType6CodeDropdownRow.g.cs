﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceType6Code.  ISO2002 ID# _bY2sodp-Ed-ak6NoX_4Aeg_1729062852.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceType6CodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceType6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bY2sodp-Ed-ak6NoX_4Aeg_1729062852")]
public partial class BalanceType6CodeDropdownRow : EnumMetadataItem<BalanceType6Code>, IBalanceType6CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the balance, eg, opening balance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceType6CodeDropdownRow(BalanceType6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
