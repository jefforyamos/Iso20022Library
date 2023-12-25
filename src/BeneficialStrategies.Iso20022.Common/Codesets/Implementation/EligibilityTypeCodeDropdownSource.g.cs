﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EligibilityTypeCode.  ISO2002 ID# _jBmr4e5NEeCisYr99QEiWA_-1187231304.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of eligibility.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEligibilityTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jBmr4e5NEeCisYr99QEiWA_-1187231304")]
public partial class EligibilityTypeCodeDropdownSource : EnumMetadataManager<EligibilityTypeCode,IEligibilityTypeCodeDropdownRow,EligibilityTypeCodeDropdownRow>
{
    public EligibilityTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EligibilityTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
