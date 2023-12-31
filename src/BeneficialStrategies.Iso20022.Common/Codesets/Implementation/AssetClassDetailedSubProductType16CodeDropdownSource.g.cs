﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassDetailedSubProductType16Code.  ISO2002 ID# _StIuQBYHEeejf-cbr8l5qw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Sub product code list for commodity derivatives.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassDetailedSubProductType16CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_StIuQBYHEeejf-cbr8l5qw")]
public partial class AssetClassDetailedSubProductType16CodeDropdownSource : EnumMetadataManager<AssetClassDetailedSubProductType16Code,IAssetClassDetailedSubProductType16CodeDropdownRow,AssetClassDetailedSubProductType16CodeDropdownRow>
{
    public AssetClassDetailedSubProductType16CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassDetailedSubProductType16CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
