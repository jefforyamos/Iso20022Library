﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MoneyMarketTransactionTypeCode.  ISO2002 ID# _hxCgQJfrEeSfnc-VXAEapg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction type used in the money market statistical reporting.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MoneyMarketTransactionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IMoneyMarketTransactionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hxCgQJfrEeSfnc-VXAEapg")]
public partial class MoneyMarketTransactionTypeCodeDropdownRow : EnumMetadataItem<MoneyMarketTransactionTypeCode>, IMoneyMarketTransactionTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the transaction type used in the money market statistical reporting.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MoneyMarketTransactionTypeCodeDropdownRow(MoneyMarketTransactionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
