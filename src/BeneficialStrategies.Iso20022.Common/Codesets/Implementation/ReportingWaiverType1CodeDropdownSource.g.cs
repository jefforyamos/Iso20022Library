﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReportingWaiverType1Code.  ISO2002 ID# _OA4ukO8WEeSLA89yUYsVSw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of regulatory reporting pre-trade waiver.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReportingWaiverType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OA4ukO8WEeSLA89yUYsVSw")]
public partial class ReportingWaiverType1CodeDropdownSource : EnumMetadataManager<ReportingWaiverType1Code,IReportingWaiverType1CodeDropdownRow,ReportingWaiverType1CodeDropdownRow>
{
    public ReportingWaiverType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReportingWaiverType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
