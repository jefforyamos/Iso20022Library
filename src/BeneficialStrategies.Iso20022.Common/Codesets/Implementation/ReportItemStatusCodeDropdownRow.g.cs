﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReportItemStatusCode.  ISO2002 ID# _sjRYp0irEeSlHoYg_EudVQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an entry in a report.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReportItemStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IReportItemStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sjRYp0irEeSlHoYg_EudVQ")]
public partial class ReportItemStatusCodeDropdownRow : EnumMetadataItem<ReportItemStatusCode>, IReportItemStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an entry in a report.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReportItemStatusCodeDropdownRow(ReportItemStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
