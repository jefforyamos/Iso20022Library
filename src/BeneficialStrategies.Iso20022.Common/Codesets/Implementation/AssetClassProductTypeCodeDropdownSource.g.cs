﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassProductTypeCode.  ISO2002 ID# _bI7sQQnYEeWa7rBfPECYsw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassProductTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bI7sQQnYEeWa7rBfPECYsw")]
public partial class AssetClassProductTypeCodeDropdownSource : EnumMetadataManager<AssetClassProductTypeCode,IAssetClassProductTypeCodeDropdownRow,AssetClassProductTypeCodeDropdownRow>
{
    public AssetClassProductTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassProductTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
