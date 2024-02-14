﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleReceived1Code.  ISO2002 ID# _1VeIch-0EeuxStysDTgLiw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the received status for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1VeIch-0EeuxStysDTgLiw")]
[Description(@"Specifies the received status for the cross-element validation rules.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleReceived1Code
{
    /// <summary>
    /// Received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_Eth3kR-1EeuxStysDTgLiw")]
    [Description(@"Received.")]
    Received = ValidationRuleCode.Received, // same ordinal as derivation source for type conversions
    
}
