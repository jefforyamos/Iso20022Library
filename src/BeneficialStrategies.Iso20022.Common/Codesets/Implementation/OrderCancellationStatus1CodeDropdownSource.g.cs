﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderCancellationStatus1Code.  ISO2002 ID# _aQbsB9p-Ed-ak6NoX_4Aeg_-1213962080.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of the order cancellation request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderCancellationStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aQbsB9p-Ed-ak6NoX_4Aeg_-1213962080")]
public partial class OrderCancellationStatus1CodeDropdownSource : EnumMetadataManager<OrderCancellationStatus1Code,IOrderCancellationStatus1CodeDropdownRow,OrderCancellationStatus1CodeDropdownRow>
{
    public OrderCancellationStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderCancellationStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
