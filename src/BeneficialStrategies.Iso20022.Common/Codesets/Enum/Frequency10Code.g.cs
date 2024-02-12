﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency10Code.  ISO2002 ID# _iotXoGoEEearR-CA7eRZXQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iotXoGoEEearR-CA7eRZXQ")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency10Code
{
    /// <summary>
    /// Event does never take place.
    /// Encoded/decoded by serializers as "NEVR".
    /// </summary>
    [EnumMember(Value = "NEVR")]
    [IsoId("_ns-iwWoEEearR-CA7eRZXQ")]
    [Description(@"Event does never take place.")]
    Never = FrequencyCode.Never, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_vQ94oWoEEearR-CA7eRZXQ")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place based on a change of a rate.
    /// Encoded/decoded by serializers as "RATE".
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_5MNZwWoEEearR-CA7eRZXQ")]
    [Description(@"Event takes place based on a change of a rate.")]
    Rate = FrequencyCode.Rate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "MIAN".
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_6xlcIWoEEearR-CA7eRZXQ")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "QURT".
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_7SZDIWoEEearR-CA7eRZXQ")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
}
