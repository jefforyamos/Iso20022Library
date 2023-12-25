﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReceiveDeliveryCode.  ISO2002 ID# _Zafih9p-Ed-ak6NoX_4Aeg_448211310.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the settlement transaction is a delivery or receipt.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReceiveDeliveryCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zafih9p-Ed-ak6NoX_4Aeg_448211310")]
public partial class ReceiveDeliveryCodeDropdownSource : EnumMetadataManager<ReceiveDeliveryCode,IReceiveDeliveryCodeDropdownRow,ReceiveDeliveryCodeDropdownRow>
{
    public ReceiveDeliveryCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReceiveDeliveryCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
