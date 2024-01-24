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
    /// Encoded/decoded by serializers as "DEST".
    /// </summary>
    [EnumMember(Value = "DEST")]
    [IsoId("_lMjYAYNoEeuHqfO1LgkE9Q")]
    [Description(@"Destination	")]
    Destination = EndpointCode.Destination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Origination
    /// Encoded/decoded by serializers as "ORIG".
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_lVDzwYNoEeuHqfO1LgkE9Q")]
    [Description(@"Origination")]
    Origination = EndpointCode.Origination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type specified at a private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_m5vSkYNoEeuHqfO1LgkE9Q")]
    [Description(@"Type specified at a private level.")]
    OtherPrivate = EndpointCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type specified at the national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_nJ4nYoNoEeuHqfO1LgkE9Q")]
    [Description(@"Type specified at the national level.")]
    OtherNational = EndpointCode.OtherNational, // same ordinal as derivation source for type conversions
    
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


