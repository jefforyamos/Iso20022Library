﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventTypeCode.  ISO2002 ID# _aksr0dp-Ed-ak6NoX_4Aeg_-483323603.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IEventTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aksr0dp-Ed-ak6NoX_4Aeg_-483323603")]
public partial class EventTypeCodeDropdownRow : EnumMetadataItem<EventTypeCode>, IEventTypeCodeDropdownRow
{
    /// <summary>
    /// Identifies the type of event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventTypeCodeDropdownRow(EventTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
