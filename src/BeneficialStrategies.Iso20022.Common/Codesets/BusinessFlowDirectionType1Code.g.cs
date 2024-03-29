﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BusinessFlowDirectionType1Code.  ISO2002 ID# _HUJJQPslEeCIi9ZETLBv8g.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the business flow, in order to determine the role of the parties in the business process. This indicator is very important when there are multiple intermediaries in the exchange of information process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HUJJQPslEeCIi9ZETLBv8g")]
[Description(@"Identifies the business flow, in order to determine the role of the parties in the business process. This indicator is very important when there are multiple intermediaries in the exchange of information process.")]
[DerivedFrom(typeof(BusinessFlowDirectionTypeCode))]
public enum BusinessFlowDirectionType1Code
{
    /// <summary>
    /// Assets to be delivered.
    /// Encoded/decoded by serializers as &quot;ADLV&quot;.
    /// </summary>
    [EnumMember(Value = "ADLV")]
    [IsoId("_ShZ7tv8yEeC-e_lDNJKWcg")]
    [Description(@"Assets to be delivered.")]
    AssetstoBeDelivered = BusinessFlowDirectionTypeCode.AssetstoBeDelivered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Assets to be received.
    /// Encoded/decoded by serializers as &quot;ARCV&quot;.
    /// </summary>
    [EnumMember(Value = "ARCV")]
    [IsoId("_SlRvHv8yEeC-e_lDNJKWcg")]
    [Description(@"Assets to be received.")]
    AssetsToBeReceived = BusinessFlowDirectionTypeCode.AssetsToBeReceived, // same ordinal as derivation source for type conversions
    
}
