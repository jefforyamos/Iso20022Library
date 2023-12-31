﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementTransactionCondition3Code.  ISO2002 ID# _ZNYTk9p-Ed-ak6NoX_4Aeg_-969430836.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementTransactionCondition3CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementTransactionCondition3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZNYTk9p-Ed-ak6NoX_4Aeg_-969430836")]
public partial class SettlementTransactionCondition3CodeDropdownRow : EnumMetadataItem<SettlementTransactionCondition3Code>, ISettlementTransactionCondition3CodeDropdownRow
{
    /// <summary>
    /// Specifies the conditions under which the order/trade is to be settled.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementTransactionCondition3CodeDropdownRow(SettlementTransactionCondition3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
