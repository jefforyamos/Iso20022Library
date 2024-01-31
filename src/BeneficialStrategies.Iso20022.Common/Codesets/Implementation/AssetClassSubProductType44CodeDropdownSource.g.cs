﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType44Code.  ISO2002 ID# _vdR-sVr3EeWN79Bl6BUd3g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Urea and Ammonium Nitrate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType44CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vdR-sVr3EeWN79Bl6BUd3g")]
public partial class AssetClassSubProductType44CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType44Code,IAssetClassSubProductType44CodeDropdownRow,AssetClassSubProductType44CodeDropdownRow>
{
    public AssetClassSubProductType44CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType44CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
