﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementTransactionCondition6Code.  ISO2002 ID# _-eXJweEAEd-udr336SN7mQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementTransactionCondition6CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementTransactionCondition6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-eXJweEAEd-udr336SN7mQ")]
public partial class SettlementTransactionCondition6CodeDropdownRow : EnumMetadataItem<SettlementTransactionCondition6Code>, ISettlementTransactionCondition6CodeDropdownRow
{
    /// <summary>
    /// Specifies the conditions under which the order/trade is to be settled.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementTransactionCondition6CodeDropdownRow(SettlementTransactionCondition6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}