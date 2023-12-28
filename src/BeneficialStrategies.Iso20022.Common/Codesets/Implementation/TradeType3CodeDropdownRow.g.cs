﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeType3Code.  ISO2002 ID# __yXpJdojEeC60axPepSq7g_-56889578.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of executed order.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeType3CodeDropdownSource"/>.
/// Implements <seealso cref="ITradeType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__yXpJdojEeC60axPepSq7g_-56889578")]
public partial class TradeType3CodeDropdownRow : EnumMetadataItem<TradeType3Code>, ITradeType3CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of executed order.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeType3CodeDropdownRow(TradeType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}