﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonEligibleProceedsIndicatorCode.  ISO2002 ID# _aNmactp-Ed-ak6NoX_4Aeg_975102968.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies information regarding the non eligibility of the outturn resources.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonEligibleProceedsIndicatorCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aNmactp-Ed-ak6NoX_4Aeg_975102968")]
public partial class NonEligibleProceedsIndicatorCodeDropdownSource : EnumMetadataManager<NonEligibleProceedsIndicatorCode,INonEligibleProceedsIndicatorCodeDropdownRow,NonEligibleProceedsIndicatorCodeDropdownRow>
{
    public NonEligibleProceedsIndicatorCodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonEligibleProceedsIndicatorCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
