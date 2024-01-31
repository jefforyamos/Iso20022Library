﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency13Code.  ISO2002 ID# _Q5zDsFfREeqqKf65rDYWYw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the frequency of an interest payment with a time unit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q5zDsFfREeqqKf65rDYWYw")]
[Description(@"Specifies the frequency of an interest payment with a time unit.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency13Code
{
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as "DAIL".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_smU1IVfREeqqKf65rDYWYw")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as "WEEK".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_tV8UMVfREeqqKf65rDYWYw")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_t7Ir8VfREeqqKf65rDYWYw")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_vAULUVfREeqqKf65rDYWYw")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as "ADHO".
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_vg5I0VfREeqqKf65rDYWYw")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc = FrequencyCode.Adhoc, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event occurs on expiry of a financial contract.
    /// Encoded/decoded by serializers as "EXPI".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_v_1uoVfREeqqKf65rDYWYw")]
    [Description(@"Event occurs on expiry of a financial contract.")]
    OnExpiry = FrequencyCode.OnExpiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "MIAN".
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_dvI9UZjeEeqkLZLH6DK3UQ")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "QURT".
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_ePuh4ZjeEeqkLZLH6DK3UQ")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency13CodeMetadataExtensions
{
    private static readonly Frequency13CodeDropdownSource _dropdownSource = new Frequency13CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency13CodeDropdownRow GetMetadata(this Frequency13Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


