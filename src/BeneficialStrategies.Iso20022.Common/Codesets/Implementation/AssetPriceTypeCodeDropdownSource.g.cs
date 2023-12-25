﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetPriceTypeCode.  ISO2002 ID# _EnANEBsTEeWhp-Wous5jzA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price for an asset.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetPriceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EnANEBsTEeWhp-Wous5jzA")]
public partial class AssetPriceTypeCodeDropdownSource : EnumMetadataManager<AssetPriceTypeCode,IAssetPriceTypeCodeDropdownRow,AssetPriceTypeCodeDropdownRow>
{
    public AssetPriceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetPriceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
