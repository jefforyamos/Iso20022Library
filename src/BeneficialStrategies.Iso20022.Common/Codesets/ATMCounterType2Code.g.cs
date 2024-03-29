﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMCounterType2Code.  ISO2002 ID# _tkUcgOg5EeSbwP3G-MV9YA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of ATM cassette counters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tkUcgOg5EeSbwP3G-MV9YA")]
[Description(@"Type of ATM cassette counters.")]
[DerivedFrom(typeof(ATMCounterTypeCode))]
public enum ATMCounterType2Code
{
    /// <summary>
    /// Counters since the beginning of the business day.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_1uqAseg5EeSbwP3G-MV9YA")]
    [Description(@"Counters since the beginning of the business day.")]
    BusinessDay = ATMCounterTypeCode.BusinessDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counters since the last counters inquiry.
    /// Encoded/decoded by serializers as &quot;INQU&quot;.
    /// </summary>
    [EnumMember(Value = "INQU")]
    [IsoId("_14WIMeg5EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last counters inquiry.")]
    CountersInquiry = ATMCounterTypeCode.CountersInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counters since the last cut-off.
    /// Encoded/decoded by serializers as &quot;CTOF&quot;.
    /// </summary>
    [EnumMember(Value = "CTOF")]
    [IsoId("_2Osyseg5EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last cut-off.")]
    CutOff = ATMCounterTypeCode.CutOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counters since the last update by an operator on the ATM.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_2iEaoeg5EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last update by an operator on the ATM.")]
    OperatorAdjust = ATMCounterTypeCode.OperatorAdjust, // same ordinal as derivation source for type conversions
    
}
