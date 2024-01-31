﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType7Code.  ISO2002 ID# _-yNTAAnyEeWnS-yHF1QhNQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Natural Gas.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-yNTAAnyEeWnS-yHF1QhNQ")]
public partial class AssetClassSubProductType7CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType7Code,IAssetClassSubProductType7CodeDropdownRow,AssetClassSubProductType7CodeDropdownRow>
{
    public AssetClassSubProductType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
