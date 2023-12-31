﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralSubstitutionSequenceCode.  ISO2002 ID# _YcDkUdp-Ed-ak6NoX_4Aeg_406031234.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the collateral substitution request is new or updated.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralSubstitutionSequenceCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcDkUdp-Ed-ak6NoX_4Aeg_406031234")]
public partial class CollateralSubstitutionSequenceCodeDropdownSource : EnumMetadataManager<CollateralSubstitutionSequenceCode,ICollateralSubstitutionSequenceCodeDropdownRow,CollateralSubstitutionSequenceCodeDropdownRow>
{
    public CollateralSubstitutionSequenceCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralSubstitutionSequenceCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
