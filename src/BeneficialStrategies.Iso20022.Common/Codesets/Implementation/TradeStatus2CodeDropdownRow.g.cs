﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeStatus2Code.  ISO2002 ID# _Vp_FV9p-Ed-ak6NoX_4Aeg_1212704740.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="ITradeStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vp_FV9p-Ed-ak6NoX_4Aeg_1212704740")]
public partial class TradeStatus2CodeDropdownRow : EnumMetadataItem<TradeStatus2Code>, ITradeStatus2CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a trade in a central matching and settlement system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeStatus2CodeDropdownRow(TradeStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
