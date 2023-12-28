﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FailureReason6Code.  ISO2002 ID# _x-5LMItDEeSxlKlAGYErFg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for which the key has been stopped.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FailureReason6CodeDropdownSource"/>.
/// Implements <seealso cref="IFailureReason6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_x-5LMItDEeSxlKlAGYErFg")]
public partial class FailureReason6CodeDropdownRow : EnumMetadataItem<FailureReason6Code>, IFailureReason6CodeDropdownRow
{
    /// <summary>
    /// Reason for which the key has been stopped.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FailureReason6CodeDropdownRow(FailureReason6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}