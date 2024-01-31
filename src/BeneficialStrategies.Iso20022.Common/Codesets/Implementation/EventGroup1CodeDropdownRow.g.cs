﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventGroup1Code.  ISO2002 ID# _1tTXAjL3EeKU9IrkkToqcw_-1870797912.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventGroup1CodeDropdownSource"/>.
/// Implements <seealso cref="IEventGroup1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1tTXAjL3EeKU9IrkkToqcw_-1870797912")]
public partial class EventGroup1CodeDropdownRow : EnumMetadataItem<EventGroup1Code>, IEventGroup1CodeDropdownRow
{
    /// <summary>
    /// Specifies DTC (The Depository Trust Company) processing domain for the event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventGroup1CodeDropdownRow(EventGroup1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
