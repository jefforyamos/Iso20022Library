﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassTransactionType1Code.  ISO2002 ID# _Sv15QNDTEeSv_Pll20DdbA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code list of transaction type as specified by the trading venue.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassTransactionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Sv15QNDTEeSv_Pll20DdbA")]
public partial class AssetClassTransactionType1CodeDropdownSource : EnumMetadataManager<AssetClassTransactionType1Code,IAssetClassTransactionType1CodeDropdownRow,AssetClassTransactionType1CodeDropdownRow>
{
    public AssetClassTransactionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassTransactionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
