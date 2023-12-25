﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementReportTypeCode.  ISO2002 ID# _OiEAwFdJEeeIAMBcVOw01w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of settlement report.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementReportTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementReportTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OiEAwFdJEeeIAMBcVOw01w")]
public partial class SettlementReportTypeCodeDropdownRow : EnumMetadataItem<SettlementReportTypeCode>, ISettlementReportTypeCodeDropdownRow
{
    /// <summary>
    /// Type of settlement report.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementReportTypeCodeDropdownRow(SettlementReportTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
