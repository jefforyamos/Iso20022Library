﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReportingMessageStatus1Code.  ISO2002 ID# _1YwhUNHCEeaokquJJ-K6uA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a whole message processing.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReportingMessageStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IReportingMessageStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1YwhUNHCEeaokquJJ-K6uA")]
public partial class ReportingMessageStatus1CodeDropdownRow : EnumMetadataItem<ReportingMessageStatus1Code>, IReportingMessageStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a whole message processing.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReportingMessageStatus1CodeDropdownRow(ReportingMessageStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
