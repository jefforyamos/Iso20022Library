﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventWorkflowStatus1Code.  ISO2002 ID# _1yNsNDL3EeKU9IrkkToqcw_804712401.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the workflow status of the announcement record based on validation procedure.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventWorkflowStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IEventWorkflowStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1yNsNDL3EeKU9IrkkToqcw_804712401")]
public partial class EventWorkflowStatus1CodeDropdownRow : EnumMetadataItem<EventWorkflowStatus1Code>, IEventWorkflowStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the workflow status of the announcement record based on validation procedure.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventWorkflowStatus1CodeDropdownRow(EventWorkflowStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
