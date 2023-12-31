﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FailureReason3Code.  ISO2002 ID# _QgO6ATG8EeOH78pE3LSlGw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of incidents happening at the acceptor during the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QgO6ATG8EeOH78pE3LSlGw")]
[Description(@"List of incidents happening at the acceptor during the transaction.")]
[DerivedFrom(typeof(FailureReasonCode))]
public enum FailureReason3Code
{
    /// <summary>
    /// Integrated circuit card declines the transaction before or after the authorisation.
    /// Encoded/decoded by serializers as "CardDeclined".
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_QwmRQTG8EeOH78pE3LSlGw")]
    [Description(@"Integrated circuit card declines the transaction before or after the authorisation.")]
    CardDeclined,
    
    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as "CustomerCancel".
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_QwmRQzG8EeOH78pE3LSlGw")]
    [Description(@"Customer cancellation, for example removing the card before the end of the transaction.")]
    CustomerCancel,
    
    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as "Malfunction".
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_QwmRRTG8EeOH78pE3LSlGw")]
    [Description(@"Suspected malfunction.")]
    Malfunction,
    
    /// <summary>
    /// Offline authorisation declined the transaction.
    /// Encoded/decoded by serializers as "OfflineDeclined".
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_QwmRRzG8EeOH78pE3LSlGw")]
    [Description(@"Offline authorisation declined the transaction.")]
    OfflineDeclined,
    
    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as "OnLineDeclined".
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_QwmRSTG8EeOH78pE3LSlGw")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined,
    
    /// <summary>
    /// Completed partially.
    /// Encoded/decoded by serializers as "Partial".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_QwmRSzG8EeOH78pE3LSlGw")]
    [Description(@"Completed partially.")]
    Partial,
    
    /// <summary>
    /// Card payment transaction fails because the merchant suspect a fraud.
    /// Encoded/decoded by serializers as "SuspectedFraud".
    /// </summary>
    [EnumMember(Value = "SFRD")]
    [IsoId("_QwmRTTG8EeOH78pE3LSlGw")]
    [Description(@"Card payment transaction fails because the merchant suspect a fraud.")]
    SuspectedFraud,
    
    /// <summary>
    /// Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as "TimeOut".
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_QwmRTzG8EeOH78pE3LSlGw")]
    [Description(@"Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).")]
    TimeOut,
    
    /// <summary>
    /// Response to the previous message was received too late.
    /// Encoded/decoded by serializers as "TooLateResponse".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_QwmRUTG8EeOH78pE3LSlGw")]
    [Description(@"Response to the previous message was received too late.")]
    TooLateResponse,
    
    /// <summary>
    /// Unable to complete the transaction after the authorisation response.
    /// Encoded/decoded by serializers as "UnableToComplete".
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("_QwmRUzG8EeOH78pE3LSlGw")]
    [Description(@"Unable to complete the transaction after the authorisation response.")]
    UnableToComplete,
    
    /// <summary>
    /// Unable to deliver the request message to the recipient party.
    /// Encoded/decoded by serializers as "UnableToSend".
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("_QwmRVTG8EeOH78pE3LSlGw")]
    [Description(@"Unable to deliver the request message to the recipient party.")]
    UnableToSend,
    
    /// <summary>
    /// Security error has occurred in the authorisation response message sent by the acquirer.
    /// Encoded/decoded by serializers as "SecurityError".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_SbRDUTG8EeOH78pE3LSlGw")]
    [Description(@"Security error has occurred in the authorisation response message sent by the acquirer.")]
    SecurityError,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FailureReason3CodeMetadataExtensions
{
    private static readonly FailureReason3CodeDropdownSource _dropdownSource = new FailureReason3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFailureReason3CodeDropdownRow GetMetadata(this FailureReason3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


