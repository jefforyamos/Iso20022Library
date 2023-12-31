﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DeliveryTypeCode.  ISO2002 ID# _azv0c9p-Ed-ak6NoX_4Aeg_-799855242.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDeliveryTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_azv0c9p-Ed-ak6NoX_4Aeg_-799855242")]
public partial class DeliveryTypeCodeDropdownSource : EnumMetadataManager<DeliveryTypeCode,IDeliveryTypeCodeDropdownRow,DeliveryTypeCodeDropdownRow>
{
    public DeliveryTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DeliveryTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
