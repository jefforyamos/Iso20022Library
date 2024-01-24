﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventFrequency9Code.  ISO2002 ID# _kNl8ESDAEeWPMvNwVtiMsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kNl8ESDAEeWPMvNwVtiMsA")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
public enum EventFrequency9Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_kqAyUSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = EventFrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "SEMI".
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_kqAyUyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = EventFrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "QUTR".
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_kqAyVSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = EventFrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every two months.
    /// Encoded/decoded by serializers as "TOMN".
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_kqAyVyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every two months.")]
    EveryTwoMonths = EventFrequencyCode.EveryTwoMonths, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_kqAyWSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = EventFrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place two times a month.
    /// Encoded/decoded by serializers as "TWMN".
    /// </summary>
    [EnumMember(Value = "TWMN")]
    [IsoId("_kqAyWyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place two times a month.")]
    TwiceAMonth = EventFrequencyCode.TwiceAMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as "TOWK".
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("_kqAyXSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every two weeks.")]
    EveryTwoWeeks = EventFrequencyCode.EveryTwoWeeks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as "WEEK".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_kqAyXyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place once a week.")]
    Weekly = EventFrequencyCode.Weekly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as "DAIL".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_kqAyYSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every day.")]
    Daily = EventFrequencyCode.Daily, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place as necessary.
    /// Encoded/decoded by serializers as "ADHO".
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_kqAyYyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place as necessary.")]
    Adhoc = EventFrequencyCode.Adhoc, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as "INDA".
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_kqAyZSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place several times a day.")]
    IntraDay = EventFrequencyCode.IntraDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as "OVNG".
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_kqAyZyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place overnight.")]
    Overnight = EventFrequencyCode.Overnight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as "ONDE".
    /// </summary>
    [EnumMember(Value = "ONDE")]
    [IsoId("_kqAyaSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place on demand.")]
    OnDemand = EventFrequencyCode.OnDemand, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event does not take place.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_mJOiUSDAEeWPMvNwVtiMsA")]
    [Description(@"Event does not take place.")]
    None = EventFrequencyCode.None, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventFrequency9CodeMetadataExtensions
{
    private static readonly EventFrequency9CodeDropdownSource _dropdownSource = new EventFrequency9CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventFrequency9CodeDropdownRow GetMetadata(this EventFrequency9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


