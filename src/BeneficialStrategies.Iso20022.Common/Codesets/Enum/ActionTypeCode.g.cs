﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionTypeCode.  ISO2002 ID# _TVpK8gEcEeCQm6a_G2yO_w_-1860538994.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to be performed by the POI system (Point Of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVpK8gEcEeCQm6a_G2yO_w_-1860538994")]
[Description(@"Type of action to be performed by the POI system (Point Of Interaction).")]
public enum ActionTypeCode
{
    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as "DISP".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_TVpK8wEcEeCQm6a_G2yO_w_58711460")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage,
    
    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as "PRNT".
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_TVpK9AEcEeCQm6a_G2yO_w_-1633468737")]
    [Description(@"Print a message.")]
    PrintMessage,
    
    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as "RFRL".
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_TVpK9QEcEeCQm6a_G2yO_w_-1644567514")]
    [Description(@"Referral has to be performed.")]
    Referral,
    
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as "CPTR".
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_TVpK9gEcEeCQm6a_G2yO_w_-1012361573")]
    [Description(@"Capture the card.")]
    CaptureCard,
    
    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as "PINR".
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_TVpK9wEcEeCQm6a_G2yO_w_-1309647834")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry,
    
    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as "PINL".
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_TVpK-AEcEeCQm6a_G2yO_w_1606636519")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry,
    
    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as "RQDT".
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_TVpK-QEcEeCQm6a_G2yO_w_1931754026")]
    [Description(@"Request additional data through a displayed text and request confirmation by an attendant.")]
    RequestData,
    
    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as "BUSY".
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_TVpK-gEcEeCQm6a_G2yO_w_-1285192932")]
    [Description(@"Server busy, try later.")]
    Busy,
    
    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as "RQID".
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_TVpK-wEcEeCQm6a_G2yO_w_-78202832")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired,
    
    /// <summary>
    /// Payment application cannot propose to the merchant an override of the payment transaction.
    /// Encoded/decoded by serializers as "NOVR".
    /// </summary>
    [EnumMember(Value = "NOVR")]
    [IsoId("_sP2PA74pEeKkGaJ0UrThyA_114350008")]
    [Description(@"Payment application cannot propose to the merchant an override of the payment transaction.")]
    ForbidOverride,
    
    /// <summary>
    /// Ask the cardholder to accept the currency conversion.
    /// Encoded/decoded by serializers as "DCCQ".
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_nwcz0DGeEeO118ZQJgaQSQ")]
    [Description(@"Ask the cardholder to accept the currency conversion.")]
    AcceptCurrencyConversion,
    
    /// <summary>
    /// Decline the transaction.
    /// Encoded/decoded by serializers as "DCLN".
    /// </summary>
    [EnumMember(Value = "DCLN")]
    [IsoId("_d8V8oHsNEeSR68OJvMfxJQ")]
    [Description(@"Decline the transaction.")]
    Decline,
    
    /// <summary>
    /// Track provided in the response must be updated on the card.
    /// Encoded/decoded by serializers as "TRCK".
    /// </summary>
    [EnumMember(Value = "TRCK")]
    [IsoId("_Rq5wAHuYEeSVeNXcmBQ4hQ")]
    [Description(@"Track provided in the response must be updated on the card.")]
    UpdateTrack,
    
    /// <summary>
    /// MinimumAmount must be accepted.
    /// Encoded/decoded by serializers as "HAMT".
    /// </summary>
    [EnumMember(Value = "HAMT")]
    [IsoId("_TXguEIqGEeSRT5rEzcAHEw")]
    [Description(@"MinimumAmount must be accepted.")]
    AcceptHigherAmount,
    
    /// <summary>
    /// MaximumAuthorisedAmount must be accepted.
    /// Encoded/decoded by serializers as "LAMT".
    /// </summary>
    [EnumMember(Value = "LAMT")]
    [IsoId("_VoM-UIqGEeSRT5rEzcAHEw")]
    [Description(@"MaximumAuthorisedAmount must be accepted.")]
    AcceptLowerAmount,
    
    /// <summary>
    /// Fees must be accepted.
    /// Encoded/decoded by serializers as "FEES".
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_YWQgAIqGEeSRT5rEzcAHEw")]
    [Description(@"Fees must be accepted.")]
    AcceptFees,
    
    /// <summary>
    /// Distribute a coupon from the cassette of coupon.
    /// Encoded/decoded by serializers as "CPNS".
    /// </summary>
    [EnumMember(Value = "CPNS")]
    [IsoId("_fXFecIqGEeSRT5rEzcAHEw")]
    [Description(@"Distribute a coupon from the cassette of coupon.")]
    DistributeCoupon,
    
    /// <summary>
    /// Request to be performed by the ATM.
    /// Encoded/decoded by serializers as "RQST".
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("_h_d18IqGEeSRT5rEzcAHEw")]
    [Description(@"Request to be performed by the ATM.")]
    PerformRequest,
    
    /// <summary>
    /// No reason for declining the transaction.
    /// Encoded/decoded by serializers as "NDCL".
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_0oDfQC6pEeWc7f-D6ByqMg")]
    [Description(@"No reason for declining the transaction.")]
    NoReasonForDecline,
    
    /// <summary>
    /// Block the card.
    /// Encoded/decoded by serializers as "BLCK".
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_7z6pAC6pEeWc7f-D6ByqMg")]
    [Description(@"Block the card.")]
    BlockCard,
    
    /// <summary>
    /// Approve the transaction.
    /// Encoded/decoded by serializers as "APPV".
    /// </summary>
    [EnumMember(Value = "APPV")]
    [IsoId("_DNih8C6qEeWc7f-D6ByqMg")]
    [Description(@"Approve the transaction.")]
    Approve,
    
    /// <summary>
    /// Fall-forward from contactless to chip card transaction required.
    /// Encoded/decoded by serializers as "FLFW".
    /// </summary>
    [EnumMember(Value = "FLFW")]
    [IsoId("_eUqkIKziEeaS8qpTeYtFzA")]
    [Description(@"Fall-forward from contactless to chip card transaction required.")]
    FallForward,
    
    /// <summary>
    /// Other action defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_5fBlEErBEeenp6hmNprBHg")]
    [Description(@"Other action defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other action defined at private level
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_-FKCsErBEeenp6hmNprBHg")]
    [Description(@"Other action defined at private level")]
    OtherPrivate,
    
    /// <summary>
    /// Cardholder verification through a third party.
    /// Encoded/decoded by serializers as "ACVF".
    /// </summary>
    [EnumMember(Value = "ACVF")]
    [IsoId("_HfK1IE0qEeea0Mdu1TOzDQ")]
    [Description(@"Cardholder verification through a third party.")]
    AgentCardholderVerification,
    
    /// <summary>
    /// Card verification through a third party.
    /// Encoded/decoded by serializers as "AGCV".
    /// </summary>
    [EnumMember(Value = "AGCV")]
    [IsoId("_OJ_HUE0qEeea0Mdu1TOzDQ")]
    [Description(@"Card verification through a third party.")]
    AgentCardVerification,
    
    /// <summary>
    /// Cardholder authentication through a third party
    /// Encoded/decoded by serializers as "AGCA".
    /// </summary>
    [EnumMember(Value = "AGCA")]
    [IsoId("_YyWNIE0qEeea0Mdu1TOzDQ")]
    [Description(@"Cardholder authentication through a third party")]
    AgentCardholderAuthentication,
    
    /// <summary>
    /// Card authentication through a third party.
    /// Encoded/decoded by serializers as "ACAU".
    /// </summary>
    [EnumMember(Value = "ACAU")]
    [IsoId("_fhm6cE0qEeea0Mdu1TOzDQ")]
    [Description(@"Card authentication through a third party.")]
    AgentCardAuthentication,
    
    /// <summary>
    /// Additional verification of cardholder required.
    /// Encoded/decoded by serializers as "CHDV".
    /// </summary>
    [EnumMember(Value = "CHDV")]
    [IsoId("_rhNgAE0qEeea0Mdu1TOzDQ")]
    [Description(@"Additional verification of cardholder required.")]
    CardholderVerification,
    
    /// <summary>
    /// Additional verification of card required.
    /// Encoded/decoded by serializers as "CAVF".
    /// </summary>
    [EnumMember(Value = "CAVF")]
    [IsoId("_xu9bsE0qEeea0Mdu1TOzDQ")]
    [Description(@"Additional verification of card required.")]
    CardVerification,
    
    /// <summary>
    /// Additional authentication of cardholder required.
    /// Encoded/decoded by serializers as "CHDA".
    /// </summary>
    [EnumMember(Value = "CHDA")]
    [IsoId("_59PrwE0qEeea0Mdu1TOzDQ")]
    [Description(@"Additional authentication of cardholder required.")]
    CardholderAuthentication,
    
    /// <summary>
    /// Additional authentication of card required.
    /// Encoded/decoded by serializers as "CAAU".
    /// </summary>
    [EnumMember(Value = "CAAU")]
    [IsoId("_CsHgYE0rEeea0Mdu1TOzDQ")]
    [Description(@"Additional authentication of card required.")]
    CardAuthentication,
    
    /// <summary>
    /// Increments and/or decrements to current reservations not supported.
    /// Encoded/decoded by serializers as "IDNS".
    /// </summary>
    [EnumMember(Value = "IDNS")]
    [IsoId("_QHHs8E0rEeea0Mdu1TOzDQ")]
    [Description(@"Increments and/or decrements to current reservations not supported.")]
    IncDecNotSupported,
    
    /// <summary>
    /// Additional verification of cardholder by card issuer required.
    /// Encoded/decoded by serializers as "ICVF".
    /// </summary>
    [EnumMember(Value = "ICVF")]
    [IsoId("_edMaoE0rEeea0Mdu1TOzDQ")]
    [Description(@"Additional verification of cardholder by card issuer required.")]
    IssuerCardholderVerification,
    
    /// <summary>
    /// Additional verification of card by card issuer required.
    /// Encoded/decoded by serializers as "ICDV".
    /// </summary>
    [EnumMember(Value = "ICDV")]
    [IsoId("_mFlvYE0rEeea0Mdu1TOzDQ")]
    [Description(@"Additional verification of card by card issuer required.")]
    IssuerCardVerfification,
    
    /// <summary>
    /// Additional authentication of the cardholder by the card issuer required.
    /// Encoded/decoded by serializers as "ICHA".
    /// </summary>
    [EnumMember(Value = "ICHA")]
    [IsoId("_toe5EE0rEeea0Mdu1TOzDQ")]
    [Description(@"Additional authentication of the cardholder by the card issuer required.")]
    IssuerCardholderAuthentication,
    
    /// <summary>
    /// Additional authentication of card by the card issuer required.
    /// Encoded/decoded by serializers as "ICAA".
    /// </summary>
    [EnumMember(Value = "ICAA")]
    [IsoId("_5zJfIE0rEeea0Mdu1TOzDQ")]
    [Description(@"Additional authentication of card by the card issuer required.")]
    IssuerCardAuthentication,
    
    /// <summary>
    /// Special verification action to be performed on the cardholder due to a high level of risk.
    /// Encoded/decoded by serializers as "SCHV".
    /// </summary>
    [EnumMember(Value = "SCHV")]
    [IsoId("_FgoZ8E0sEeea0Mdu1TOzDQ")]
    [Description(@"Special verification action to be performed on the cardholder due to a high level of risk.")]
    SpecialCardholderVerification,
    
    /// <summary>
    /// Update reservations not supported.
    /// Encoded/decoded by serializers as "URNS".
    /// </summary>
    [EnumMember(Value = "URNS")]
    [IsoId("_VQ08QE0sEeea0Mdu1TOzDQ")]
    [Description(@"Update reservations not supported.")]
    UpdateReservationNotSupported,
    
    /// <summary>
    /// Activate device or service.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_sYMrAE0tEeea0Mdu1TOzDQ")]
    [Description(@"Activate device or service.")]
    Activate,
    
    /// <summary>
    /// Deactivate device or service.
    /// Encoded/decoded by serializers as "DEAC".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_xh36kE0tEeea0Mdu1TOzDQ")]
    [Description(@"Deactivate device or service.")]
    Deactivate,
    
    /// <summary>
    /// Update a data file.
    /// Encoded/decoded by serializers as "FUPD".
    /// </summary>
    [EnumMember(Value = "FUPD")]
    [IsoId("_2GptUE0tEeea0Mdu1TOzDQ")]
    [Description(@"Update a data file.")]
    FileUpdate,
    
    /// <summary>
    /// Send a message.
    /// Encoded/decoded by serializers as "SNDM".
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_-VZQYE0tEeea0Mdu1TOzDQ")]
    [Description(@"Send a message.")]
    SendMessage,
    
    /// <summary>
    /// Contact card issuer.
    /// Encoded/decoded by serializers as "CNTI".
    /// </summary>
    [EnumMember(Value = "CNTI")]
    [IsoId("_GZuiYJ0_EeeuzZPGP9QqVw")]
    [Description(@"Contact card issuer.")]
    ContactIssuer,
    
    /// <summary>
    /// Refer to card issuer's special conditions.
    /// Encoded/decoded by serializers as "CNIS".
    /// </summary>
    [EnumMember(Value = "CNIS")]
    [IsoId("_Wz7D8J0_EeeuzZPGP9QqVw")]
    [Description(@"Refer to card issuer's special conditions.")]
    ContactIssuerSpecialConditions,
    
    /// <summary>
    /// Contact acquirer.
    /// Encoded/decoded by serializers as "CNTA".
    /// </summary>
    [EnumMember(Value = "CNTA")]
    [IsoId("_XOQPgJ0_EeeuzZPGP9QqVw")]
    [Description(@"Contact acquirer.")]
    ContactAcquirer,
    
    /// <summary>
    /// Manage account as a VIP one.
    /// Encoded/decoded by serializers as "VIPM".
    /// </summary>
    [EnumMember(Value = "VIPM")]
    [IsoId("_trjjAJ0_EeeuzZPGP9QqVw")]
    [Description(@"Manage account as a VIP one.")]
    VIPAccountManagement,
    
    /// <summary>
    /// Transaction to be re-entered.
    /// Encoded/decoded by serializers as "TRXR".
    /// </summary>
    [EnumMember(Value = "TRXR")]
    [IsoId("_A5nTUJ1AEeeuzZPGP9QqVw")]
    [Description(@"Transaction to be re-entered.")]
    ReEnterTransaction,
    
    /// <summary>
    /// Card acceptor to call acquirer's security department.
    /// Encoded/decoded by serializers as "CNAS".
    /// </summary>
    [EnumMember(Value = "CNAS")]
    [IsoId("_LKcp8J1AEeeuzZPGP9QqVw")]
    [Description(@"Card acceptor to call acquirer's security department.")]
    ContactAcquirerSecurity,
    
    /// <summary>
    /// Further authentication required (e.g. one-time password)
    /// Encoded/decoded by serializers as "STUA".
    /// </summary>
    [EnumMember(Value = "STUA")]
    [IsoId("_iuQ-oOChEee9RadpHmUgYw")]
    [Description(@"Further authentication required (e.g. one-time password)")]
    StepUpAuthentication,
    
    /// <summary>
    /// Request Cardholder Authentification through PIN insertion.
    /// Encoded/decoded by serializers as "PINQ".
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_Dg48wAu9Eeq4I6UJxZQ2Qw")]
    [Description(@"Request Cardholder Authentification through PIN insertion.")]
    PINRequest,
    
    /// <summary>
    /// Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod.
    /// Encoded/decoded by serializers as "CDCV".
    /// </summary>
    [EnumMember(Value = "CDCV")]
    [IsoId("_8lY4UAu-EeqgUfvUJi0f5w")]
    [Description(@"Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod.")]
    ConsumerDeviceCardholderVerificationMethod,
    
    /// <summary>
    /// Signature required.
    /// Encoded/decoded by serializers as "SIGN".
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_SUOPkJ54EeqkBIJTZMHl2Q")]
    [Description(@"Signature required.")]
    Signature,
    
    /// <summary>
    /// Cardholder has revocated this recurring transaction for this merchant.
    /// Encoded/decoded by serializers as "STOR".
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_jrgd8ExIEey2lJnsdq4TIg")]
    [Description(@"Cardholder has revocated this recurring transaction for this merchant.")]
    StopOneRecurring,
    
    /// <summary>
    /// Recurring transactions is no more allowed for this card and for all merchants.
    /// Encoded/decoded by serializers as "STAR".
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_p0_DAExbEey2lJnsdq4TIg")]
    [Description(@"Recurring transactions is no more allowed for this card and for all merchants.")]
    StopAllRecurring,
    
    /// <summary>
    /// Indicates that this account shouldn't be used anymore.
    /// Encoded/decoded by serializers as "DNTA".
    /// </summary>
    [EnumMember(Value = "DNTA")]
    [IsoId("_8NIF8HC5Ee2bmOA3bkVsMg")]
    [Description(@"Indicates that this account shouldn't be used anymore.")]
    DoNotTryAgain,
    
    /// <summary>
    /// Indicates that the account was updated and should be taken into account for future authorisation.
    /// Encoded/decoded by serializers as "ACUP".
    /// </summary>
    [EnumMember(Value = "ACUP")]
    [IsoId("_C0usEHC6Ee2bmOA3bkVsMg")]
    [Description(@"Indicates that the account was updated and should be taken into account for future authorisation.")]
    AccountUpdate,
    
    /// <summary>
    /// Indicates that the authorization should be resubmitted at a later time.
    /// Encoded/decoded by serializers as "TALT".
    /// </summary>
    [EnumMember(Value = "TALT")]
    [IsoId("_GXExcHC6Ee2bmOA3bkVsMg")]
    [Description(@"Indicates that the authorization should be resubmitted at a later time.")]
    TryAgainLater,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ActionTypeCodeMetadataExtensions
{
    private static readonly ActionTypeCodeDropdownSource _dropdownSource = new ActionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IActionTypeCodeDropdownRow GetMetadata(this ActionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

