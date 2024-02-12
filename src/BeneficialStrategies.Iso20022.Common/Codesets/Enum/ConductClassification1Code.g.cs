﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ConductClassification1Code.  ISO2002 ID# _nP6msBjoEeKxeog5DTmtgg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the classification of the conduct.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nP6msBjoEeKxeog5DTmtgg")]
[Description(@"Specifies the classification of the conduct.")]
[DerivedFrom(typeof(ConductClassificationCode))]
public enum ConductClassification1Code
{
    /// <summary>
    /// Non standard or unusual.
    /// Encoded/decoded by serializers as "NSTA".
    /// </summary>
    [EnumMember(Value = "NSTA")]
    [IsoId("_rUP-0RjoEeKxeog5DTmtgg")]
    [Description(@"Non standard or unusual.")]
    NonStandard = ConductClassificationCode.NonStandard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reluctant.
    /// Encoded/decoded by serializers as "RCLT".
    /// </summary>
    [EnumMember(Value = "RCLT")]
    [IsoId("_rfkeARjoEeKxeog5DTmtgg")]
    [Description(@"Reluctant.")]
    Reluctant = ConductClassificationCode.Reluctant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standard.
    /// Encoded/decoded by serializers as "STAN".
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_roqIkRjoEeKxeog5DTmtgg")]
    [Description(@"Standard.")]
    Standard = ConductClassificationCode.Standard, // same ordinal as derivation source for type conversions
    
}
