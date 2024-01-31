﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassProductType3Code.  ISO2002 ID# _VrcxEAnyEeWnS-yHF1QhNQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Environmental.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassProductType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VrcxEAnyEeWnS-yHF1QhNQ")]
public partial class AssetClassProductType3CodeDropdownSource : EnumMetadataManager<AssetClassProductType3Code,IAssetClassProductType3CodeDropdownRow,AssetClassProductType3CodeDropdownRow>
{
    public AssetClassProductType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassProductType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
