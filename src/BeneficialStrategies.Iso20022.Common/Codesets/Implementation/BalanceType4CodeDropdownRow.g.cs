﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceType4Code.  ISO2002 ID# _Vnvpptp-Ed-ak6NoX_4Aeg_-890461341.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceType4CodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceType4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vnvpptp-Ed-ak6NoX_4Aeg_-890461341")]
public partial class BalanceType4CodeDropdownRow : EnumMetadataItem<BalanceType4Code>, IBalanceType4CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the balance, eg, opening balance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceType4CodeDropdownRow(BalanceType4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
