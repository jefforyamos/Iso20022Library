﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType27Code.  ISO2002 ID# _omSLIVrKEeWN79Bl6BUd3g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Light Ends.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType27CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_omSLIVrKEeWN79Bl6BUd3g")]
public partial class AssetClassSubProductType27CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType27Code,IAssetClassSubProductType27CodeDropdownRow,AssetClassSubProductType27CodeDropdownRow>
{
    public AssetClassSubProductType27CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType27CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
