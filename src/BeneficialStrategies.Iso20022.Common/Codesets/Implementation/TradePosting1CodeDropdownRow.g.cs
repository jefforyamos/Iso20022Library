﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradePosting1Code.  ISO2002 ID# _-fsj16MOEeCojJW5vEuTEQ_-1075208421.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the trade is maintained as a separate individual position in the clearing account, or not.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradePosting1CodeDropdownSource"/>.
/// Implements <seealso cref="ITradePosting1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-fsj16MOEeCojJW5vEuTEQ_-1075208421")]
public partial class TradePosting1CodeDropdownRow : EnumMetadataItem<TradePosting1Code>, ITradePosting1CodeDropdownRow
{
    /// <summary>
    /// Specifies the trade is maintained as a separate individual position in the clearing account, or not.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradePosting1CodeDropdownRow(TradePosting1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
