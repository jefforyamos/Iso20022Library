﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderQuantityType3Code.  ISO2002 ID# _aRVD49p-Ed-ak6NoX_4Aeg_-1276786595.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the order is placed, for example by quantity of units or by amount of money.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderQuantityType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aRVD49p-Ed-ak6NoX_4Aeg_-1276786595")]
public partial class OrderQuantityType3CodeDropdownSource : EnumMetadataManager<OrderQuantityType3Code,IOrderQuantityType3CodeDropdownRow,OrderQuantityType3CodeDropdownRow>
{
    public OrderQuantityType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderQuantityType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}