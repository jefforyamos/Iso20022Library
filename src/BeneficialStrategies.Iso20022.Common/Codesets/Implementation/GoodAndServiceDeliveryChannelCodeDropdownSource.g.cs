﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GoodAndServiceDeliveryChannelCode.  ISO2002 ID# _A9WDQD5GEeyHI64WSlzTlg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the good or service delivery channel.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGoodAndServiceDeliveryChannelCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_A9WDQD5GEeyHI64WSlzTlg")]
public partial class GoodAndServiceDeliveryChannelCodeDropdownSource : EnumMetadataManager<GoodAndServiceDeliveryChannelCode,IGoodAndServiceDeliveryChannelCodeDropdownRow,GoodAndServiceDeliveryChannelCodeDropdownRow>
{
    public GoodAndServiceDeliveryChannelCodeDropdownSource()
        : base( (enumValue, memberInfo) => new GoodAndServiceDeliveryChannelCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
