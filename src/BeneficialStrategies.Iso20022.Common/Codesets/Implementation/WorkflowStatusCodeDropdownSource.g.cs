﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for WorkflowStatusCode.  ISO2002 ID# _1nx90jL3EeKU9IrkkToqcw_-1815438950.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the workflow status of the details of a specific level.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IWorkflowStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1nx90jL3EeKU9IrkkToqcw_-1815438950")]
public partial class WorkflowStatusCodeDropdownSource : EnumMetadataManager<WorkflowStatusCode,IWorkflowStatusCodeDropdownRow,WorkflowStatusCodeDropdownRow>
{
    public WorkflowStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new WorkflowStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
