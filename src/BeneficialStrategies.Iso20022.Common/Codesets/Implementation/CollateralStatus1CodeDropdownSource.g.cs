﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralStatus1Code.  ISO2002 ID# _HlWPQMUcEeiF-qqyf1JQhg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message as a code
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_HlWPQMUcEeiF-qqyf1JQhg")]
public partial class CollateralStatus1CodeDropdownSource : EnumMetadataManager<CollateralStatus1Code,ICollateralStatus1CodeDropdownRow,CollateralStatus1CodeDropdownRow>
{
    public CollateralStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
