﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderConfirmationStatus1Code.  ISO2002 ID# _aQ4X8Np-Ed-ak6NoX_4Aeg_-2026694302.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of an order confirmation or of an order confirmation amendment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderConfirmationStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aQ4X8Np-Ed-ak6NoX_4Aeg_-2026694302")]
public partial class OrderConfirmationStatus1CodeDropdownSource : EnumMetadataManager<OrderConfirmationStatus1Code,IOrderConfirmationStatus1CodeDropdownRow,OrderConfirmationStatus1CodeDropdownRow>
{
    public OrderConfirmationStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderConfirmationStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
