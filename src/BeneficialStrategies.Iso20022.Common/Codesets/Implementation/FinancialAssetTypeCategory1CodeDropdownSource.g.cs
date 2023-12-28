﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FinancialAssetTypeCategory1Code.  ISO2002 ID# _m9i30fNBEeCuA5Tr22BnwA_99681721.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Categorization of financial asset type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFinancialAssetTypeCategory1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_m9i30fNBEeCuA5Tr22BnwA_99681721")]
public partial class FinancialAssetTypeCategory1CodeDropdownSource : EnumMetadataManager<FinancialAssetTypeCategory1Code,IFinancialAssetTypeCategory1CodeDropdownRow,FinancialAssetTypeCategory1CodeDropdownRow>
{
    public FinancialAssetTypeCategory1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FinancialAssetTypeCategory1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
