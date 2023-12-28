﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReportType1Code.  ISO2002 ID# _ZTVxotp-Ed-ak6NoX_4Aeg_-215532945.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the report contains a new, a resubmitted or an amended baseline.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReportType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZTVxotp-Ed-ak6NoX_4Aeg_-215532945")]
public partial class ReportType1CodeDropdownSource : EnumMetadataManager<ReportType1Code,IReportType1CodeDropdownRow,ReportType1CodeDropdownRow>
{
    public ReportType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReportType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
