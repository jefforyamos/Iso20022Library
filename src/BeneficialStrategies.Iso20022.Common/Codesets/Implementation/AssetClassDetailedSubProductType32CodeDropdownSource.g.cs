﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassDetailedSubProductType32Code.  ISO2002 ID# _PXjKkbv4EeiLRYqS-r-R-A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Oil.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassDetailedSubProductType32CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_PXjKkbv4EeiLRYqS-r-R-A")]
public partial class AssetClassDetailedSubProductType32CodeDropdownSource : EnumMetadataManager<AssetClassDetailedSubProductType32Code,IAssetClassDetailedSubProductType32CodeDropdownRow,AssetClassDetailedSubProductType32CodeDropdownRow>
{
    public AssetClassDetailedSubProductType32CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassDetailedSubProductType32CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
