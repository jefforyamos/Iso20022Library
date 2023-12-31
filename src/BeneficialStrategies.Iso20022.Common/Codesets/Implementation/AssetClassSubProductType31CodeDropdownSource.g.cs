﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType31Code.  ISO2002 ID# _Mjf7MVrdEeWN79Bl6BUd3g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Dry Freight.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType31CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Mjf7MVrdEeWN79Bl6BUd3g")]
public partial class AssetClassSubProductType31CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType31Code,IAssetClassSubProductType31CodeDropdownRow,AssetClassSubProductType31CodeDropdownRow>
{
    public AssetClassSubProductType31CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType31CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
