﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonFinancialResponseRiskCode.  ISO2002 ID# _qrdJwC_vEeugIJ3Gvoevmg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of risk management answer from an Acquirer (or its IntermediaryAgent) to a POI through a NonFinancialResponse. 
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonFinancialResponseRiskCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qrdJwC_vEeugIJ3Gvoevmg")]
public partial class NonFinancialResponseRiskCodeDropdownSource : EnumMetadataManager<NonFinancialResponseRiskCode,INonFinancialResponseRiskCodeDropdownRow,NonFinancialResponseRiskCodeDropdownRow>
{
    public NonFinancialResponseRiskCodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonFinancialResponseRiskCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
