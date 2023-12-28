﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Frequency8Code.  ISO2002 ID# _q5d88A3iEeWc7_0KPiuk6w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Frequency8CodeDropdownSource"/>.
/// Implements <seealso cref="IFrequency8CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_q5d88A3iEeWc7_0KPiuk6w")]
public partial class Frequency8CodeDropdownRow : EnumMetadataItem<Frequency8Code>, IFrequency8CodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Frequency8CodeDropdownRow(Frequency8Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
