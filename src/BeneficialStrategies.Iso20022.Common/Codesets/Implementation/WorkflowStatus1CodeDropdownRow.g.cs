﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for WorkflowStatus1Code.  ISO2002 ID# _1pRyojL3EeKU9IrkkToqcw_-898186420.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the workflow status of the details of a specific level.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="WorkflowStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IWorkflowStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1pRyojL3EeKU9IrkkToqcw_-898186420")]
public partial class WorkflowStatus1CodeDropdownRow : EnumMetadataItem<WorkflowStatus1Code>, IWorkflowStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the workflow status of the details of a specific level.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public WorkflowStatus1CodeDropdownRow(WorkflowStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
