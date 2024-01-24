﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WorkflowStatusCode.  ISO2002 ID# _1nx90jL3EeKU9IrkkToqcw_-1815438950.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the workflow status of the details of a specific level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1nx90jL3EeKU9IrkkToqcw_-1815438950")]
[Description(@"Specifies the workflow status of the details of a specific level.")]
[Derivations(typeof(WorkflowStatus1Code))]
public enum WorkflowStatusCode
{
    /// <summary>
    /// Level details are complete. All required data is populated and verified.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_1nx90zL3EeKU9IrkkToqcw_-1062462899")]
    [Description(@"Level details are complete. All required data is populated and verified.")]
    Complete,
    
    /// <summary>
    /// Level details are incomplete due to conflicting details from 2 or more sources.
    /// Encoded/decoded by serializers as "CNFL".
    /// </summary>
    [EnumMember(Value = "CNFL")]
    [IsoId("_1nx91DL3EeKU9IrkkToqcw_1685878057")]
    [Description(@"Level details are incomplete due to conflicting details from 2 or more sources.")]
    Conflict,
    
    /// <summary>
    /// Level details are complete pending a condition.
    /// Encoded/decoded by serializers as "COND".
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_1nx91TL3EeKU9IrkkToqcw_-1793170858")]
    [Description(@"Level details are complete pending a condition.")]
    ConditionallyComplete,
    
    /// <summary>
    /// Level details are incomplete.
    /// Encoded/decoded by serializers as "INCO".
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_1n7u0DL3EeKU9IrkkToqcw_868726079")]
    [Description(@"Level details are incomplete.")]
    Incomplete,
    
    /// <summary>
    /// Level has been deleted, cancelled/deactivated/invalidated by the source or due to error processing error.
    /// Encoded/decoded by serializers as "DLTD".
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_1n7u0TL3EeKU9IrkkToqcw_-1903689822")]
    [Description(@"Level has been deleted, cancelled/deactivated/invalidated by the source or due to error processing error.")]
    Deleted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class WorkflowStatusCodeMetadataExtensions
{
    private static readonly WorkflowStatusCodeDropdownSource _dropdownSource = new WorkflowStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IWorkflowStatusCodeDropdownRow GetMetadata(this WorkflowStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


