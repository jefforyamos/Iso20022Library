﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecurityStatus1Code.  ISO2002 ID# _ZJ8lGdp-Ed-ak6NoX_4Aeg_-70866940.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Denotes the current state of the Instrument (Used for derivatives).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZJ8lGdp-Ed-ak6NoX_4Aeg_-70866940")]
[Description(@"Denotes the current state of the Instrument (Used for derivatives).")]
[DerivedFrom(typeof(SecurityStatusCode))]
public enum SecurityStatus1Code
{
    /// <summary>
    /// The status is active.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZKGWENp-Ed-ak6NoX_4Aeg_243065")]
    [Description(@"The status is active.")]
    Active = SecurityStatusCode.Active, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The status is inactive.
    /// Encoded/decoded by serializers as "INAC".
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_ZKGWEdp-Ed-ak6NoX_4Aeg_243066")]
    [Description(@"The status is inactive.")]
    Inactive = SecurityStatusCode.Inactive, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecurityStatus1CodeMetadataExtensions
{
    private static readonly SecurityStatus1CodeDropdownSource _dropdownSource = new SecurityStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecurityStatus1CodeDropdownRow GetMetadata(this SecurityStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


