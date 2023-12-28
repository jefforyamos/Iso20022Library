﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventWorkflowStatusCode.  ISO2002 ID# _1v-3kzL3EeKU9IrkkToqcw_-1586819968.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the workflow status of the announcement record based on validation procedure.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventWorkflowStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1v-3kzL3EeKU9IrkkToqcw_-1586819968")]
public partial class EventWorkflowStatusCodeDropdownSource : EnumMetadataManager<EventWorkflowStatusCode,IEventWorkflowStatusCodeDropdownRow,EventWorkflowStatusCodeDropdownRow>
{
    public EventWorkflowStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventWorkflowStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}