﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderWaiverReasonCode.  ISO2002 ID# _ZwscBtp-Ed-ak6NoX_4Aeg_-2076610546.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies investment fund processes.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderWaiverReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZwscBtp-Ed-ak6NoX_4Aeg_-2076610546")]
public partial class OrderWaiverReasonCodeDropdownSource : EnumMetadataManager<OrderWaiverReasonCode,IOrderWaiverReasonCodeDropdownRow,OrderWaiverReasonCodeDropdownRow>
{
    public OrderWaiverReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderWaiverReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
