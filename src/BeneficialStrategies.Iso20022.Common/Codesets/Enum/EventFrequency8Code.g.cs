﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventFrequency8Code.  ISO2002 ID# _nYW2IBUREeOIaq8KyCdIDQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nYW2IBUREeOIaq8KyCdIDQ")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
public enum EventFrequency8Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Adhoc".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_p8wskRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    Adhoc,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qEpdQRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    Annual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qSx_4RUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    Daily,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EveryFourMonths".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qaE6sRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    EveryFourMonths,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EveryTwoMonths".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qh9rYRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    EveryTwoMonths,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EveryTwoWeeks".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qrxusRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    EveryTwoWeeks,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EveryTwoYears".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q1mZERUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    EveryTwoYears,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntraDay".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rBp4ERUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    IntraDay,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rJY3wRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    Monthly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnDemand".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rSw2MRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    OnDemand,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Overnight".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rZTjERUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    Overnight,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rhyJoRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    Quarterly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rpOOYRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    SemiAnnual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TwiceAMonth".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rwOOQRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    TwiceAMonth,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r2nxMRUREeOIaq8KyCdIDQ")]
    [Description(@"??")]
    Weekly,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventFrequency8CodeMetadataExtensions
{
    private static readonly EventFrequency8CodeDropdownSource _dropdownSource = new EventFrequency8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventFrequency8CodeDropdownRow GetMetadata(this EventFrequency8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


