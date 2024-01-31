﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PriceRateType3Code.  ISO2002 ID# _aI_AM9p-Ed-ak6NoX_4Aeg_2030331251.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPriceRateType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aI_AM9p-Ed-ak6NoX_4Aeg_2030331251")]
public partial class PriceRateType3CodeDropdownSource : EnumMetadataManager<PriceRateType3Code,IPriceRateType3CodeDropdownRow,PriceRateType3CodeDropdownRow>
{
    public PriceRateType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PriceRateType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
