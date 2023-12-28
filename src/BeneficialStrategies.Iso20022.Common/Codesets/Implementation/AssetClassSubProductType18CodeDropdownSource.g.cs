﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType18Code.  ISO2002 ID# _G2wYQAnzEeWnS-yHF1QhNQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Plastic.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType18CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_G2wYQAnzEeWnS-yHF1QhNQ")]
public partial class AssetClassSubProductType18CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType18Code,IAssetClassSubProductType18CodeDropdownRow,AssetClassSubProductType18CodeDropdownRow>
{
    public AssetClassSubProductType18CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType18CodeDropdownRow(enumValue, memberInfo))
    {
    }
}