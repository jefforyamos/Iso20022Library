﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FinancialAssetTypeCategoryCode.  ISO2002 ID# _m9ZG0PNBEeCuA5Tr22BnwA_-207567627.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Categorization of financial asset type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FinancialAssetTypeCategoryCodeDropdownSource"/>.
/// Implements <seealso cref="IFinancialAssetTypeCategoryCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_m9ZG0PNBEeCuA5Tr22BnwA_-207567627")]
public partial class FinancialAssetTypeCategoryCodeDropdownRow : EnumMetadataItem<FinancialAssetTypeCategoryCode>, IFinancialAssetTypeCategoryCodeDropdownRow
{
    /// <summary>
    /// Categorization of financial asset type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FinancialAssetTypeCategoryCodeDropdownRow(FinancialAssetTypeCategoryCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
