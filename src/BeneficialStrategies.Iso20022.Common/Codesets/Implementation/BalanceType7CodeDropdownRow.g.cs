﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceType7Code.  ISO2002 ID# _bZcihNp-Ed-ak6NoX_4Aeg_-1748590309.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceType7CodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bZcihNp-Ed-ak6NoX_4Aeg_-1748590309")]
public partial class BalanceType7CodeDropdownRow : EnumMetadataItem<BalanceType7Code>, IBalanceType7CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the balance, eg, opening balance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceType7CodeDropdownRow(BalanceType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
