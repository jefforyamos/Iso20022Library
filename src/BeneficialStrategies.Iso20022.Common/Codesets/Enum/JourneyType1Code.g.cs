﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for JourneyType1Code.  ISO2002 ID# _6bmakF1jEeeu75xdwwAXQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Coach number
    /// Encoded/decoded by serializers as "COAC".
    /// </summary>
    [EnumMember(Value = "COAC")]
    [IsoId("__3usEV1jEeeu75xdwwAXQw")]
    [Description(@"Coach number")]
    CoachNumber = JourneyTypeCode.CoachNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Early arrival or departure
    /// Encoded/decoded by serializers as "EARL".
    /// </summary>
    [EnumMember(Value = "EARL")]
    [IsoId("_ALOP0l1kEeeu75xdwwAXQw")]
    [Description(@"Early arrival or departure")]
    Early = JourneyTypeCode.Early, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Flight number.
    /// Encoded/decoded by serializers as "FLGT".
    /// </summary>
    [EnumMember(Value = "FLGT")]
    [IsoId("_AXa4wl1kEeeu75xdwwAXQw")]
    [Description(@"Flight number.")]
    FlightNumber = JourneyTypeCode.FlightNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Late arrival or departure.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_AgfVMl1kEeeu75xdwwAXQw")]
    [Description(@"Late arrival or departure.")]
    Late = JourneyTypeCode.Late, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// On-time arrival or departure
    /// Encoded/decoded by serializers as "ONTM".
    /// </summary>
    [EnumMember(Value = "ONTM")]
    [IsoId("_As_gIl1kEeeu75xdwwAXQw")]
    [Description(@"On-time arrival or departure")]
    OnTime = JourneyTypeCode.OnTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of journey.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_A7kusl1kEeeu75xdwwAXQw")]
    [Description(@"Other type of journey.")]
    Other = JourneyTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Train number.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_BGlE0l1kEeeu75xdwwAXQw")]
    [Description(@"Train number.")]
    TrainNumber = JourneyTypeCode.TrainNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vessel number
    /// Encoded/decoded by serializers as "VESS".
    /// </summary>
    [EnumMember(Value = "VESS")]
    [IsoId("_BRla8l1kEeeu75xdwwAXQw")]
    [Description(@"Vessel number")]
    VesselNumber = JourneyTypeCode.VesselNumber, // same ordinal as derivation source for type conversions
    
}
