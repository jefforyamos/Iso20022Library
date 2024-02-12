﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnrealisedCode.  ISO2002 ID# _m50OY_NBEeCuA5Tr22BnwA_1824968417.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies unrealised parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m50OY_NBEeCuA5Tr22BnwA_1824968417")]
[Description(@"Specifies unrealised parameter.")]
[Derivations(typeof(Unrealised1Code))]
public enum UnrealisedCode
{
    /// <summary>
    /// Unrealised gain.
    /// Encoded/decoded by serializers as "GAIN".
    /// </summary>
    [EnumMember(Value = "GAIN")]
    [IsoId("_m50OZPNBEeCuA5Tr22BnwA_667402002")]
    [Description(@"Unrealised gain.")]
    Gain,
    
    /// <summary>
    /// Unrealised loss.
    /// Encoded/decoded by serializers as "LOSS".
    /// </summary>
    [EnumMember(Value = "LOSS")]
    [IsoId("_m50OZfNBEeCuA5Tr22BnwA_-1644430516")]
    [Description(@"Unrealised loss.")]
    Loss,
    
}
