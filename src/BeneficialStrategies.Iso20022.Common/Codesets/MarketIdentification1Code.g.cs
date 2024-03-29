﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarketIdentification1Code.  ISO2002 ID# _9JOc0MObEeWiEtRBUJSIaA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of market identification code which is being defined.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9JOc0MObEeWiEtRBUJSIaA")]
[Description(@"Specifies the type of market identification code which is being defined.")]
[DerivedFrom(typeof(MarketIdentificationCode))]
public enum MarketIdentification1Code
{
    /// <summary>
    /// Market segment code.
    /// Encoded/decoded by serializers as &quot;SGMT&quot;.
    /// </summary>
    [EnumMember(Value = "SGMT")]
    [IsoId("_AoDUIcOcEeWiEtRBUJSIaA")]
    [Description(@"Market segment code.")]
    Segment = MarketIdentificationCode.Segment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Market operating code.
    /// Encoded/decoded by serializers as &quot;OPRT&quot;.
    /// </summary>
    [EnumMember(Value = "OPRT")]
    [IsoId("_Aq3-ocOcEeWiEtRBUJSIaA")]
    [Description(@"Market operating code.")]
    Operating = MarketIdentificationCode.Operating, // same ordinal as derivation source for type conversions
    
}
