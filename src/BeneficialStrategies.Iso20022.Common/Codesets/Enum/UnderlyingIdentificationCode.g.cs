﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingIdentificationCode.  ISO2002 ID# _zm6XAHZVEeWM6LeFwEMTgg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the underlying identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zm6XAHZVEeWM6LeFwEMTgg")]
[Description(@"Specifies the type of the underlying identification.")]
[Derivations(typeof(UnderlyingIdentification1Code))]
// External derivations that should be provided by the proper interface are: 
public enum UnderlyingIdentificationCode
{
    /// <summary>
    /// Unknown (not available) underlying identification code.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_7440QHZVEeWM6LeFwEMTgg")]
    [Description(@"Unknown (not available) underlying identification code.")]
    Unknown,
    
    /// <summary>
    /// Basket of indexes identification code.
    /// Encoded/decoded by serializers as "BSKT".
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_d9ZrYOa4EeW1iL_FRZt8bg")]
    [Description(@"Basket of indexes identification code.")]
    Basket,
    
    /// <summary>
    /// Index identification code.
    /// Encoded/decoded by serializers as "INDX".
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_idS-IOa4EeW1iL_FRZt8bg")]
    [Description(@"Index identification code.")]
    Index,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnderlyingIdentificationCodeMetadataExtensions
{
    private static readonly UnderlyingIdentificationCodeDropdownSource _dropdownSource = new UnderlyingIdentificationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnderlyingIdentificationCodeDropdownRow GetMetadata(this UnderlyingIdentificationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


