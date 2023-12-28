﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DateMode1Code.  ISO2002 ID# _f_Z6kFuSEeSmO6RkXg92Lg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies, for a date, when the event or operation is to take place, for example at the beginning or end of the day.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DateMode1CodeDropdownSource"/>.
/// Implements <seealso cref="IDateMode1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_f_Z6kFuSEeSmO6RkXg92Lg")]
public partial class DateMode1CodeDropdownRow : EnumMetadataItem<DateMode1Code>, IDateMode1CodeDropdownRow
{
    /// <summary>
    /// Specifies, for a date, when the event or operation is to take place, for example at the beginning or end of the day.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DateMode1CodeDropdownRow(DateMode1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}