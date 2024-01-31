﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GoodAndServiceDeliverySchedule1Code.  ISO2002 ID# _UqvosD5LEeyHI64WSlzTlg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the good or service delivery schedule.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGoodAndServiceDeliverySchedule1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UqvosD5LEeyHI64WSlzTlg")]
public partial class GoodAndServiceDeliverySchedule1CodeDropdownSource : EnumMetadataManager<GoodAndServiceDeliverySchedule1Code,IGoodAndServiceDeliverySchedule1CodeDropdownRow,GoodAndServiceDeliverySchedule1CodeDropdownRow>
{
    public GoodAndServiceDeliverySchedule1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new GoodAndServiceDeliverySchedule1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
