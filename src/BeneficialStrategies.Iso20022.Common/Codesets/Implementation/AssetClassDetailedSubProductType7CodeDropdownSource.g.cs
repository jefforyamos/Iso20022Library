﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassDetailedSubProductType7Code.  ISO2002 ID# __BXQMA2eEeW72qLtWESimw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Oil.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassDetailedSubProductType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__BXQMA2eEeW72qLtWESimw")]
public partial class AssetClassDetailedSubProductType7CodeDropdownSource : EnumMetadataManager<AssetClassDetailedSubProductType7Code,IAssetClassDetailedSubProductType7CodeDropdownRow,AssetClassDetailedSubProductType7CodeDropdownRow>
{
    public AssetClassDetailedSubProductType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassDetailedSubProductType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
