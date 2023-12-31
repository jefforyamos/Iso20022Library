﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReportItemStatusCode.  ISO2002 ID# _sjRYp0irEeSlHoYg_EudVQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an entry in a report.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReportItemStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sjRYp0irEeSlHoYg_EudVQ")]
public partial class ReportItemStatusCodeDropdownSource : EnumMetadataManager<ReportItemStatusCode,IReportItemStatusCodeDropdownRow,ReportItemStatusCodeDropdownRow>
{
    public ReportItemStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReportItemStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
