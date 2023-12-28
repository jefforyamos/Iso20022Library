﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for JourneyTypeCode.  ISO2002 ID# _LnTHAF1jEeeu75xdwwAXQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Journey type data in a car rental service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LnTHAF1jEeeu75xdwwAXQw")]
[Description(@"Journey type data in a car rental service.")]
public enum JourneyTypeCode
{
    /// <summary>
    /// Early arrival or departure
    /// Encoded/decoded by serializers as "EARL".
    /// </summary>
    [EnumMember(Value = "EARL")]
    [IsoId("_SeCVUF1jEeeu75xdwwAXQw")]
    [Description(@"Early arrival or departure")]
    Early,
    
    /// <summary>
    /// Late arrival or departure.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_WazF0F1jEeeu75xdwwAXQw")]
    [Description(@"Late arrival or departure.")]
    Late,
    
    /// <summary>
    /// On-time arrival or departure
    /// Encoded/decoded by serializers as "ONTM".
    /// </summary>
    [EnumMember(Value = "ONTM")]
    [IsoId("_Y7xNwF1jEeeu75xdwwAXQw")]
    [Description(@"On-time arrival or departure")]
    OnTime,
    
    /// <summary>
    /// Coach number
    /// Encoded/decoded by serializers as "COAC".
    /// </summary>
    [EnumMember(Value = "COAC")]
    [IsoId("_grfSgF1jEeeu75xdwwAXQw")]
    [Description(@"Coach number")]
    CoachNumber,
    
    /// <summary>
    /// Train number.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_nuaisF1jEeeu75xdwwAXQw")]
    [Description(@"Train number.")]
    TrainNumber,
    
    /// <summary>
    /// Flight number.
    /// Encoded/decoded by serializers as "FLGT".
    /// </summary>
    [EnumMember(Value = "FLGT")]
    [IsoId("_ryLTEF1jEeeu75xdwwAXQw")]
    [Description(@"Flight number.")]
    FlightNumber,
    
    /// <summary>
    /// Vessel number
    /// Encoded/decoded by serializers as "VESS".
    /// </summary>
    [EnumMember(Value = "VESS")]
    [IsoId("_w5B4IF1jEeeu75xdwwAXQw")]
    [Description(@"Vessel number")]
    VesselNumber,
    
    /// <summary>
    /// Other type of journey.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0sIWUF1jEeeu75xdwwAXQw")]
    [Description(@"Other type of journey.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class JourneyTypeCodeMetadataExtensions
{
    private static readonly JourneyTypeCodeDropdownSource _dropdownSource = new JourneyTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IJourneyTypeCodeDropdownRow GetMetadata(this JourneyTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

