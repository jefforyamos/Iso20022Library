﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TimeFrame1Code.  ISO2002 ID# _fFUKADccEeidBoT_PugKiA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a time frame.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TimeFrame1CodeDropdownSource"/>.
/// Implements <seealso cref="ITimeFrame1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fFUKADccEeidBoT_PugKiA")]
public partial class TimeFrame1CodeDropdownRow : EnumMetadataItem<TimeFrame1Code>, ITimeFrame1CodeDropdownRow
{
    /// <summary>
    /// Specifies a time frame.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TimeFrame1CodeDropdownRow(TimeFrame1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
