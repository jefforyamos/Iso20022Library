﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RateValueType2Code.  ISO2002 ID# _ZaMAhdp-Ed-ak6NoX_4Aeg_-1008646416.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of a rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRateValueType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZaMAhdp-Ed-ak6NoX_4Aeg_-1008646416")]
public partial class RateValueType2CodeDropdownSource : EnumMetadataManager<RateValueType2Code,IRateValueType2CodeDropdownRow,RateValueType2CodeDropdownRow>
{
    public RateValueType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RateValueType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
