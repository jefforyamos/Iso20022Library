﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DeliveryPlaceV2Code.  ISO2002 ID# _iSfctg1eEeu_4e16J8D_UA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the place of delivery.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDeliveryPlaceV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_iSfctg1eEeu_4e16J8D_UA")]
public partial class DeliveryPlaceV2CodeDropdownSource : EnumMetadataManager<DeliveryPlaceV2Code,IDeliveryPlaceV2CodeDropdownRow,DeliveryPlaceV2CodeDropdownRow>
{
    public DeliveryPlaceV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DeliveryPlaceV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}