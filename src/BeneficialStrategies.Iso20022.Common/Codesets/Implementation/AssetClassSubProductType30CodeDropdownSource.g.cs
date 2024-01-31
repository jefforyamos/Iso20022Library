﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType30Code.  ISO2002 ID# _ftdB4VrNEeWN79Bl6BUd3g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Weather.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType30CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ftdB4VrNEeWN79Bl6BUd3g")]
public partial class AssetClassSubProductType30CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType30Code,IAssetClassSubProductType30CodeDropdownRow,AssetClassSubProductType30CodeDropdownRow>
{
    public AssetClassSubProductType30CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType30CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
