﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DeliveryReturnCode.  ISO2002 ID# _azc5g9p-Ed-ak6NoX_4Aeg_-2045082222.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of delivery return.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDeliveryReturnCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_azc5g9p-Ed-ak6NoX_4Aeg_-2045082222")]
public partial class DeliveryReturnCodeDropdownSource : EnumMetadataManager<DeliveryReturnCode,IDeliveryReturnCodeDropdownRow,DeliveryReturnCodeDropdownRow>
{
    public DeliveryReturnCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DeliveryReturnCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
