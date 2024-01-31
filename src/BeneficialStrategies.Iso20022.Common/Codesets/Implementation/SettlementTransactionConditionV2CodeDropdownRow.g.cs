﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementTransactionConditionV2Code.  ISO2002 ID# __uywsNojEeC60axPepSq7g_-615097257.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementTransactionConditionV2CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementTransactionConditionV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__uywsNojEeC60axPepSq7g_-615097257")]
public partial class SettlementTransactionConditionV2CodeDropdownRow : EnumMetadataItem<SettlementTransactionConditionV2Code>, ISettlementTransactionConditionV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the conditions under which the order/trade is to be settled.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementTransactionConditionV2CodeDropdownRow(SettlementTransactionConditionV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
