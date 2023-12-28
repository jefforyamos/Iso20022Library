﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReportItemStatus1Code.  ISO2002 ID# _NSTaoEisEeSlHoYg_EudVQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an entry in a report.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReportItemStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IReportItemStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NSTaoEisEeSlHoYg_EudVQ")]
public partial class ReportItemStatus1CodeDropdownRow : EnumMetadataItem<ReportItemStatus1Code>, IReportItemStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an entry in a report.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReportItemStatus1CodeDropdownRow(ReportItemStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
