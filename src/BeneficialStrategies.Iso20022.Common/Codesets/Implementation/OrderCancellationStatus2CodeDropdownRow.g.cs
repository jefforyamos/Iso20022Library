﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OrderCancellationStatus2Code.  ISO2002 ID# _2Zfi8NcPEeaX5rvhR0a-OQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of the order cancellation request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OrderCancellationStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="IOrderCancellationStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2Zfi8NcPEeaX5rvhR0a-OQ")]
public partial class OrderCancellationStatus2CodeDropdownRow : EnumMetadataItem<OrderCancellationStatus2Code>, IOrderCancellationStatus2CodeDropdownRow
{
    /// <summary>
    /// Specifies the current status of the order cancellation request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OrderCancellationStatus2CodeDropdownRow(OrderCancellationStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}