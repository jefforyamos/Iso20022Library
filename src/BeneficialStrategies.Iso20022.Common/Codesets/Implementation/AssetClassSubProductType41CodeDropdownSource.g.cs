﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType41Code.  ISO2002 ID# _bK2AQVr3EeWN79Bl6BUd3g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Potash.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType41CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bK2AQVr3EeWN79Bl6BUd3g")]
public partial class AssetClassSubProductType41CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType41Code,IAssetClassSubProductType41CodeDropdownRow,AssetClassSubProductType41CodeDropdownRow>
{
    public AssetClassSubProductType41CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType41CodeDropdownRow(enumValue, memberInfo))
    {
    }
}