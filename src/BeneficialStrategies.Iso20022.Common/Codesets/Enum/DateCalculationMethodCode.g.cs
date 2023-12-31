﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DateCalculationMethodCode.  ISO2002 ID# _oGUJ5lSUEempisJfoIfvvQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the calculation method to be used to caculate on which dates the shares have been acquired.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oGUJ5lSUEempisJfoIfvvQ")]
[Description(@"Indicates the calculation method to be used to caculate on which dates the shares have been acquired.")]
[Derivations(typeof(DateCalculationMethod1Code))]
// External derivations that should be provided by the proper interface are: 
public enum DateCalculationMethodCode
{
    /// <summary>
    /// First in, first out. 
    /// Encoded/decoded by serializers as "FIFO".
    /// </summary>
    [EnumMember(Value = "FIFO")]
    [IsoId("_oGUJ51SUEempisJfoIfvvQ")]
    [Description(@"First in, first out. ")]
    Fifo,
    
    /// <summary>
    /// Last in, first out. 
    /// Encoded/decoded by serializers as "LIFO".
    /// </summary>
    [EnumMember(Value = "LIFO")]
    [IsoId("_oGUJ6FSUEempisJfoIfvvQ")]
    [Description(@"Last in, first out. ")]
    Lifo,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DateCalculationMethodCodeMetadataExtensions
{
    private static readonly DateCalculationMethodCodeDropdownSource _dropdownSource = new DateCalculationMethodCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDateCalculationMethodCodeDropdownRow GetMetadata(this DateCalculationMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


