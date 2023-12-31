﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExecutionStatus1Code.  ISO2002 ID# _5OqesMX5EeiSF9q-coWegA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message as a code.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExecutionStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IExecutionStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5OqesMX5EeiSF9q-coWegA")]
public partial class ExecutionStatus1CodeDropdownRow : EnumMetadataItem<ExecutionStatus1Code>, IExecutionStatus1CodeDropdownRow
{
    /// <summary>
    /// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message as a code.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExecutionStatus1CodeDropdownRow(ExecutionStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
