﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventType1Code.  ISO2002 ID# _aki609p-Ed-ak6NoX_4Aeg_-470397126.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventType1CodeDropdownSource"/>.
/// Implements <seealso cref="IEventType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aki609p-Ed-ak6NoX_4Aeg_-470397126")]
public partial class EventType1CodeDropdownRow : EnumMetadataItem<EventType1Code>, IEventType1CodeDropdownRow
{
    /// <summary>
    /// Identifies the type of event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventType1CodeDropdownRow(EventType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
