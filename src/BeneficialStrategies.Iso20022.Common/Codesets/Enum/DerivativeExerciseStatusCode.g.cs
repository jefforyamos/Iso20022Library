﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DerivativeExerciseStatusCode.  ISO2002 ID# _l2kogCKKEeSbDuI5b0sFEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the exercise status of the derivative products.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_l2kogCKKEeSbDuI5b0sFEQ")]
[Description(@"Specifies the exercise status of the derivative products.")]
[Derivations(typeof(DerivativeExerciseStatus1Code))]
public enum DerivativeExerciseStatusCode
{
    /// <summary>
    /// Derivative is exercised.
    /// Encoded/decoded by serializers as "EXEC".
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_yRPZcCKKEeSbDuI5b0sFEQ")]
    [Description(@"Derivative is exercised.")]
    Exercised,
    
    /// <summary>
    /// Derivative is expired and will not be exercised.
    /// Encoded/decoded by serializers as "EXPI".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_6c1h4CKKEeSbDuI5b0sFEQ")]
    [Description(@"Derivative is expired and will not be exercised.")]
    Expired,
    
    /// <summary>
    /// Derivative is not exercised.
    /// Encoded/decoded by serializers as "VALI".
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_W9KHwCKLEeSbDuI5b0sFEQ")]
    [Description(@"Derivative is not exercised.")]
    Valid,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DerivativeExerciseStatusCodeMetadataExtensions
{
    private static readonly DerivativeExerciseStatusCodeDropdownSource _dropdownSource = new DerivativeExerciseStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDerivativeExerciseStatusCodeDropdownRow GetMetadata(this DerivativeExerciseStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


