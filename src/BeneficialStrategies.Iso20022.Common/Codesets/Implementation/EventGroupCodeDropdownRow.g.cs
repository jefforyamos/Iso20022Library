﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventGroupCode.  ISO2002 ID# _1oFf0zL3EeKU9IrkkToqcw_648096752.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventGroupCodeDropdownSource"/>.
/// Implements <seealso cref="IEventGroupCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1oFf0zL3EeKU9IrkkToqcw_648096752")]
public partial class EventGroupCodeDropdownRow : EnumMetadataItem<EventGroupCode>, IEventGroupCodeDropdownRow
{
    /// <summary>
    /// Specifies DTC (The Depository Trust Company) processing domain for the event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventGroupCodeDropdownRow(EventGroupCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
