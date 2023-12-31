﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralRoleCode.  ISO2002 ID# _glgtoCDCEeaned5xL18mUQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralRoleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_glgtoCDCEeaned5xL18mUQ")]
public partial class CollateralRoleCodeDropdownSource : EnumMetadataManager<CollateralRoleCode,ICollateralRoleCodeDropdownRow,CollateralRoleCodeDropdownRow>
{
    public CollateralRoleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralRoleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
