﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralType3Code.  ISO2002 ID# __1WEodojEeC60axPepSq7g_534060743.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__1WEodojEeC60axPepSq7g_534060743")]
public partial class CollateralType3CodeDropdownSource : EnumMetadataManager<CollateralType3Code,ICollateralType3CodeDropdownRow,CollateralType3CodeDropdownRow>
{
    public CollateralType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
