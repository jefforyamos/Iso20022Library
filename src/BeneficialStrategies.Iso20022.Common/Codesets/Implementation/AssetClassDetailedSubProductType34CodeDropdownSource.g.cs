﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassDetailedSubProductType34Code.  ISO2002 ID# _zzyMMbv6EeiLRYqS-r-R-A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Wet.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassDetailedSubProductType34CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zzyMMbv6EeiLRYqS-r-R-A")]
public partial class AssetClassDetailedSubProductType34CodeDropdownSource : EnumMetadataManager<AssetClassDetailedSubProductType34Code,IAssetClassDetailedSubProductType34CodeDropdownRow,AssetClassDetailedSubProductType34CodeDropdownRow>
{
    public AssetClassDetailedSubProductType34CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassDetailedSubProductType34CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
