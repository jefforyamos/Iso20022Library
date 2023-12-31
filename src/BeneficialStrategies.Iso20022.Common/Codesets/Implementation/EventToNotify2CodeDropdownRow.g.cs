﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventToNotify2Code.  ISO2002 ID# _CXj_EQ0vEeqUVL7sB4m7NA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Event the POI notifies to the Sale System.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventToNotify2CodeDropdownSource"/>.
/// Implements <seealso cref="IEventToNotify2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CXj_EQ0vEeqUVL7sB4m7NA")]
public partial class EventToNotify2CodeDropdownRow : EnumMetadataItem<EventToNotify2Code>, IEventToNotify2CodeDropdownRow
{
    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventToNotify2CodeDropdownRow(EventToNotify2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
