﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CallType1Code.  ISO2002 ID# _ha1jvmliEeGaMcKyqKNRfQ_1930331494.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of execution of the call feature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha1jvmliEeGaMcKyqKNRfQ_1930331494")]
[Description(@"Defines the type of execution of the call feature.")]
[DerivedFrom(typeof(CallTypeCode))]
public enum CallType1Code
{
    /// <summary>
    /// Type of execution of the call feature is a lottery.
    /// Encoded/decoded by serializers as "LOTT".
    /// </summary>
    [EnumMember(Value = "LOTT")]
    [IsoId("_ha1jv2liEeGaMcKyqKNRfQ_1557320145")]
    [Description(@"Type of execution of the call feature is a lottery.")]
    Lottery = CallTypeCode.Lottery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of execution of the call feature is pro-rata.
    /// Encoded/decoded by serializers as "PRTA".
    /// </summary>
    [EnumMember(Value = "PRTA")]
    [IsoId("_ha1jwGliEeGaMcKyqKNRfQ_-906723982")]
    [Description(@"Type of execution of the call feature is pro-rata.")]
    ProRata = CallTypeCode.ProRata, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CallType1CodeMetadataExtensions
{
    private static readonly CallType1CodeDropdownSource _dropdownSource = new CallType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICallType1CodeDropdownRow GetMetadata(this CallType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


