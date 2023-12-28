﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RequestModeType1Code.  ISO2002 ID# _rDVVUMm4EeWAGphE2LvqeA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the combination of mode and type of the query information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rDVVUMm4EeWAGphE2LvqeA")]
[Description(@"Specifies the combination of mode and type of the query information.")]
[DerivedFrom(typeof(RequestModeTypeCode))]
public enum RequestModeType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Forecast".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qNDQwcm8EeWAGphE2LvqeA")]
    [Description(@"??")]
    Forecast,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnDemandDayInformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qcFLQsm8EeWAGphE2LvqeA")]
    [Description(@"??")]
    OnDemandDayInformation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnDemandFutureInformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qfzNocm8EeWAGphE2LvqeA")]
    [Description(@"??")]
    OnDemandFutureInformation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ScheduledDayInformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qscigsm8EeWAGphE2LvqeA")]
    [Description(@"??")]
    ScheduledDayInformation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ScheduledFutureInformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qtfEUcm8EeWAGphE2LvqeA")]
    [Description(@"??")]
    ScheduledFutureInformation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RequestModeType1CodeMetadataExtensions
{
    private static readonly RequestModeType1CodeDropdownSource _dropdownSource = new RequestModeType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRequestModeType1CodeDropdownRow GetMetadata(this RequestModeType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


