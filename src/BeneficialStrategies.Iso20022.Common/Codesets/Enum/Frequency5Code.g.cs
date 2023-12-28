﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency5Code.  ISO2002 ID# _hbu7kmliEeGaMcKyqKNRfQ_-977508560.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbu7kmliEeGaMcKyqKNRfQ_-977508560")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7k2liEeGaMcKyqKNRfQ_-1438179665")]
    [Description(@"??")]
    Annual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7lGliEeGaMcKyqKNRfQ_28969098")]
    [Description(@"??")]
    Monthly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7lWliEeGaMcKyqKNRfQ_-387046593")]
    [Description(@"??")]
    Quarterly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7lmliEeGaMcKyqKNRfQ_2064051714")]
    [Description(@"??")]
    SemiAnnual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7l2liEeGaMcKyqKNRfQ_-763766819")]
    [Description(@"??")]
    Weekly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7mGliEeGaMcKyqKNRfQ_-1776828313")]
    [Description(@"??")]
    Daily,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Adhoc".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7mWliEeGaMcKyqKNRfQ_-309679550")]
    [Description(@"??")]
    Adhoc,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntraDay".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7mmliEeGaMcKyqKNRfQ_-1787927090")]
    [Description(@"??")]
    IntraDay,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Overnight".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7m2liEeGaMcKyqKNRfQ_1290212806")]
    [Description(@"??")]
    Overnight,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TenDays".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7nGliEeGaMcKyqKNRfQ_1176373740")]
    [Description(@"??")]
    TenDays,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency5CodeMetadataExtensions
{
    private static readonly Frequency5CodeDropdownSource _dropdownSource = new Frequency5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency5CodeDropdownRow GetMetadata(this Frequency5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


