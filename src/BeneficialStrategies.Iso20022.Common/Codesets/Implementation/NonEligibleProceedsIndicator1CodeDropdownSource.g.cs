﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonEligibleProceedsIndicator1Code.  ISO2002 ID# _aNcpdtp-Ed-ak6NoX_4Aeg_1631723636.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies information regarding the non eligibility of the outturn resources.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonEligibleProceedsIndicator1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aNcpdtp-Ed-ak6NoX_4Aeg_1631723636")]
public partial class NonEligibleProceedsIndicator1CodeDropdownSource : EnumMetadataManager<NonEligibleProceedsIndicator1Code,INonEligibleProceedsIndicator1CodeDropdownRow,NonEligibleProceedsIndicator1CodeDropdownRow>
{
    public NonEligibleProceedsIndicator1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonEligibleProceedsIndicator1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
