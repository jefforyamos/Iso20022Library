﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for WorkflowStatusCode.  ISO2002 ID# _1nx90jL3EeKU9IrkkToqcw_-1815438950.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the workflow status of the details of a specific level.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="WorkflowStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IWorkflowStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1nx90jL3EeKU9IrkkToqcw_-1815438950")]
public partial class WorkflowStatusCodeDropdownRow : EnumMetadataItem<WorkflowStatusCode>, IWorkflowStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the workflow status of the details of a specific level.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public WorkflowStatusCodeDropdownRow(WorkflowStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
