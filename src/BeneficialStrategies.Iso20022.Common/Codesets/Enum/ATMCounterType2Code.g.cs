﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMCounterType2Code.  ISO2002 ID# _tkUcgOg5EeSbwP3G-MV9YA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "BusinessDay".
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_1uqAseg5EeSbwP3G-MV9YA")]
    [Description(@"Counters since the beginning of the business day.")]
    BusinessDay,
    
    /// <summary>
    /// Counters since the last counters inquiry.
    /// Encoded/decoded by serializers as "CountersInquiry".
    /// </summary>
    [EnumMember(Value = "INQU")]
    [IsoId("_14WIMeg5EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last counters inquiry.")]
    CountersInquiry,
    
    /// <summary>
    /// Counters since the last cut-off.
    /// Encoded/decoded by serializers as "CutOff".
    /// </summary>
    [EnumMember(Value = "CTOF")]
    [IsoId("_2Osyseg5EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last cut-off.")]
    CutOff,
    
    /// <summary>
    /// Counters since the last update by an operator on the ATM.
    /// Encoded/decoded by serializers as "OperatorAdjust".
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_2iEaoeg5EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last update by an operator on the ATM.")]
    OperatorAdjust,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMCounterType2CodeMetadataExtensions
{
    private static readonly ATMCounterType2CodeDropdownSource _dropdownSource = new ATMCounterType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMCounterType2CodeDropdownRow GetMetadata(this ATMCounterType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


