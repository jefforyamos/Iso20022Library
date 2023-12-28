﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementTransactionCondition2Code.  ISO2002 ID# _ZNExktp-Ed-ak6NoX_4Aeg_-736534954.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementTransactionCondition2CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementTransactionCondition2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZNExktp-Ed-ak6NoX_4Aeg_-736534954")]
public partial class SettlementTransactionCondition2CodeDropdownRow : EnumMetadataItem<SettlementTransactionCondition2Code>, ISettlementTransactionCondition2CodeDropdownRow
{
    /// <summary>
    /// Specifies the conditions under which the order/trade is to be settled.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementTransactionCondition2CodeDropdownRow(SettlementTransactionCondition2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}