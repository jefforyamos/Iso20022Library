﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderRestrictions1Code.  ISO2002 ID# _aReN09p-Ed-ak6NoX_4Aeg_-414935483.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the classification and thus the restrictions associated with an order (for regulatory purposes).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderRestrictions1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aReN09p-Ed-ak6NoX_4Aeg_-414935483")]
public partial class OrderRestrictions1CodeDropdownSource : EnumMetadataManager<OrderRestrictions1Code,IOrderRestrictions1CodeDropdownRow,OrderRestrictions1CodeDropdownRow>
{
    public OrderRestrictions1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderRestrictions1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
