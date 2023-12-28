﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventFrequency5Code.  ISO2002 ID# _ajzT-Np-Ed-ak6NoX_4Aeg_-1261201154.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventFrequency5CodeDropdownSource"/>.
/// Implements <seealso cref="IEventFrequency5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ajzT-Np-Ed-ak6NoX_4Aeg_-1261201154")]
public partial class EventFrequency5CodeDropdownRow : EnumMetadataItem<EventFrequency5Code>, IEventFrequency5CodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventFrequency5CodeDropdownRow(EventFrequency5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
