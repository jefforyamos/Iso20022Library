﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductTypeCode.  ISO2002 ID# _KADecc49EeSc85GUbgBycw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product types for specific asset classes.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KADecc49EeSc85GUbgBycw")]
public partial class AssetClassSubProductTypeCodeDropdownSource : EnumMetadataManager<AssetClassSubProductTypeCode,IAssetClassSubProductTypeCodeDropdownRow,AssetClassSubProductTypeCodeDropdownRow>
{
    public AssetClassSubProductTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
