﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionType3Code.  ISO2002 ID# _3I4WYTGeEeO118ZQJgaQSQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3I4WYTGeEeO118ZQJgaQSQ")]
[Description(@"Type of action to be performed by the point of interaction (POI).")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType3Code
{
    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as "Busy".
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_3ZsZkTGeEeO118ZQJgaQSQ")]
    [Description(@"Server busy, try later.")]
    Busy,
    
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as "CaptureCard".
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_3ZsZkzGeEeO118ZQJgaQSQ")]
    [Description(@"Capture the card.")]
    CaptureCard,
    
    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as "DisplayMessage".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_3ZsZlTGeEeO118ZQJgaQSQ")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage,
    
    /// <summary>
    /// Payment application cannot propose to the merchant an override of the payment transaction.
    /// Encoded/decoded by serializers as "ForbidOverride".
    /// </summary>
    [EnumMember(Value = "NOVR")]
    [IsoId("_3ZsZlzGeEeO118ZQJgaQSQ")]
    [Description(@"Payment application cannot propose to the merchant an override of the payment transaction.")]
    ForbidOverride,
    
    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as "IdentificationRequired".
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_3ZsZmTGeEeO118ZQJgaQSQ")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired,
    
    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as "PINLastTry".
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_3ZsZmzGeEeO118ZQJgaQSQ")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry,
    
    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as "PINRetry".
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_3ZsZnTGeEeO118ZQJgaQSQ")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry,
    
    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as "PrintMessage".
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_3ZsZnzGeEeO118ZQJgaQSQ")]
    [Description(@"Print a message.")]
    PrintMessage,
    
    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as "Referral".
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_3ZsZoTGeEeO118ZQJgaQSQ")]
    [Description(@"Referral has to be performed.")]
    Referral,
    
    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as "RequestData".
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_3ZsZozGeEeO118ZQJgaQSQ")]
    [Description(@"Request additional data through a displayed text and request confirmation by an attendant.")]
    RequestData,
    
    /// <summary>
    /// Ask the cardholder to accept the currency conversion.
    /// Encoded/decoded by serializers as "AcceptCurrencyConversion".
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_450IgTGeEeO118ZQJgaQSQ")]
    [Description(@"Ask the cardholder to accept the currency conversion.")]
    AcceptCurrencyConversion,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ActionType3CodeMetadataExtensions
{
    private static readonly ActionType3CodeDropdownSource _dropdownSource = new ActionType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IActionType3CodeDropdownRow GetMetadata(this ActionType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


