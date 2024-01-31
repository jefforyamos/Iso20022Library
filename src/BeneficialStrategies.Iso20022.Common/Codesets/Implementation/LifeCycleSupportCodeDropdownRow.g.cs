﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LifeCycleSupportCode.  ISO2002 ID# _0g248FJ3EeeHVODnW-1ONQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the point in the transaction lifecycle at which the lifecycle identifier was assigned.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LifeCycleSupportCodeDropdownSource"/>.
/// Implements <seealso cref="ILifeCycleSupportCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0g248FJ3EeeHVODnW-1ONQ")]
public partial class LifeCycleSupportCodeDropdownRow : EnumMetadataItem<LifeCycleSupportCode>, ILifeCycleSupportCodeDropdownRow
{
    /// <summary>
    /// Indicates the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LifeCycleSupportCodeDropdownRow(LifeCycleSupportCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
