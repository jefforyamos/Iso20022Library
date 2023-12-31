﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Algorithm20Code.  ISO2002 ID# _EGOq0aRHEeeWXKXf3KjtmQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of a digest algorithm.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Algorithm20CodeDropdownSource"/>.
/// Implements <seealso cref="IAlgorithm20CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EGOq0aRHEeeWXKXf3KjtmQ")]
public partial class Algorithm20CodeDropdownRow : EnumMetadataItem<Algorithm20Code>, IAlgorithm20CodeDropdownRow
{
    /// <summary>
    /// Identification of a digest algorithm.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Algorithm20CodeDropdownRow(Algorithm20Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
