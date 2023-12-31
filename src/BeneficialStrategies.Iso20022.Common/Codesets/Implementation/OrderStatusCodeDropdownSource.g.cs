﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderStatusCode.  ISO2002 ID# _aSXltNp-Ed-ak6NoX_4Aeg_336257668.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of the order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aSXltNp-Ed-ak6NoX_4Aeg_336257668")]
public partial class OrderStatusCodeDropdownSource : EnumMetadataManager<OrderStatusCode,IOrderStatusCodeDropdownRow,OrderStatusCodeDropdownRow>
{
    public OrderStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
