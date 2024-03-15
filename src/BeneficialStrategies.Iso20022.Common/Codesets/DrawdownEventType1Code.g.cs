﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DrawdownEventType1Code.  ISO2002 ID# _c--OoFNiEeijdq8ilaxyOA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of drawdown event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_c--OoFNiEeijdq8ilaxyOA")]
[Description(@"Specifies a type of drawdown event.")]
[DerivedFrom(typeof(DrawdownEventTypeCode))]
public enum DrawdownEventType1Code
{
    /// <summary>
    /// Event is a drawdown.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_eBVDgVNiEeijdq8ilaxyOA")]
    [Description(@"Event is a drawdown.")]
    Drawdown = DrawdownEventTypeCode.Drawdown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is an uncrystallised funds pension lump sum (UFPLS).
    /// Encoded/decoded by serializers as &quot;UFPL&quot;.
    /// </summary>
    [EnumMember(Value = "UFPL")]
    [IsoId("_eGiToVNiEeijdq8ilaxyOA")]
    [Description(@"Event is an uncrystallised funds pension lump sum (UFPLS).")]
    UncrystallisedFundsPensionLumpSum = DrawdownEventTypeCode.UncrystallisedFundsPensionLumpSum, // same ordinal as derivation source for type conversions
    
}
