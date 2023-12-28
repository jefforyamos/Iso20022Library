﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderQuantityType2Code.  ISO2002 ID# _aRVD4Np-Ed-ak6NoX_4Aeg_-1133979180.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the order is placed, eg by quantity of units or by amount of money.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderQuantityType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aRVD4Np-Ed-ak6NoX_4Aeg_-1133979180")]
public partial class OrderQuantityType2CodeDropdownSource : EnumMetadataManager<OrderQuantityType2Code,IOrderQuantityType2CodeDropdownRow,OrderQuantityType2CodeDropdownRow>
{
    public OrderQuantityType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderQuantityType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}