﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TriggerPriceTypeCode.  ISO2002 ID# _YwBCJdp-Ed-ak6NoX_4Aeg_781187809.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price that the trigger is compared to.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITriggerPriceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YwBCJdp-Ed-ak6NoX_4Aeg_781187809")]
public partial class TriggerPriceTypeCodeDropdownSource : EnumMetadataManager<TriggerPriceTypeCode,ITriggerPriceTypeCodeDropdownRow,TriggerPriceTypeCodeDropdownRow>
{
    public TriggerPriceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TriggerPriceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
