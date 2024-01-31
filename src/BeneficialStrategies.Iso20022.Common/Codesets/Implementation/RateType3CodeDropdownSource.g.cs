﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RateType3Code.  ISO2002 ID# _ZZcZqNp-Ed-ak6NoX_4Aeg_-1424495957.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRateType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZZcZqNp-Ed-ak6NoX_4Aeg_-1424495957")]
public partial class RateType3CodeDropdownSource : EnumMetadataManager<RateType3Code,IRateType3CodeDropdownRow,RateType3CodeDropdownRow>
{
    public RateType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RateType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
