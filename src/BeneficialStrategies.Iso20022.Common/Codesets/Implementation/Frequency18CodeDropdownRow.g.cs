﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Frequency18Code.  ISO2002 ID# _0vb7cR1VEey8XKHwKquEQw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Frequency18CodeDropdownSource"/>.
/// Implements <seealso cref="IFrequency18CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0vb7cR1VEey8XKHwKquEQw")]
public partial class Frequency18CodeDropdownRow : EnumMetadataItem<Frequency18Code>, IFrequency18CodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Frequency18CodeDropdownRow(Frequency18Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
