﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceStatus1Code.  ISO2002 ID# _bkBa2Np-Ed-ak6NoX_4Aeg_1047073628.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the balance of transactions with a certain status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bkBa2Np-Ed-ak6NoX_4Aeg_1047073628")]
public partial class BalanceStatus1CodeDropdownRow : EnumMetadataItem<BalanceStatus1Code>, IBalanceStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the balance of transactions with a certain status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceStatus1CodeDropdownRow(BalanceStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
