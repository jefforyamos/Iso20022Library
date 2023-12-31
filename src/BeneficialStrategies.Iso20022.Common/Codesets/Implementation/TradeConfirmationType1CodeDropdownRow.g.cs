﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeConfirmationType1Code.  ISO2002 ID# _2EE7YA26EeWmAKKPnqYEVQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the contract was electronically confirmed or non-electronically confirmed.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeConfirmationType1CodeDropdownSource"/>.
/// Implements <seealso cref="ITradeConfirmationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2EE7YA26EeWmAKKPnqYEVQ")]
public partial class TradeConfirmationType1CodeDropdownRow : EnumMetadataItem<TradeConfirmationType1Code>, ITradeConfirmationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies whether the contract was electronically confirmed or non-electronically confirmed.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeConfirmationType1CodeDropdownRow(TradeConfirmationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
