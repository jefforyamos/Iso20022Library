﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency8Code.  ISO2002 ID# _q5d88A3iEeWc7_0KPiuk6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_q5d88A3iEeWc7_0KPiuk6w")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency8Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_sPwacQ3iEeWc7_0KPiuk6w")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "MIAN".
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_socnQQ3iEeWc7_0KPiuk6w")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_uYoLcQ3iEeWc7_0KPiuk6w")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "QURT".
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_uz_40Q3iEeWc7_0KPiuk6w")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency8CodeMetadataExtensions
{
    private static readonly Frequency8CodeDropdownSource _dropdownSource = new Frequency8CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency8CodeDropdownRow GetMetadata(this Frequency8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


