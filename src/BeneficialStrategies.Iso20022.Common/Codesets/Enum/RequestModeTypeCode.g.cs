﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RequestModeTypeCode.  ISO2002 ID# _m8c_gMm4EeWAGphE2LvqeA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the combination of mode and type of the query information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m8c_gMm4EeWAGphE2LvqeA")]
[Description(@"Specifies the combination of mode and type of the query information.")]
[Derivations(typeof(RequestModeType1Code))]
public enum RequestModeTypeCode
{
    /// <summary>
    /// Day information query type, in on-demand mode.
    /// Encoded/decoded by serializers as "ONDD".
    /// </summary>
    [EnumMember(Value = "ONDD")]
    [IsoId("_Maj4YMm8EeWAGphE2LvqeA")]
    [Description(@"Day information query type, in on-demand mode.")]
    OnDemandDayInformation,
    
    /// <summary>
    /// Future information query type, in on-demand mode.
    /// Encoded/decoded by serializers as "ONDF".
    /// </summary>
    [EnumMember(Value = "ONDF")]
    [IsoId("_MkFAwMm8EeWAGphE2LvqeA")]
    [Description(@"Future information query type, in on-demand mode.")]
    OnDemandFutureInformation,
    
    /// <summary>
    /// Day information query type, in scheduled mode.
    /// Encoded/decoded by serializers as "SCHD".
    /// </summary>
    [EnumMember(Value = "SCHD")]
    [IsoId("_Mtv6IMm8EeWAGphE2LvqeA")]
    [Description(@"Day information query type, in scheduled mode.")]
    ScheduledDayInformation,
    
    /// <summary>
    /// Future information query type, in scheduled mode.
    /// Encoded/decoded by serializers as "SCHF".
    /// </summary>
    [EnumMember(Value = "SCHF")]
    [IsoId("_M209oMm8EeWAGphE2LvqeA")]
    [Description(@"Future information query type, in scheduled mode.")]
    ScheduledFutureInformation,
    
    /// <summary>
    /// Forecast query type and mode.
    /// Encoded/decoded by serializers as "FCST".
    /// </summary>
    [EnumMember(Value = "FCST")]
    [IsoId("_M-RCYMm8EeWAGphE2LvqeA")]
    [Description(@"Forecast query type and mode.")]
    Forecast,
    
}
