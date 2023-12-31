﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StatisticalReportingStatusCode.  ISO2002 ID# _WxrMP9jEEeSdIOSPwTkydQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a single statistical reporting transaction or of a group of statistical reporting transactions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatisticalReportingStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WxrMP9jEEeSdIOSPwTkydQ")]
public partial class StatisticalReportingStatusCodeDropdownSource : EnumMetadataManager<StatisticalReportingStatusCode,IStatisticalReportingStatusCodeDropdownRow,StatisticalReportingStatusCodeDropdownRow>
{
    public StatisticalReportingStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new StatisticalReportingStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
