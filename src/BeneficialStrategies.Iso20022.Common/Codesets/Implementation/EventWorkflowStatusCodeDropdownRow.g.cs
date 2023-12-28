﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventWorkflowStatusCode.  ISO2002 ID# _1v-3kzL3EeKU9IrkkToqcw_-1586819968.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the workflow status of the announcement record based on validation procedure.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventWorkflowStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IEventWorkflowStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1v-3kzL3EeKU9IrkkToqcw_-1586819968")]
public partial class EventWorkflowStatusCodeDropdownRow : EnumMetadataItem<EventWorkflowStatusCode>, IEventWorkflowStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the workflow status of the announcement record based on validation procedure.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventWorkflowStatusCodeDropdownRow(EventWorkflowStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}