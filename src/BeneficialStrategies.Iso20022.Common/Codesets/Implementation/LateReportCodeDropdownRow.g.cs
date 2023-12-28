﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LateReportCode.  ISO2002 ID# _ad114Np-Ed-ak6NoX_4Aeg_-1931554281.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a transaction report is late.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LateReportCodeDropdownSource"/>.
/// Implements <seealso cref="ILateReportCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ad114Np-Ed-ak6NoX_4Aeg_-1931554281")]
public partial class LateReportCodeDropdownRow : EnumMetadataItem<LateReportCode>, ILateReportCodeDropdownRow
{
    /// <summary>
    /// Specifies whether a transaction report is late.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LateReportCodeDropdownRow(LateReportCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}