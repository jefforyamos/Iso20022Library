﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReportingRecordStatus1Code.  ISO2002 ID# _KATXoNHEEeaokquJJ-K6uA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the processing of an individual record within a message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReportingRecordStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IReportingRecordStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KATXoNHEEeaokquJJ-K6uA")]
public partial class ReportingRecordStatus1CodeDropdownRow : EnumMetadataItem<ReportingRecordStatus1Code>, IReportingRecordStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of the processing of an individual record within a message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReportingRecordStatus1CodeDropdownRow(ReportingRecordStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
