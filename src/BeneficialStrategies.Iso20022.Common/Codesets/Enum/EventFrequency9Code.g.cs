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
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_kqAyUSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every year or once a year.")]
    Annual,
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_kqAyUyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual,
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_kqAyVSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly,
    
    /// <summary>
    /// Event takes place every two months.
    /// Encoded/decoded by serializers as "EveryTwoMonths".
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_kqAyVyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every two months.")]
    EveryTwoMonths,
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_kqAyWSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly,
    
    /// <summary>
    /// Event takes place two times a month.
    /// Encoded/decoded by serializers as "TwiceAMonth".
    /// </summary>
    [EnumMember(Value = "TWMN")]
    [IsoId("_kqAyWyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place two times a month.")]
    TwiceAMonth,
    
    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as "EveryTwoWeeks".
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("_kqAyXSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every two weeks.")]
    EveryTwoWeeks,
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_kqAyXyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place once a week.")]
    Weekly,
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_kqAyYSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every day.")]
    Daily,
    
    /// <summary>
    /// Event takes place as necessary.
    /// Encoded/decoded by serializers as "Adhoc".
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_kqAyYyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place as necessary.")]
    Adhoc,
    
    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as "IntraDay".
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_kqAyZSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place several times a day.")]
    IntraDay,
    
    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as "Overnight".
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_kqAyZyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place overnight.")]
    Overnight,
    
    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as "OnDemand".
    /// </summary>
    [EnumMember(Value = "ONDE")]
    [IsoId("_kqAyaSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place on demand.")]
    OnDemand,
    
    /// <summary>
    /// Event does not take place.
    /// Encoded/decoded by serializers as "None".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_mJOiUSDAEeWPMvNwVtiMsA")]
    [Description(@"Event does not take place.")]
    None,
    
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


