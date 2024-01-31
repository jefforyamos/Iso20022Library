﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductEnvironmentalType1Code.  ISO2002 ID# _YuxOQM5AEeSc85GUbgBycw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list for environmental related derivative contracts.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductEnvironmentalType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YuxOQM5AEeSc85GUbgBycw")]
public partial class AssetClassSubProductEnvironmentalType1CodeDropdownSource : EnumMetadataManager<AssetClassSubProductEnvironmentalType1Code,IAssetClassSubProductEnvironmentalType1CodeDropdownRow,AssetClassSubProductEnvironmentalType1CodeDropdownRow>
{
    public AssetClassSubProductEnvironmentalType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductEnvironmentalType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
