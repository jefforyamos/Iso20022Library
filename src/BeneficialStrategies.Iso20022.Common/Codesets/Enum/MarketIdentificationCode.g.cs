﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarketIdentificationCode.  ISO2002 ID# _lKcvgMObEeWiEtRBUJSIaA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of market identification code which is being defined.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lKcvgMObEeWiEtRBUJSIaA")]
[Description(@"Specifies the type of market identification code which is being defined.")]
[Derivations(typeof(MarketIdentification1Code))]
public enum MarketIdentificationCode
{
    /// <summary>
    /// Market segment code.
    /// Encoded/decoded by serializers as "SGMT".
    /// </summary>
    [EnumMember(Value = "SGMT")]
    [IsoId("_rMH-EMObEeWiEtRBUJSIaA")]
    [Description(@"Market segment code.")]
    Segment,
    
    /// <summary>
    /// Market operating code.
    /// Encoded/decoded by serializers as "OPRT".
    /// </summary>
    [EnumMember(Value = "OPRT")]
    [IsoId("_tbGXEMObEeWiEtRBUJSIaA")]
    [Description(@"Market operating code.")]
    Operating,
    
}
