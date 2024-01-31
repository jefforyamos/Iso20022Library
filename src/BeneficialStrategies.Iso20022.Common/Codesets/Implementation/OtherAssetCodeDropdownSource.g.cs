﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OtherAssetCode.  ISO2002 ID# _deqTgEyMEeiepssxrmRw1A.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of asset.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOtherAssetCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_deqTgEyMEeiepssxrmRw1A")]
public partial class OtherAssetCodeDropdownSource : EnumMetadataManager<OtherAssetCode,IOtherAssetCodeDropdownRow,OtherAssetCodeDropdownRow>
{
    public OtherAssetCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OtherAssetCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
