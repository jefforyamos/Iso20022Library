﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for JourneyType1Code.  ISO2002 ID# _6bmakF1jEeeu75xdwwAXQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of journey related to a car rental reservation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6bmakF1jEeeu75xdwwAXQw")]
[Description(@"Type of journey related to a car rental reservation.")]
[DerivedFrom(typeof(JourneyTypeCode))]
public enum JourneyType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CoachNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__3usEV1jEeeu75xdwwAXQw")]
    [Description(@"??")]
    CoachNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Early".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ALOP0l1kEeeu75xdwwAXQw")]
    [Description(@"??")]
    Early,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FlightNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AXa4wl1kEeeu75xdwwAXQw")]
    [Description(@"??")]
    FlightNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Late".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AgfVMl1kEeeu75xdwwAXQw")]
    [Description(@"??")]
    Late,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnTime".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_As_gIl1kEeeu75xdwwAXQw")]
    [Description(@"??")]
    OnTime,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_A7kusl1kEeeu75xdwwAXQw")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TrainNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BGlE0l1kEeeu75xdwwAXQw")]
    [Description(@"??")]
    TrainNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VesselNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BRla8l1kEeeu75xdwwAXQw")]
    [Description(@"??")]
    VesselNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class JourneyType1CodeMetadataExtensions
{
    private static readonly JourneyType1CodeDropdownSource _dropdownSource = new JourneyType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IJourneyType1CodeDropdownRow GetMetadata(this JourneyType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


