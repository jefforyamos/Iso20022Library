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
    /// ??
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyUSDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    Annual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyUyDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    SemiAnnual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyVSDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    Quarterly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EveryTwoMonths".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyVyDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    EveryTwoMonths,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyWSDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    Monthly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TwiceAMonth".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyWyDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    TwiceAMonth,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EveryTwoWeeks".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyXSDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    EveryTwoWeeks,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyXyDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    Weekly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyYSDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    Daily,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Adhoc".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyYyDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    Adhoc,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntraDay".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyZSDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    IntraDay,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Overnight".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyZyDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    Overnight,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnDemand".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kqAyaSDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
    OnDemand,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "None".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mJOiUSDAEeWPMvNwVtiMsA")]
    [Description(@"??")]
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

