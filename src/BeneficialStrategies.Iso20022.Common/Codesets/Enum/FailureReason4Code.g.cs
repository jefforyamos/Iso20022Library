﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FailureReason4Code.  ISO2002 ID# _0dFU4IqTEeSRT5rEzcAHEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Incident occurring during the processing of an ATM transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0dFU4IqTEeSRT5rEzcAHEw")]
[Description(@"Incident occurring during the processing of an ATM transaction.")]
[DerivedFrom(typeof(FailureReasonCode))]
public enum FailureReason4Code
{
    /// <summary>
    /// ATM manager has requested to capture the card.
    /// Encoded/decoded by serializers as "CardCaptured".
    /// </summary>
    [EnumMember(Value = "CDCP")]
    [IsoId("_4-wwUYqTEeSRT5rEzcAHEw")]
    [Description(@"ATM manager has requested to capture the card.")]
    CardCaptured,
    
    /// <summary>
    /// Integrated circuit card declines the transaction before or after the authorisation.
    /// Encoded/decoded by serializers as "CardDeclined".
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_5IAL44qTEeSRT5rEzcAHEw")]
    [Description(@"Integrated circuit card declines the transaction before or after the authorisation.")]
    CardDeclined,
    
    /// <summary>
    /// Unable to complete transaction with the card.
    /// Encoded/decoded by serializers as "CardError".
    /// </summary>
    [EnumMember(Value = "CDER")]
    [IsoId("_6KBCg4qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to complete transaction with the card.")]
    CardError,
    
    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as "CustomerCancel".
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_6QkWc4qTEeSRT5rEzcAHEw")]
    [Description(@"Customer cancellation, for example removing the card before the end of the transaction.")]
    CustomerCancel,
    
    /// <summary>
    /// Customer has declined additional fees or a lower amount, transaction fails.
    /// Encoded/decoded by serializers as "CustomerDecline".
    /// </summary>
    [EnumMember(Value = "CUDC")]
    [IsoId("_636DQ4qTEeSRT5rEzcAHEw")]
    [Description(@"Customer has declined additional fees or a lower amount, transaction fails.")]
    CustomerDecline,
    
    /// <summary>
    /// Customer has left the card in the ATM or a motorised card reader.
    /// Encoded/decoded by serializers as "ForgottenCard".
    /// </summary>
    [EnumMember(Value = "CDFG")]
    [IsoId("_69kmY4qTEeSRT5rEzcAHEw")]
    [Description(@"Customer has left the card in the ATM or a motorised card reader.")]
    ForgottenCard,
    
    /// <summary>
    /// Unable to fulfil, for instance dispensing the cash.
    /// Encoded/decoded by serializers as "FullfilmentError".
    /// </summary>
    [EnumMember(Value = "FILL")]
    [IsoId("_7y66A4qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to fulfil, for instance dispensing the cash.")]
    FullfilmentError,
    
    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as "Malfunction".
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_76Eq44qTEeSRT5rEzcAHEw")]
    [Description(@"Suspected malfunction.")]
    Malfunction,
    
    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as "OnLineDeclined".
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_9fja84qTEeSRT5rEzcAHEw")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined,
    
    /// <summary>
    /// Security error has occurred in the authorisation response message sent by the acquirer.
    /// Encoded/decoded by serializers as "SecurityError".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_9ucyk4qTEeSRT5rEzcAHEw")]
    [Description(@"Security error has occurred in the authorisation response message sent by the acquirer.")]
    SecurityError,
    
    /// <summary>
    /// Card payment transaction fails because the merchant suspect a fraud.
    /// Encoded/decoded by serializers as "SuspectedFraud".
    /// </summary>
    [EnumMember(Value = "SFRD")]
    [IsoId("_-wnaM4qTEeSRT5rEzcAHEw")]
    [Description(@"Card payment transaction fails because the merchant suspect a fraud.")]
    SuspectedFraud,
    
    /// <summary>
    /// Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as "TimeOut".
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_-23zM4qTEeSRT5rEzcAHEw")]
    [Description(@"Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).")]
    TimeOut,
    
    /// <summary>
    /// Response to the previous message was received too late.
    /// Encoded/decoded by serializers as "TooLateResponse".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_-8PbY4qTEeSRT5rEzcAHEw")]
    [Description(@"Response to the previous message was received too late.")]
    TooLateResponse,
    
    /// <summary>
    /// Unable to capture the card as requested.
    /// Encoded/decoded by serializers as "UnableToCapture".
    /// </summary>
    [EnumMember(Value = "UCPT")]
    [IsoId("__rK984qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to capture the card as requested.")]
    UnableToCapture,
    
    /// <summary>
    /// Unable to complete the transaction after the authorisation response.
    /// Encoded/decoded by serializers as "UnableToComplete".
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("__wF6M4qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to complete the transaction after the authorisation response.")]
    UnableToComplete,
    
    /// <summary>
    /// Unable to deliver the request message to the recipient party.
    /// Encoded/decoded by serializers as "UnableToSend".
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("__03Fc4qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to deliver the request message to the recipient party.")]
    UnableToSend,
    
    /// <summary>
    /// ATM manager has requested to the ATM to stop customer services.
    /// Encoded/decoded by serializers as "OutOfCustomerService".
    /// </summary>
    [EnumMember(Value = "CSRV")]
    [IsoId("_6sItcY6LEeSYc-j6zfGsZg")]
    [Description(@"ATM manager has requested to the ATM to stop customer services.")]
    OutOfCustomerService,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FailureReason4CodeMetadataExtensions
{
    private static readonly FailureReason4CodeDropdownSource _dropdownSource = new FailureReason4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFailureReason4CodeDropdownRow GetMetadata(this FailureReason4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


