﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Endpoint1Code.  ISO2002 ID# _aAUwIINoEeuHqfO1LgkE9Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of endpoint.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aAUwIINoEeuHqfO1LgkE9Q")]
[Description(@"Defines the type of endpoint.")]
[DerivedFrom(typeof(EndpointCode))]
public enum Endpoint1Code
{
    /// <summary>
    /// Destination	
    /// Encoded/decoded by serializers as "Destination".
    /// </summary>
    [EnumMember(Value = "DEST")]
    [IsoId("_lMjYAYNoEeuHqfO1LgkE9Q")]
    [Description(@"Destination	")]
    Destination,
    
    /// <summary>
    /// Origination
    /// Encoded/decoded by serializers as "Origination".
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_lVDzwYNoEeuHqfO1LgkE9Q")]
    [Description(@"Origination")]
    Origination,
    
    /// <summary>
    /// Type specified at a private level.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_m5vSkYNoEeuHqfO1LgkE9Q")]
    [Description(@"Type specified at a private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Type specified at the national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_nJ4nYoNoEeuHqfO1LgkE9Q")]
    [Description(@"Type specified at the national level.")]
    OtherNational,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Endpoint1CodeMetadataExtensions
{
    private static readonly Endpoint1CodeDropdownSource _dropdownSource = new Endpoint1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEndpoint1CodeDropdownRow GetMetadata(this Endpoint1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


