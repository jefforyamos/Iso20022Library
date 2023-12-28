﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductFreight1Code.  ISO2002 ID# _kHVf0NDvEeS8V88MH4oPOQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code list for freight related derivative contracts.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductFreight1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kHVf0NDvEeS8V88MH4oPOQ")]
public partial class AssetClassSubProductFreight1CodeDropdownSource : EnumMetadataManager<AssetClassSubProductFreight1Code,IAssetClassSubProductFreight1CodeDropdownRow,AssetClassSubProductFreight1CodeDropdownRow>
{
    public AssetClassSubProductFreight1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductFreight1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
