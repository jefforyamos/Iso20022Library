﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType28Code.  ISO2002 ID# _sFQMYVrKEeWN79Bl6BUd3g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Renewable Energy.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType28CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sFQMYVrKEeWN79Bl6BUd3g")]
public partial class AssetClassSubProductType28CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType28Code,IAssetClassSubProductType28CodeDropdownRow,AssetClassSubProductType28CodeDropdownRow>
{
    public AssetClassSubProductType28CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType28CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
