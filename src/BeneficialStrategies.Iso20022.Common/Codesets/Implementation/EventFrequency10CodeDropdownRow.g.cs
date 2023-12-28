﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventFrequency10Code.  ISO2002 ID# _9DnqYCDUEeWCLu74WLgP4w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventFrequency10CodeDropdownSource"/>.
/// Implements <seealso cref="IEventFrequency10CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_9DnqYCDUEeWCLu74WLgP4w")]
public partial class EventFrequency10CodeDropdownRow : EnumMetadataItem<EventFrequency10Code>, IEventFrequency10CodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventFrequency10CodeDropdownRow(EventFrequency10Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
