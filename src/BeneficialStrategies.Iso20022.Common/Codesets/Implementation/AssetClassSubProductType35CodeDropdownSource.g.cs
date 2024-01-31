﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType35Code.  ISO2002 ID# _ml0BAVryEeWN79Bl6BUd3g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Containerboard.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType35CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ml0BAVryEeWN79Bl6BUd3g")]
public partial class AssetClassSubProductType35CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType35Code,IAssetClassSubProductType35CodeDropdownRow,AssetClassSubProductType35CodeDropdownRow>
{
    public AssetClassSubProductType35CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType35CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
