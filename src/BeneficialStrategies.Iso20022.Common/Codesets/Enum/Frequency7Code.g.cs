﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency7Code.  ISO2002 ID# _eDUHcA1nEeKGXqvMN6jpiw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eDUHcA1nEeKGXqvMN6jpiw")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency7Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_gqp9IQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as "DAIL".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_hLTMEQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_he9u8Q1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "QURT".
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_iIZGcQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "MIAN".
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_ijz3IQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every ten business days.
    /// Encoded/decoded by serializers as "TEND".
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_i8jHQQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every ten business days.")]
    TenDays = FrequencyCode.TenDays, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place at the end of the day if there was a movement on the account, otherwise nothing is sent that day.
    /// Encoded/decoded by serializers as "MOVE".
    /// </summary>
    [EnumMember(Value = "MOVE")]
    [IsoId("_jV40UQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place at the end of the day if there was a movement on the account, otherwise nothing is sent that day.")]
    TriggeredByMovement = FrequencyCode.TriggeredByMovement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as "WEEK".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_jfRZ0Q1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as "INDA".
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_BmNaYUqAEeKw5sECfP82rg")]
    [Description(@"Event takes place several times a day.")]
    IntraDay = FrequencyCode.IntraDay, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency7CodeMetadataExtensions
{
    private static readonly Frequency7CodeDropdownSource _dropdownSource = new Frequency7CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency7CodeDropdownRow GetMetadata(this Frequency7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


