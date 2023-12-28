﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeConfirmationStatusCode.  ISO2002 ID# _Rmmu4AKDEeS2H9l84F_isg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the status of the confirmation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeConfirmationStatusCodeDropdownSource"/>.
/// Implements <seealso cref="ITradeConfirmationStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Rmmu4AKDEeS2H9l84F_isg")]
public partial class TradeConfirmationStatusCodeDropdownRow : EnumMetadataItem<TradeConfirmationStatusCode>, ITradeConfirmationStatusCodeDropdownRow
{
    /// <summary>
    /// Identifies the status of the confirmation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeConfirmationStatusCodeDropdownRow(TradeConfirmationStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}