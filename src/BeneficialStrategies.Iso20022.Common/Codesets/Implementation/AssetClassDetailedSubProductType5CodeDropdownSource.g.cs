﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassDetailedSubProductType5Code.  ISO2002 ID# _76AdsA2eEeW72qLtWESimw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Electricity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassDetailedSubProductType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_76AdsA2eEeW72qLtWESimw")]
public partial class AssetClassDetailedSubProductType5CodeDropdownSource : EnumMetadataManager<AssetClassDetailedSubProductType5Code,IAssetClassDetailedSubProductType5CodeDropdownRow,AssetClassDetailedSubProductType5CodeDropdownRow>
{
    public AssetClassDetailedSubProductType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassDetailedSubProductType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}