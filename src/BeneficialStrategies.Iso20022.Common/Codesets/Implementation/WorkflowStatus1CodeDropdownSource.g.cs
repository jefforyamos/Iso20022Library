﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for WorkflowStatus1Code.  ISO2002 ID# _1pRyojL3EeKU9IrkkToqcw_-898186420.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the workflow status of the details of a specific level.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IWorkflowStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1pRyojL3EeKU9IrkkToqcw_-898186420")]
public partial class WorkflowStatus1CodeDropdownSource : EnumMetadataManager<WorkflowStatus1Code,IWorkflowStatus1CodeDropdownRow,WorkflowStatus1CodeDropdownRow>
{
    public WorkflowStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new WorkflowStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}