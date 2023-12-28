﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResponseMode2Code.  ISO2002 ID# _eaMsoFDiEeuzhPLt3qllKA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Message response awaited by the initiator of the Request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eaMsoFDiEeuzhPLt3qllKA")]
[Description(@"Message response awaited by the initiator of the Request.")]
[DerivedFrom(typeof(ResponseModeV2Code))]
public enum ResponseMode2Code
{
    /// <summary>
    /// The Response is required at the end of play.
    /// Encoded/decoded by serializers as "EndOfPlay".
    /// </summary>
    [EnumMember(Value = "SEND")]
    [IsoId("_25zPEVDiEeuzhPLt3qllKA")]
    [Description(@"The Response is required at the end of play.")]
    EndOfPlay,
    
    /// <summary>
    /// The Message Response is immediate, after taking into account the request.
    /// Encoded/decoded by serializers as "Immediate".
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_3A8_8VDiEeuzhPLt3qllKA")]
    [Description(@"The Message Response is immediate, after taking into account the request.")]
    Immediate,
    
    /// <summary>
    /// The Message Response is not required, except in case of error.
    /// Encoded/decoded by serializers as "NotRequired".
    /// </summary>
    [EnumMember(Value = "NREQ")]
    [IsoId("_3W2XcVDiEeuzhPLt3qllKA")]
    [Description(@"The Message Response is not required, except in case of error.")]
    NotRequired,
    
    /// <summary>
    /// The Print Response is required at the end of print.
    /// Encoded/decoded by serializers as "PrintEnd".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_3qhhYVDiEeuzhPLt3qllKA")]
    [Description(@"The Print Response is required at the end of print.")]
    PrintEnd,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResponseMode2CodeMetadataExtensions
{
    private static readonly ResponseMode2CodeDropdownSource _dropdownSource = new ResponseMode2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResponseMode2CodeDropdownRow GetMetadata(this ResponseMode2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


