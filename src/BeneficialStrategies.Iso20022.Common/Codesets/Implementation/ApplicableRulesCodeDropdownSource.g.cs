﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ApplicableRulesCode.  ISO2002 ID# _8kBGkFNeEeijdq8ilaxyOA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies applicable rules.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IApplicableRulesCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8kBGkFNeEeijdq8ilaxyOA")]
public partial class ApplicableRulesCodeDropdownSource : EnumMetadataManager<ApplicableRulesCode,IApplicableRulesCodeDropdownRow,ApplicableRulesCodeDropdownRow>
{
    public ApplicableRulesCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ApplicableRulesCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
