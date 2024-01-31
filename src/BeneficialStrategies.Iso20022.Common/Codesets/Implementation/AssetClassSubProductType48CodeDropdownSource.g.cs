﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType48Code.  ISO2002 ID# _nBb6IPwhEeW4Wthd0Ze_kA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product types for specific asset classes.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType48CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nBb6IPwhEeW4Wthd0Ze_kA")]
public partial class AssetClassSubProductType48CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType48Code,IAssetClassSubProductType48CodeDropdownRow,AssetClassSubProductType48CodeDropdownRow>
{
    public AssetClassSubProductType48CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType48CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
