﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementReportTypeCode.  ISO2002 ID# _OiEAwFdJEeeIAMBcVOw01w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of settlement report.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementReportTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OiEAwFdJEeeIAMBcVOw01w")]
public partial class SettlementReportTypeCodeDropdownSource : EnumMetadataManager<SettlementReportTypeCode,ISettlementReportTypeCodeDropdownRow,SettlementReportTypeCodeDropdownRow>
{
    public SettlementReportTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementReportTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}