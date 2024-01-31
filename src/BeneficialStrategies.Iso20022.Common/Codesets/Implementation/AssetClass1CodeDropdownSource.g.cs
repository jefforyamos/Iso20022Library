﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClass1Code.  ISO2002 ID# _1rqYQjL3EeKU9IrkkToqcw_-716829742.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) defined asset class.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClass1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1rqYQjL3EeKU9IrkkToqcw_-716829742")]
public partial class AssetClass1CodeDropdownSource : EnumMetadataManager<AssetClass1Code,IAssetClass1CodeDropdownRow,AssetClass1CodeDropdownRow>
{
    public AssetClass1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClass1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
