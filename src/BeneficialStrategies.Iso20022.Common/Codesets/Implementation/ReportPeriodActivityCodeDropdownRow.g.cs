﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReportPeriodActivityCode.  ISO2002 ID# _NgO2UZfnEeSfnc-VXAEapg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of report activity for a specific period.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReportPeriodActivityCodeDropdownSource"/>.
/// Implements <seealso cref="IReportPeriodActivityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NgO2UZfnEeSfnc-VXAEapg")]
public partial class ReportPeriodActivityCodeDropdownRow : EnumMetadataItem<ReportPeriodActivityCode>, IReportPeriodActivityCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of report activity for a specific period.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReportPeriodActivityCodeDropdownRow(ReportPeriodActivityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
