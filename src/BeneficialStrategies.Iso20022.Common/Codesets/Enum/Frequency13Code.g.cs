﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency13Code.  ISO2002 ID# _Q5zDsFfREeqqKf65rDYWYw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_smU1IVfREeqqKf65rDYWYw")]
    [Description(@"Event takes place every day.")]
    Daily,
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_tV8UMVfREeqqKf65rDYWYw")]
    [Description(@"Event takes place once a week.")]
    Weekly,
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_t7Ir8VfREeqqKf65rDYWYw")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly,
    
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_vAULUVfREeqqKf65rDYWYw")]
    [Description(@"Event takes place every year or once a year.")]
    Annual,
    
    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as "Adhoc".
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_vg5I0VfREeqqKf65rDYWYw")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc,
    
    /// <summary>
    /// Event occurs on expiry of a financial contract.
    /// Encoded/decoded by serializers as "OnExpiry".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_v_1uoVfREeqqKf65rDYWYw")]
    [Description(@"Event occurs on expiry of a financial contract.")]
    OnExpiry,
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_dvI9UZjeEeqkLZLH6DK3UQ")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual,
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_ePuh4ZjeEeqkLZLH6DK3UQ")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly,
    
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


