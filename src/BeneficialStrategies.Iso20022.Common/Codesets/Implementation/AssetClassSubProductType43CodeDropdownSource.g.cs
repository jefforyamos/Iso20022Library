﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType43Code.  ISO2002 ID# _o_RZcVr3EeWN79Bl6BUd3g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Urea.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType43CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_o_RZcVr3EeWN79Bl6BUd3g")]
public partial class AssetClassSubProductType43CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType43Code,IAssetClassSubProductType43CodeDropdownRow,AssetClassSubProductType43CodeDropdownRow>
{
    public AssetClassSubProductType43CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType43CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
