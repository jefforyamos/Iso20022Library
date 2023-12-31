﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralStatusCode.  ISO2002 ID# _itEK0MUZEeiF-qqyf1JQhg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_itEK0MUZEeiF-qqyf1JQhg")]
public partial class CollateralStatusCodeDropdownSource : EnumMetadataManager<CollateralStatusCode,ICollateralStatusCodeDropdownRow,CollateralStatusCodeDropdownRow>
{
    public CollateralStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
