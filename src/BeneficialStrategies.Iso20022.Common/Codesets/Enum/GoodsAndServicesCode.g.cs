﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GoodsAndServicesCode.  ISO2002 ID# _1F82kErCEeenp6hmNprBHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of goods and services purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1F82kErCEeenp6hmNprBHg")]
[Description(@"Type of goods and services purchased.")]
[Derivations(typeof(GoodsAndServices1Code))]
public enum GoodsAndServicesCode
{
    /// <summary>
    /// Physical goods or services.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_49iw0FHhEeeJoafcMZup1w")]
    [Description(@"Physical goods or services.")]
    Physical,
    
    /// <summary>
    /// Electronic goods and services.
    /// Encoded/decoded by serializers as "ELEC".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_9rGsIFHhEeeJoafcMZup1w")]
    [Description(@"Electronic goods and services.")]
    Electronic,
    
    /// <summary>
    /// Electronic and physical goods and services.
    /// Encoded/decoded by serializers as "ELPH".
    /// </summary>
    [EnumMember(Value = "ELPH")]
    [IsoId("_GAAhkFHiEeeJoafcMZup1w")]
    [Description(@"Electronic and physical goods and services.")]
    ElectronicAndPhysical,
    
}
