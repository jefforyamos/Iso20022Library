﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralPurpose1Code.  ISO2002 ID# _YZXctdp-Ed-ak6NoX_4Aeg_527391185.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the collateral has been posted against the variation margin or the segregated independent amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralPurpose1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YZXctdp-Ed-ak6NoX_4Aeg_527391185")]
public partial class CollateralPurpose1CodeDropdownSource : EnumMetadataManager<CollateralPurpose1Code,ICollateralPurpose1CodeDropdownRow,CollateralPurpose1CodeDropdownRow>
{
    public CollateralPurpose1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralPurpose1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
