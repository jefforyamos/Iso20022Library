﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType3Code.  ISO2002 ID# _70F8EAnyEeWnS-yHF1QhNQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Olive Oil.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_70F8EAnyEeWnS-yHF1QhNQ")]
public partial class AssetClassSubProductType3CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType3Code,IAssetClassSubProductType3CodeDropdownRow,AssetClassSubProductType3CodeDropdownRow>
{
    public AssetClassSubProductType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
