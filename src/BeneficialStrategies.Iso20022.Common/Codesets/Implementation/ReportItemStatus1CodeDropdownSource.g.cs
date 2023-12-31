﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReportItemStatus1Code.  ISO2002 ID# _NSTaoEisEeSlHoYg_EudVQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an entry in a report.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReportItemStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NSTaoEisEeSlHoYg_EudVQ")]
public partial class ReportItemStatus1CodeDropdownSource : EnumMetadataManager<ReportItemStatus1Code,IReportItemStatus1CodeDropdownRow,ReportItemStatus1CodeDropdownRow>
{
    public ReportItemStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReportItemStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
