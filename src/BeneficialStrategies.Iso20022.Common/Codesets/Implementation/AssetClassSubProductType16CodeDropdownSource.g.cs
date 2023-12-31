﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType16Code.  ISO2002 ID# _FvfOMAnzEeWnS-yHF1QhNQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Precious Metal.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType16CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_FvfOMAnzEeWnS-yHF1QhNQ")]
public partial class AssetClassSubProductType16CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType16Code,IAssetClassSubProductType16CodeDropdownRow,AssetClassSubProductType16CodeDropdownRow>
{
    public AssetClassSubProductType16CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType16CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
