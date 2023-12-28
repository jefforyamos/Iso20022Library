﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StatisticalReportingStatusCode.  ISO2002 ID# _WxrMP9jEEeSdIOSPwTkydQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a single statistical reporting transaction or of a group of statistical reporting transactions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StatisticalReportingStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IStatisticalReportingStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WxrMP9jEEeSdIOSPwTkydQ")]
public partial class StatisticalReportingStatusCodeDropdownRow : EnumMetadataItem<StatisticalReportingStatusCode>, IStatisticalReportingStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a single statistical reporting transaction or of a group of statistical reporting transactions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StatisticalReportingStatusCodeDropdownRow(StatisticalReportingStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}