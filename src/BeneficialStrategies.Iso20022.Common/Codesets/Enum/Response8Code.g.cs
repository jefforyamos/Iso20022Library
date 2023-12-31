﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Response8Code.  ISO2002 ID# _cKXU0Ji4EeefZKJHxQTztg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Response codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cKXU0Ji4EeefZKJHxQTztg")]
[Description(@"Response codes.")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response8Code
{
    /// <summary>
    /// Advice message is processed.
    /// Encoded/decoded by serializers as "Processed".
    /// </summary>
    [EnumMember(Value = "PRCS")]
    [IsoId("_jM8mwZi4EeefZKJHxQTztg")]
    [Description(@"Advice message is processed.")]
    Processed,
    
    /// <summary>
    /// Advice message could not be processed.
    /// Encoded/decoded by serializers as "NotProcessed".
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_kcIWspi4EeefZKJHxQTztg")]
    [Description(@"Advice message could not be processed.")]
    NotProcessed,
    
    /// <summary>
    /// Service is under review.
    /// Encoded/decoded by serializers as "UnderReview".
    /// </summary>
    [EnumMember(Value = "UNRV")]
    [IsoId("_pd2kIZi4EeefZKJHxQTztg")]
    [Description(@"Service is under review.")]
    UnderReview,
    
    /// <summary>
    /// Service was rejected.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_pytZ0pi4EeefZKJHxQTztg")]
    [Description(@"Service was rejected.")]
    Rejected,
    
    /// <summary>
    /// Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem).
    /// Encoded/decoded by serializers as "TechnicalError".
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_tmwTMpi4EeefZKJHxQTztg")]
    [Description(@"Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem).")]
    TechnicalError,
    
    /// <summary>
    /// Other type of processing result defined at national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_2vGpgfB1EeelHbulxf2Z9A")]
    [Description(@"Other type of processing result defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of processing result defined at private level.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_25X_0fB1EeelHbulxf2Z9A")]
    [Description(@"Other type of processing result defined at private level.")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Response8CodeMetadataExtensions
{
    private static readonly Response8CodeDropdownSource _dropdownSource = new Response8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResponse8CodeDropdownRow GetMetadata(this Response8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


