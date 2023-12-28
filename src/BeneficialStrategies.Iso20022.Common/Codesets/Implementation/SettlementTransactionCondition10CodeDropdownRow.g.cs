﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementTransactionCondition10Code.  ISO2002 ID# _T_gNcGaIEeWZev0W8F756g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementTransactionCondition10CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementTransactionCondition10CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_T_gNcGaIEeWZev0W8F756g")]
public partial class SettlementTransactionCondition10CodeDropdownRow : EnumMetadataItem<SettlementTransactionCondition10Code>, ISettlementTransactionCondition10CodeDropdownRow
{
    /// <summary>
    /// Specifies the conditions under which the order/trade is to be settled.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementTransactionCondition10CodeDropdownRow(SettlementTransactionCondition10Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}