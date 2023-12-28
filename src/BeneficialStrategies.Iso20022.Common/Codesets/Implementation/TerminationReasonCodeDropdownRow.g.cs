﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TerminationReasonCode.  ISO2002 ID# _X1pf0HyiEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the termination reason.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TerminationReasonCodeDropdownSource"/>.
/// Implements <seealso cref="ITerminationReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_X1pf0HyiEeGWJuGCfvwOsQ")]
public partial class TerminationReasonCodeDropdownRow : EnumMetadataItem<TerminationReasonCode>, ITerminationReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the termination reason.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TerminationReasonCodeDropdownRow(TerminationReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}