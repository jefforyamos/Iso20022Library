﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LocationCode.  ISO2002 ID# _s14uMKHnEeagRbKvRt3LnA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a location.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_s14uMKHnEeagRbKvRt3LnA")]
[Description(@"Specifies a location.")]
public enum LocationCode
{
    /// <summary>
    /// At my institution.
    /// Encoded/decoded by serializers as "MYIN".
    /// </summary>
    [EnumMember(Value = "MYIN")]
    [IsoId("_wrAloKHnEeagRbKvRt3LnA")]
    [Description(@"At my institution.")]
    AtMyInstitution,
    
    /// <summary>
    /// At another institution
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-A-hMKHnEeagRbKvRt3LnA")]
    [Description(@"At another institution")]
    AtAnotherInstitution,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LocationCodeMetadataExtensions
{
    private static readonly LocationCodeDropdownSource _dropdownSource = new LocationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILocationCodeDropdownRow GetMetadata(this LocationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


