﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LegalRestrictions2Code.  ISO2002 ID# _haryvWliEeGaMcKyqKNRfQ_-1818058448.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regulatory restrictions applicable to a security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_haryvWliEeGaMcKyqKNRfQ_-1818058448")]
[Description(@"Specifies the regulatory restrictions applicable to a security.")]
[DerivedFrom(typeof(LegalRestrictionsCode))]
public enum LegalRestrictions2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "JurisdictionOwnership".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_haryvmliEeGaMcKyqKNRfQ_-1957716437")]
    [Description(@"??")]
    JurisdictionOwnership,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PrivatePlacements".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_haryv2liEeGaMcKyqKNRfQ_-599905481")]
    [Description(@"??")]
    PrivatePlacements,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccreditedInvestor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_harywGliEeGaMcKyqKNRfQ_867243282")]
    [Description(@"??")]
    AccreditedInvestor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Margin".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_harywWliEeGaMcKyqKNRfQ_1851192826")]
    [Description(@"??")]
    Margin,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Privilege".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_harywmliEeGaMcKyqKNRfQ_-976625707")]
    [Description(@"??")]
    Privilege,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LegalRestrictions2CodeMetadataExtensions
{
    private static readonly LegalRestrictions2CodeDropdownSource _dropdownSource = new LegalRestrictions2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILegalRestrictions2CodeDropdownRow GetMetadata(this LegalRestrictions2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


