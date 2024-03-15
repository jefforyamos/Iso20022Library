﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GlobalNote1Code.  ISO2002 ID# _hbcAo2liEeGaMcKyqKNRfQ_1398344380.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbcAo2liEeGaMcKyqKNRfQ_1398344380")]
[Description(@"Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).")]
[DerivedFrom(typeof(GlobalNoteCode))]
public enum GlobalNote1Code
{
    /// <summary>
    /// Form of global certificate which refers to the books and records of the ICSDs to determine the Issue Outstanding Amount (IOA).
    /// Encoded/decoded by serializers as &quot;NGNO&quot;.
    /// </summary>
    [EnumMember(Value = "NGNO")]
    [IsoId("_hbcApGliEeGaMcKyqKNRfQ_526655547")]
    [Description(@"Form of global certificate which refers to the books and records of the ICSDs to determine the Issue Outstanding Amount (IOA).")]
    NewGlobalNote = GlobalNoteCode.NewGlobalNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the Issue Outstanding Amount (IOA).
    /// Encoded/decoded by serializers as &quot;CGNO&quot;.
    /// </summary>
    [EnumMember(Value = "CGNO")]
    [IsoId("_hbcApWliEeGaMcKyqKNRfQ_-108376299")]
    [Description(@"Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the Issue Outstanding Amount (IOA).")]
    ClassicalGlobalNote = GlobalNoteCode.ClassicalGlobalNote, // same ordinal as derivation source for type conversions
    
}
