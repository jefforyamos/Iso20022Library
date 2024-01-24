﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionType7Code.  ISO2002 ID# _GC_wAaziEeaS8qpTeYtFzA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GC_wAaziEeaS8qpTeYtFzA")]
[Description(@"Type of action to be performed by the point of interaction (POI).")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType7Code
{
    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as "BUSY".
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_GS6bUaziEeaS8qpTeYtFzA")]
    [Description(@"Server busy, try later.")]
    Busy = ActionTypeCode.Busy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as "CPTR".
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_GS6bU6ziEeaS8qpTeYtFzA")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as "DISP".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_GS6bVaziEeaS8qpTeYtFzA")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application cannot propose to the merchant an override of the payment transaction.
    /// Encoded/decoded by serializers as "NOVR".
    /// </summary>
    [EnumMember(Value = "NOVR")]
    [IsoId("_GS6bV6ziEeaS8qpTeYtFzA")]
    [Description(@"Payment application cannot propose to the merchant an override of the payment transaction.")]
    ForbidOverride = ActionTypeCode.ForbidOverride, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as "RQID".
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_GS6bWaziEeaS8qpTeYtFzA")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as "PINL".
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_GS6bW6ziEeaS8qpTeYtFzA")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry = ActionTypeCode.PINLastTry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as "PINR".
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_GS6bXaziEeaS8qpTeYtFzA")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry = ActionTypeCode.PINRetry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as "PRNT".
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_GS6bX6ziEeaS8qpTeYtFzA")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as "RFRL".
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_GS6bYaziEeaS8qpTeYtFzA")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as "RQDT".
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_GS6bY6ziEeaS8qpTeYtFzA")]
    [Description(@"Request additional data through a displayed text and request confirmation by an attendant.")]
    RequestData = ActionTypeCode.RequestData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ask the cardholder to accept the currency conversion.
    /// Encoded/decoded by serializers as "DCCQ".
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_GS6bZaziEeaS8qpTeYtFzA")]
    [Description(@"Ask the cardholder to accept the currency conversion.")]
    AcceptCurrencyConversion = ActionTypeCode.AcceptCurrencyConversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fall-forward from contactless to chip card transaction required.
    /// Encoded/decoded by serializers as "FLFW".
    /// </summary>
    [EnumMember(Value = "FLFW")]
    [IsoId("_oxS7EaziEeaS8qpTeYtFzA")]
    [Description(@"Fall-forward from contactless to chip card transaction required.")]
    FallForward = ActionTypeCode.FallForward, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ActionType7CodeMetadataExtensions
{
    private static readonly ActionType7CodeDropdownSource _dropdownSource = new ActionType7CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IActionType7CodeDropdownRow GetMetadata(this ActionType7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


