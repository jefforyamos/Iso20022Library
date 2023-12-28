﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralAccountType3Code.  ISO2002 ID# _-SycYFHPEeeqtLmveSCYmA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Classification of the requirement that collateral in the collateral account is covering.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralAccountType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-SycYFHPEeeqtLmveSCYmA")]
public partial class CollateralAccountType3CodeDropdownSource : EnumMetadataManager<CollateralAccountType3Code,ICollateralAccountType3CodeDropdownRow,CollateralAccountType3CodeDropdownRow>
{
    public CollateralAccountType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralAccountType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
