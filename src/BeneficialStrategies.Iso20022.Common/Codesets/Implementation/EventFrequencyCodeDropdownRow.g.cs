﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventFrequencyCode.  ISO2002 ID# _akGO4dp-Ed-ak6NoX_4Aeg_1216168726.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventFrequencyCodeDropdownSource"/>.
/// Implements <seealso cref="IEventFrequencyCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_akGO4dp-Ed-ak6NoX_4Aeg_1216168726")]
public partial class EventFrequencyCodeDropdownRow : EnumMetadataItem<EventFrequencyCode>, IEventFrequencyCodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventFrequencyCodeDropdownRow(EventFrequencyCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
