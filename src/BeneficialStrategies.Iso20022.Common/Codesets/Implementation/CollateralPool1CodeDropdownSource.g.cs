﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralPool1Code.  ISO2002 ID# _A695wN7GEeSaBeqd_btViQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the collateral is a pool collateral or not.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralPool1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_A695wN7GEeSaBeqd_btViQ")]
public partial class CollateralPool1CodeDropdownSource : EnumMetadataManager<CollateralPool1Code,ICollateralPool1CodeDropdownRow,CollateralPool1CodeDropdownRow>
{
    public CollateralPool1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralPool1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
