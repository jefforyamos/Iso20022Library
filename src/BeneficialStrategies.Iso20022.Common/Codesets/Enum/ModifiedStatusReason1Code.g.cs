﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ModifiedStatusReason1Code.  ISO2002 ID# _0mgfgglIEeGATtfOBToyew_-1343301078.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies that the transaction has been modified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mgfgglIEeGATtfOBToyew_-1343301078")]
[Description(@"Specifies that the transaction has been modified.")]
[DerivedFrom(typeof(ModifiedStatusReasonCode))]
public enum ModifiedStatusReason1Code
{
    /// <summary>
    /// Modification of a transaction by the account owner.
    /// Encoded/decoded by serializers as "MDBY".
    /// </summary>
    [EnumMember(Value = "MDBY")]
    [IsoId("_0mgfgwlIEeGATtfOBToyew_1659777313")]
    [Description(@"Modification of a transaction by the account owner.")]
    ModifiedByYourself = ModifiedStatusReasonCode.ModifiedByYourself, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0mgfhAlIEeGATtfOBToyew_-1957918323")]
    [Description(@"Other. See Narrative.")]
    Other = ModifiedStatusReasonCode.Other, // same ordinal as derivation source for type conversions
    
}
