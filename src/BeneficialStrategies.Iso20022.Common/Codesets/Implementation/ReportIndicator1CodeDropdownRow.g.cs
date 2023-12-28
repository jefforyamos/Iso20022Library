﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReportIndicator1Code.  ISO2002 ID# _ZTCPotp-Ed-ak6NoX_4Aeg_1670165238.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the report, that is, standard or proprietary.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReportIndicator1CodeDropdownSource"/>.
/// Implements <seealso cref="IReportIndicator1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZTCPotp-Ed-ak6NoX_4Aeg_1670165238")]
public partial class ReportIndicator1CodeDropdownRow : EnumMetadataItem<ReportIndicator1Code>, IReportIndicator1CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the report, that is, standard or proprietary.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReportIndicator1CodeDropdownRow(ReportIndicator1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
