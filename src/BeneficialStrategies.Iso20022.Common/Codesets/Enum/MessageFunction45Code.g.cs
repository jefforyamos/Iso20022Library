﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction45Code.  ISO2002 ID# _UcdUAEGLEeyZG7AU5fJYtQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of process related to a specific message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UcdUAEGLEeyZG7AU5fJYtQ")]
[Description(@"Type of process related to a specific message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction45Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. 
    /// Encoded/decoded by serializers as "ADVC".
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_W-cvoUGLEeyZG7AU5fJYtQ")]
    [Description(@"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. ")]
    Advice = MessageFunctionCode.Advice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Informs of an action to be taken.
    /// Encoded/decoded by serializers as "INST".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_Yc5qoUGLEeyZG7AU5fJYtQ")]
    [Description(@"Informs of an action to be taken.")]
    Instructure = MessageFunctionCode.Instructure, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as "NOTI".
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_ZC56sUGLEeyZG7AU5fJYtQ")]
    [Description(@"Information about the transaction.")]
    Notification = MessageFunctionCode.Notification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as "REQU".
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_ZphOwUGLEeyZG7AU5fJYtQ")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice about the status of a transaction.
    /// Encoded/decoded by serializers as "STAD".
    /// </summary>
    [EnumMember(Value = "STAD")]
    [IsoId("_a0AE4UGLEeyZG7AU5fJYtQ")]
    [Description(@"Advice about the status of a transaction.")]
    StatusAdvice = MessageFunctionCode.StatusAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification about the status of a transaction.
    /// Encoded/decoded by serializers as "STNO".
    /// </summary>
    [EnumMember(Value = "STNO")]
    [IsoId("_bOKRUUGLEeyZG7AU5fJYtQ")]
    [Description(@"Notification about the status of a transaction.")]
    StatusNotification = MessageFunctionCode.StatusNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message function is a status request.
    /// Encoded/decoded by serializers as "STRQ".
    /// </summary>
    [EnumMember(Value = "STRQ")]
    [IsoId("_b7BXUUGLEeyZG7AU5fJYtQ")]
    [Description(@"Message function is a status request.")]
    StatusRequest = MessageFunctionCode.StatusRequest, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction45CodeMetadataExtensions
{
    private static readonly MessageFunction45CodeDropdownSource _dropdownSource = new MessageFunction45CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction45CodeDropdownRow GetMetadata(this MessageFunction45Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


