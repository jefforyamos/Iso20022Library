﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderQuantityType1Code.  ISO2002 ID# _ViiZgdp-Ed-ak6NoX_4Aeg_-392071140.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the order is placed, eg by quantity of units or by amount of money.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderQuantityType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ViiZgdp-Ed-ak6NoX_4Aeg_-392071140")]
public partial class OrderQuantityType1CodeDropdownSource : EnumMetadataManager<OrderQuantityType1Code,IOrderQuantityType1CodeDropdownRow,OrderQuantityType1CodeDropdownRow>
{
    public OrderQuantityType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderQuantityType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
