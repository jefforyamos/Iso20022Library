﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExPostCostCalculationBasisCode.  ISO2002 ID# _mUK7gJ9XEeqxTNfi5y7ywQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a basis for ex post calculations.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExPostCostCalculationBasisCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mUK7gJ9XEeqxTNfi5y7ywQ")]
public partial class ExPostCostCalculationBasisCodeDropdownSource : EnumMetadataManager<ExPostCostCalculationBasisCode,IExPostCostCalculationBasisCodeDropdownRow,ExPostCostCalculationBasisCodeDropdownRow>
{
    public ExPostCostCalculationBasisCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExPostCostCalculationBasisCodeDropdownRow(enumValue, memberInfo))
    {
    }
}