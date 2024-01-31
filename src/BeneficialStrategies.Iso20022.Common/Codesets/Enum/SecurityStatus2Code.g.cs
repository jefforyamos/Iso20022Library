﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecurityStatus2Code.  ISO2002 ID# _haryw2liEeGaMcKyqKNRfQ_-633101692.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_haryw2liEeGaMcKyqKNRfQ_-633101692")]
[Description(@"Specifies the status of the security.")]
[DerivedFrom(typeof(SecurityStatusCode))]
public enum SecurityStatus2Code
{
    /// <summary>
    /// The status is active.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ha1jsGliEeGaMcKyqKNRfQ_1830027418")]
    [Description(@"The status is active.")]
    Active = SecurityStatusCode.Active, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The status is inactive.
    /// Encoded/decoded by serializers as "INAC".
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_ha1jsWliEeGaMcKyqKNRfQ_-1878992852")]
    [Description(@"The status is inactive.")]
    Inactive = SecurityStatusCode.Inactive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The status is suspended.
    /// Encoded/decoded by serializers as "SUSP".
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_ha1jsmliEeGaMcKyqKNRfQ_-387389187")]
    [Description(@"The status is suspended.")]
    Suspended = SecurityStatusCode.Suspended, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecurityStatus2CodeMetadataExtensions
{
    private static readonly SecurityStatus2CodeDropdownSource _dropdownSource = new SecurityStatus2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecurityStatus2CodeDropdownRow GetMetadata(this SecurityStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


