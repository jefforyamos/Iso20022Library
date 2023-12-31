﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FailureReasonCode.  ISO2002 ID# _TUmCFQEcEeCQm6a_G2yO_w_-1240682578.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of incidents happening during the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUmCFQEcEeCQm6a_G2yO_w_-1240682578")]
[Description(@"List of incidents happening during the transaction.")]
[Derivations(typeof(FailureReason1Code),typeof(FailureReason2Code),typeof(FailureReason3Code),typeof(FailureReason4Code),typeof(FailureReason6Code),typeof(FailureReason5Code),typeof(FailureReason8Code),typeof(FailureReason7Code))]
// External derivations that should be provided by the proper interface are: 
public enum FailureReasonCode
{
    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as "CUCL".
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_TUmCFgEcEeCQm6a_G2yO_w_737172254")]
    [Description(@"Customer cancellation, for example removing the card before the end of the transaction.")]
    CustomerCancel,
    
    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as "MALF".
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_TUmCFwEcEeCQm6a_G2yO_w_-1726871873")]
    [Description(@"Suspected malfunction.")]
    Malfunction,
    
    /// <summary>
    /// Completed partially.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_TUmCGAEcEeCQm6a_G2yO_w_-966106720")]
    [Description(@"Completed partially.")]
    Partial,
    
    /// <summary>
    /// Response to the previous message was received too late.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_TUmCGQEcEeCQm6a_G2yO_w_-512019451")]
    [Description(@"Response to the previous message was received too late.")]
    TooLateResponse,
    
    /// <summary>
    /// Unable to complete the transaction after the authorisation response.
    /// Encoded/decoded by serializers as "UCMP".
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("_TUmCGgEcEeCQm6a_G2yO_w_2011152748")]
    [Description(@"Unable to complete the transaction after the authorisation response.")]
    UnableToComplete,
    
    /// <summary>
    /// Unable to deliver the request message to the recipient party.
    /// Encoded/decoded by serializers as "USND".
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("_TUmCGwEcEeCQm6a_G2yO_w_-2009869983")]
    [Description(@"Unable to deliver the request message to the recipient party.")]
    UnableToSend,
    
    /// <summary>
    /// Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as "TIMO".
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_TUmCHAEcEeCQm6a_G2yO_w_-2020968760")]
    [Description(@"Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).")]
    TimeOut,
    
    /// <summary>
    /// Integrated circuit card declines the transaction before or after the authorisation.
    /// Encoded/decoded by serializers as "CDCL".
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_TUmCHQEcEeCQm6a_G2yO_w_-1695851253")]
    [Description(@"Integrated circuit card declines the transaction before or after the authorisation.")]
    CardDeclined,
    
    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as "NDCL".
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_TUmCHgEcEeCQm6a_G2yO_w_617410472")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined,
    
    /// <summary>
    /// Offline authorisation declined the transaction.
    /// Encoded/decoded by serializers as "FDCL".
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_TUmCHwEcEeCQm6a_G2yO_w_606311695")]
    [Description(@"Offline authorisation declined the transaction.")]
    OfflineDeclined,
    
    /// <summary>
    /// Card payment transaction fails because the merchant suspect a fraud.
    /// Encoded/decoded by serializers as "SFRD".
    /// </summary>
    [EnumMember(Value = "SFRD")]
    [IsoId("_sPZjEL4pEeKkGaJ0UrThyA_-1482930014")]
    [Description(@"Card payment transaction fails because the merchant suspect a fraud.")]
    SuspectedFraud,
    
    /// <summary>
    /// Security error has occurred in the authorisation response message sent by the acquirer.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_KurLEDG8EeOH78pE3LSlGw")]
    [Description(@"Security error has occurred in the authorisation response message sent by the acquirer.")]
    SecurityError,
    
    /// <summary>
    /// ATM manager has requested to capture the card.
    /// Encoded/decoded by serializers as "CDCP".
    /// </summary>
    [EnumMember(Value = "CDCP")]
    [IsoId("_Yn_dUIqTEeSRT5rEzcAHEw")]
    [Description(@"ATM manager has requested to capture the card.")]
    CardCaptured,
    
    /// <summary>
    /// Unable to complete transaction with the card.
    /// Encoded/decoded by serializers as "CDER".
    /// </summary>
    [EnumMember(Value = "CDER")]
    [IsoId("_cmzcQIqTEeSRT5rEzcAHEw")]
    [Description(@"Unable to complete transaction with the card.")]
    CardError,
    
    /// <summary>
    /// Customer has declined additional fees or a lower amount, transaction fails.
    /// Encoded/decoded by serializers as "CUDC".
    /// </summary>
    [EnumMember(Value = "CUDC")]
    [IsoId("_gQT5kIqTEeSRT5rEzcAHEw")]
    [Description(@"Customer has declined additional fees or a lower amount, transaction fails.")]
    CustomerDecline,
    
    /// <summary>
    /// Customer has left the card in the ATM or a motorised card reader.
    /// Encoded/decoded by serializers as "CDFG".
    /// </summary>
    [EnumMember(Value = "CDFG")]
    [IsoId("_jtJM0IqTEeSRT5rEzcAHEw")]
    [Description(@"Customer has left the card in the ATM or a motorised card reader.")]
    ForgottenCard,
    
    /// <summary>
    /// Unable to fulfil, for instance dispensing the cash.
    /// Encoded/decoded by serializers as "FILL".
    /// </summary>
    [EnumMember(Value = "FILL")]
    [IsoId("_lvYxYIqTEeSRT5rEzcAHEw")]
    [Description(@"Unable to fulfil, for instance dispensing the cash.")]
    FullfilmentError,
    
    /// <summary>
    /// ATM manager has requested to the ATM to stop customer services.
    /// Encoded/decoded by serializers as "CSRV".
    /// </summary>
    [EnumMember(Value = "CSRV")]
    [IsoId("_o1m7cIqTEeSRT5rEzcAHEw")]
    [Description(@"ATM manager has requested to the ATM to stop customer services.")]
    OutOfCustomerService,
    
    /// <summary>
    /// Unable to capture the card as requested.
    /// Encoded/decoded by serializers as "UCPT".
    /// </summary>
    [EnumMember(Value = "UCPT")]
    [IsoId("_rKquUIqTEeSRT5rEzcAHEw")]
    [Description(@"Unable to capture the card as requested.")]
    UnableToCapture,
    
    /// <summary>
    /// General security error.
    /// Encoded/decoded by serializers as "SECR".
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_t-sSgIr-EeSvuOJS0mmL0g")]
    [Description(@"General security error.")]
    Security,
    
    /// <summary>
    /// Hardware error on the device.
    /// Encoded/decoded by serializers as "HRDW".
    /// </summary>
    [EnumMember(Value = "HRDW")]
    [IsoId("_6uC6AIr-EeSvuOJS0mmL0g")]
    [Description(@"Hardware error on the device.")]
    Hardware,
    
    /// <summary>
    /// Key is compromised.
    /// Encoded/decoded by serializers as "CMPR".
    /// </summary>
    [EnumMember(Value = "CMPR")]
    [IsoId("_brHAEItDEeSxlKlAGYErFg")]
    [Description(@"Key is compromised.")]
    Compromised,
    
    /// <summary>
    /// Key has expired.
    /// Encoded/decoded by serializers as "EXPR".
    /// </summary>
    [EnumMember(Value = "EXPR")]
    [IsoId("_jBjCIItDEeSxlKlAGYErFg")]
    [Description(@"Key has expired.")]
    Expired,
    
    /// <summary>
    /// Key check value is incorrect.
    /// Encoded/decoded by serializers as "KCVE".
    /// </summary>
    [EnumMember(Value = "KCVE")]
    [IsoId("_nP21oItDEeSxlKlAGYErFg")]
    [Description(@"Key check value is incorrect.")]
    InvalidKCV,
    
    /// <summary>
    /// Error during the key download in the security device.
    /// Encoded/decoded by serializers as "KLOD".
    /// </summary>
    [EnumMember(Value = "KLOD")]
    [IsoId("_s-4N8ItDEeSxlKlAGYErFg")]
    [Description(@"Error during the key download in the security device.")]
    KeyLoadError,
    
    /// <summary>
    /// Card has been retained by the ATM or the terminal.
    /// Encoded/decoded by serializers as "CDRT".
    /// </summary>
    [EnumMember(Value = "CDRT")]
    [IsoId("_gjrA8K4LEeWZgJQOa6iKCQ")]
    [Description(@"Card has been retained by the ATM or the terminal.")]
    CardRetained,
    
    /// <summary>
    /// Customer has not been performed in time an action.
    /// Encoded/decoded by serializers as "CUTO".
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_l1L94K4LEeWZgJQOa6iKCQ")]
    [Description(@"Customer has not been performed in time an action.")]
    CustomerTimeOut,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FailureReasonCodeMetadataExtensions
{
    private static readonly FailureReasonCodeDropdownSource _dropdownSource = new FailureReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFailureReasonCodeDropdownRow GetMetadata(this FailureReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


