﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventWorkflowStatus2Code.  ISO2002 ID# _1ygnIzL3EeKU9IrkkToqcw_-1596979642.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the workflow status of the announcement record based on validation procedure.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventWorkflowStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="IEventWorkflowStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1ygnIzL3EeKU9IrkkToqcw_-1596979642")]
public partial class EventWorkflowStatus2CodeDropdownRow : EnumMetadataItem<EventWorkflowStatus2Code>, IEventWorkflowStatus2CodeDropdownRow
{
    /// <summary>
    /// Specifies the workflow status of the announcement record based on validation procedure.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventWorkflowStatus2CodeDropdownRow(EventWorkflowStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
