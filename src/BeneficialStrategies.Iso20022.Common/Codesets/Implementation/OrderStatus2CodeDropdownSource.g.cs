﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderStatus2Code.  ISO2002 ID# _Veg1Jtp-Ed-ak6NoX_4Aeg_-352988908.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Veg1Jtp-Ed-ak6NoX_4Aeg_-352988908")]
public partial class OrderStatus2CodeDropdownSource : EnumMetadataManager<OrderStatus2Code,IOrderStatus2CodeDropdownRow,OrderStatus2CodeDropdownRow>
{
    public OrderStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
