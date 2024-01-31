﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OrderStatusCode.  ISO2002 ID# _aSXltNp-Ed-ak6NoX_4Aeg_336257668.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OrderStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IOrderStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aSXltNp-Ed-ak6NoX_4Aeg_336257668")]
public partial class OrderStatusCodeDropdownRow : EnumMetadataItem<OrderStatusCode>, IOrderStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the current status of the order.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OrderStatusCodeDropdownRow(OrderStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
