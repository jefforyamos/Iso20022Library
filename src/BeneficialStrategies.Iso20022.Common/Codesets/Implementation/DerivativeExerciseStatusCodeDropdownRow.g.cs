﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DerivativeExerciseStatusCode.  ISO2002 ID# _l2kogCKKEeSbDuI5b0sFEQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the exercise status of the derivative products.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DerivativeExerciseStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IDerivativeExerciseStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_l2kogCKKEeSbDuI5b0sFEQ")]
public partial class DerivativeExerciseStatusCodeDropdownRow : EnumMetadataItem<DerivativeExerciseStatusCode>, IDerivativeExerciseStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the exercise status of the derivative products.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DerivativeExerciseStatusCodeDropdownRow(DerivativeExerciseStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}