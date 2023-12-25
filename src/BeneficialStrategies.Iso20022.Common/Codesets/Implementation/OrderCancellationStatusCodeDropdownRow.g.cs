﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OrderCancellationStatusCode.  ISO2002 ID# _aQk189p-Ed-ak6NoX_4Aeg_85357733.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of the order cancellation request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OrderCancellationStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IOrderCancellationStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aQk189p-Ed-ak6NoX_4Aeg_85357733")]
public partial class OrderCancellationStatusCodeDropdownRow : EnumMetadataItem<OrderCancellationStatusCode>, IOrderCancellationStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the current status of the order cancellation request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OrderCancellationStatusCodeDropdownRow(OrderCancellationStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
