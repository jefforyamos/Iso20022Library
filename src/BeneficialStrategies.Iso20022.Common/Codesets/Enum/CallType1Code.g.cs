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
    /// ??
    /// Encoded/decoded by serializers as "Lottery".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ha1jv2liEeGaMcKyqKNRfQ_1557320145")]
    [Description(@"??")]
    Lottery,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProRata".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ha1jwGliEeGaMcKyqKNRfQ_-906723982")]
    [Description(@"??")]
    ProRata,
    
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


