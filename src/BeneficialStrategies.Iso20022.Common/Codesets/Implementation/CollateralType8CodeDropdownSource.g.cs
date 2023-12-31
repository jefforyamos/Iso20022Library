﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralType8Code.  ISO2002 ID# _Zs12wALwEeutW5-TpeYJhA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of collateral.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zs12wALwEeutW5-TpeYJhA")]
public partial class CollateralType8CodeDropdownSource : EnumMetadataManager<CollateralType8Code,ICollateralType8CodeDropdownRow,CollateralType8CodeDropdownRow>
{
    public CollateralType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
