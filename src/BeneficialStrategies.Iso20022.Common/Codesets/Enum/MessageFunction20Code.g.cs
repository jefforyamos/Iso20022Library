﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction20Code.  ISO2002 ID# _-KhpoFBNEeedyPuM0kK2EQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of chargeback process related to the message.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-KhpoFBNEeedyPuM0kK2EQ")]
[Description(@"Identifies the type of chargeback process related to the message. ISO 8583 MTI")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction20Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. 
    /// Encoded/decoded by serializers as "Advice".
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_xtHBAemtEemNVKPwszFC-A")]
    [Description(@"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. ")]
    Advice,
    
    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as "Notification".
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_zKVM8OmtEemNVKPwszFC-A")]
    [Description(@"Information about the transaction.")]
    Notification,
    
    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as "Request".
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_zzsTAemtEemNVKPwszFC-A")]
    [Description(@"Message function is a request.")]
    Request,
    
    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as "ReversalAdvice".
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_1H5F0emtEemNVKPwszFC-A")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice,
    
    /// <summary>
    /// Notification of reversal for either an authorisation or a financial message (response not expected).
    /// Encoded/decoded by serializers as "ReversalNotification".
    /// </summary>
    [EnumMember(Value = "RVNO")]
    [IsoId("_1rYNYemtEemNVKPwszFC-A")]
    [Description(@"Notification of reversal for either an authorisation or a financial message (response not expected).")]
    ReversalNotification,
    
    /// <summary>
    /// Advice about the status of a transaction.
    /// Encoded/decoded by serializers as "StatusAdvice".
    /// </summary>
    [EnumMember(Value = "STAD")]
    [IsoId("_3BoOoemtEemNVKPwszFC-A")]
    [Description(@"Advice about the status of a transaction.")]
    StatusAdvice,
    
    /// <summary>
    /// Notification about the status of a transaction.
    /// Encoded/decoded by serializers as "StatusNotification".
    /// </summary>
    [EnumMember(Value = "STNO")]
    [IsoId("_3I7JcemtEemNVKPwszFC-A")]
    [Description(@"Notification about the status of a transaction.")]
    StatusNotification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction20CodeMetadataExtensions
{
    private static readonly MessageFunction20CodeDropdownSource _dropdownSource = new MessageFunction20CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction20CodeDropdownRow GetMetadata(this MessageFunction20Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


