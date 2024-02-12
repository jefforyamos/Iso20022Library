﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustomerOrderRequest1Code.  ISO2002 ID# _ShkGgN6JEeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of customer orders that must be sent in response message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ShkGgN6JEeiwsev40qZGEQ")]
[Description(@"Type of customer orders that must be sent in response message.")]
[DerivedFrom(typeof(CustomerOrderRequestCode))]
public enum CustomerOrderRequest1Code
{
    /// <summary>
    /// All types of CustomerOrder should be listed, some are open others closed.
    /// Encoded/decoded by serializers as "BOTH".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_TzXFkd6JEeiwsev40qZGEQ")]
    [Description(@"All types of CustomerOrder should be listed, some are open others closed.")]
    Both = CustomerOrderRequestCode.Both, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Completed customer orders.
    /// Encoded/decoded by serializers as "CLSD".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_T3Kngd6JEeiwsev40qZGEQ")]
    [Description(@"Completed customer orders.")]
    Closed = CustomerOrderRequestCode.Closed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer order not completed.
    /// Encoded/decoded by serializers as "OPEN".
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_T64C0d6JEeiwsev40qZGEQ")]
    [Description(@"Customer order not completed.")]
    Open = CustomerOrderRequestCode.Open, // same ordinal as derivation source for type conversions
    
}
