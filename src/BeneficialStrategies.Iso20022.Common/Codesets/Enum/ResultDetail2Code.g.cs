﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResultDetail2Code.  ISO2002 ID# _oJDHgIp_EeS3NqNpgnMh2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Detail of the response to an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oJDHgIp_EeS3NqNpgnMh2w")]
[Description(@"Detail of the response to an ATM.")]
[DerivedFrom(typeof(ResultDetailCode))]
public enum ResultDetail2Code
{
    /// <summary>
    /// Account of the cardholder or the customer is not found.
    /// Encoded/decoded by serializers as "AccountNotFound".
    /// </summary>
    [EnumMember(Value = "ACTF")]
    [IsoId("_ufcB0Yp_EeS3NqNpgnMh2w")]
    [Description(@"Account of the cardholder or the customer is not found.")]
    AccountNotFound,
    
    /// <summary>
    /// Acquirer is not supported.
    /// Encoded/decoded by serializers as "AcquirerNotSupported".
    /// </summary>
    [EnumMember(Value = "ACQS")]
    [IsoId("_u4xu44p_EeS3NqNpgnMh2w")]
    [Description(@"Acquirer is not supported.")]
    AcquirerNotSupported,
    
    /// <summary>
    /// Error on AML (Anti Money Laundering) validation.
    /// Encoded/decoded by serializers as "AMLValidation".
    /// </summary>
    [EnumMember(Value = "AMLV")]
    [IsoId("_vO-oY4p_EeS3NqNpgnMh2w")]
    [Description(@"Error on AML (Anti Money Laundering) validation.")]
    AMLValidation,
    
    /// <summary>
    /// Amount not found.
    /// Encoded/decoded by serializers as "AmountNotFound".
    /// </summary>
    [EnumMember(Value = "AMTA")]
    [IsoId("_wZodo4p_EeS3NqNpgnMh2w")]
    [Description(@"Amount not found.")]
    AmountNotFound,
    
    /// <summary>
    /// Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.
    /// Encoded/decoded by serializers as "AuthenticationFailed".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_whFJc4p_EeS3NqNpgnMh2w")]
    [Description(@"Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.")]
    AuthenticationFailed,
    
    /// <summary>
    /// Bank not found.
    /// Encoded/decoded by serializers as "BankNotFound".
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_xWuYA4p_EeS3NqNpgnMh2w")]
    [Description(@"Bank not found.")]
    BankNotFound,
    
    /// <summary>
    /// Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).
    /// Encoded/decoded by serializers as "CardError".
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_xbDeYYp_EeS3NqNpgnMh2w")]
    [Description(@"Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).")]
    CardError,
    
    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as "CardVerificationFailed".
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_y2PqA4p_EeS3NqNpgnMh2w")]
    [Description(@"Identification of the card is invalid.")]
    CardVerificationFailed,
    
    /// <summary>
    /// Account is no more usable for the transaction.
    /// Encoded/decoded by serializers as "ClosedAccount".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_zDW484p_EeS3NqNpgnMh2w")]
    [Description(@"Account is no more usable for the transaction.")]
    ClosedAccount,
    
    /// <summary>
    /// Cutover is in progress, transaction could not be processed.
    /// Encoded/decoded by serializers as "CutoverInProcess".
    /// </summary>
    [EnumMember(Value = "CTVG")]
    [IsoId("_0IptE4p_EeS3NqNpgnMh2w")]
    [Description(@"Cutover is in progress, transaction could not be processed.")]
    CutoverInProcess,
    
    /// <summary>
    /// Database access error.
    /// Encoded/decoded by serializers as "DatabaseError".
    /// </summary>
    [EnumMember(Value = "DBER")]
    [IsoId("_0Pzd84p_EeS3NqNpgnMh2w")]
    [Description(@"Database access error.")]
    DatabaseError,
    
    /// <summary>
    /// Transaction fees are disputed by the issuer.
    /// Encoded/decoded by serializers as "DisputedFees".
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_2tKRM4p_EeS3NqNpgnMh2w")]
    [Description(@"Transaction fees are disputed by the issuer.")]
    DisputedFees,
    
    /// <summary>
    /// Validity period of the transaction is exceeded.
    /// Encoded/decoded by serializers as "ExceededTransactionLifeCycle".
    /// </summary>
    [EnumMember(Value = "TXNL")]
    [IsoId("_3hBXE4p_EeS3NqNpgnMh2w")]
    [Description(@"Validity period of the transaction is exceeded.")]
    ExceededTransactionLifeCycle,
    
    /// <summary>
    /// Amount of deposit transactions exceeds the limit.
    /// Encoded/decoded by serializers as "DepositAmountLimit".
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_CEcSgYqAEeS3NqNpgnMh2w")]
    [Description(@"Amount of deposit transactions exceeds the limit.")]
    DepositAmountLimit,
    
    /// <summary>
    /// Number of deposit transactions or items exceeds the limit.
    /// Encoded/decoded by serializers as "DepositNumberLimit".
    /// </summary>
    [EnumMember(Value = "NMBD")]
    [IsoId("_COuP44qAEeS3NqNpgnMh2w")]
    [Description(@"Number of deposit transactions or items exceeds the limit.")]
    DepositNumberLimit,
    
    /// <summary>
    /// Card has expired.
    /// Encoded/decoded by serializers as "ExpiredCard".
    /// </summary>
    [EnumMember(Value = "CRDX")]
    [IsoId("_D7prw4qAEeS3NqNpgnMh2w")]
    [Description(@"Card has expired.")]
    ExpiredCard,
    
    /// <summary>
    /// Issuer declined the fall-back transaction.
    /// Encoded/decoded by serializers as "FallbackDeclined".
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_ED1-c4qAEeS3NqNpgnMh2w")]
    [Description(@"Issuer declined the fall-back transaction.")]
    FallbackDeclined,
    
    /// <summary>
    /// Invalid format of the message or its content.
    /// Encoded/decoded by serializers as "FormatError".
    /// </summary>
    [EnumMember(Value = "FMTR")]
    [IsoId("_E_dSI4qAEeS3NqNpgnMh2w")]
    [Description(@"Invalid format of the message or its content.")]
    FormatError,
    
    /// <summary>
    /// Original request is in progress.
    /// Encoded/decoded by serializers as "InProgress".
    /// </summary>
    [EnumMember(Value = "TXNG")]
    [IsoId("_FUKW04qAEeS3NqNpgnMh2w")]
    [Description(@"Original request is in progress.")]
    InProgress,
    
    /// <summary>
    /// Account balance is not sufficient.
    /// Encoded/decoded by serializers as "InsufficientFunds".
    /// </summary>
    [EnumMember(Value = "FNDI")]
    [IsoId("_GRjzM4qAEeS3NqNpgnMh2w")]
    [Description(@"Account balance is not sufficient.")]
    InsufficientFunds,
    
    /// <summary>
    /// Issuer denies the acceptor.
    /// Encoded/decoded by serializers as "InvalidAcceptor".
    /// </summary>
    [EnumMember(Value = "ACPI")]
    [IsoId("_GVlXkYqAEeS3NqNpgnMh2w")]
    [Description(@"Issuer denies the acceptor.")]
    InvalidAcceptor,
    
    /// <summary>
    /// Requested amount is outside the card limits, or the currency is invalid.
    /// Encoded/decoded by serializers as "InvalidAmount".
    /// </summary>
    [EnumMember(Value = "AMTI")]
    [IsoId("_IKQaM4qAEeS3NqNpgnMh2w")]
    [Description(@"Requested amount is outside the card limits, or the currency is invalid.")]
    InvalidAmount,
    
    /// <summary>
    /// Part of the specified address is incorrect.
    /// Encoded/decoded by serializers as "InvalidAddress".
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_QNZxQYqAEeS3NqNpgnMh2w")]
    [Description(@"Part of the specified address is incorrect.")]
    InvalidAddress,
    
    /// <summary>
    /// Invalid branch or bank information.
    /// Encoded/decoded by serializers as "InvalidBranch".
    /// </summary>
    [EnumMember(Value = "BRHI")]
    [IsoId("_Rs7DQ4qAEeS3NqNpgnMh2w")]
    [Description(@"Invalid branch or bank information.")]
    InvalidBranch,
    
    /// <summary>
    /// Identification of the cardholder or the customer does not match.
    /// Encoded/decoded by serializers as "InvalidCardholderIdentification".
    /// </summary>
    [EnumMember(Value = "CHDI")]
    [IsoId("_SvO004qAEeS3NqNpgnMh2w")]
    [Description(@"Identification of the cardholder or the customer does not match.")]
    InvalidCardholderIdentification,
    
    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as "InvalidCardNumber".
    /// </summary>
    [EnumMember(Value = "CRDI")]
    [IsoId("_SzjUIYqAEeS3NqNpgnMh2w")]
    [Description(@"Identification of the card is invalid.")]
    InvalidCardNumber,
    
    /// <summary>
    /// Digital certificate cannot be authenticated, is expired or revoked.
    /// Encoded/decoded by serializers as "InvalidCertificate".
    /// </summary>
    [EnumMember(Value = "CTFV")]
    [IsoId("_TkbXc4qAEeS3NqNpgnMh2w")]
    [Description(@"Digital certificate cannot be authenticated, is expired or revoked.")]
    InvalidCertificate,
    
    /// <summary>
    /// Original amount is invalid.
    /// Encoded/decoded by serializers as "InvalidOriginalAmount".
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_TsnqI4qAEeS3NqNpgnMh2w")]
    [Description(@"Original amount is invalid.")]
    InvalidOriginalAmount,
    
    /// <summary>
    /// PIN is invalid.
    /// Encoded/decoded by serializers as "InvalidPIN".
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_T5S0M4qAEeS3NqNpgnMh2w")]
    [Description(@"PIN is invalid.")]
    InvalidPIN,
    
    /// <summary>
    /// Token cannot be used to surrogate a PAN (Primary Account Number).
    /// Encoded/decoded by serializers as "InvalidToken".
    /// </summary>
    [EnumMember(Value = "TKKO")]
    [IsoId("_WcdUg4qAEeS3NqNpgnMh2w")]
    [Description(@"Token cannot be used to surrogate a PAN (Primary Account Number).")]
    InvalidToken,
    
    /// <summary>
    /// Signed message has an invalid signature.
    /// Encoded/decoded by serializers as "InvalidSignature".
    /// </summary>
    [EnumMember(Value = "SGNI")]
    [IsoId("_e3FXcYqAEeS3NqNpgnMh2w")]
    [Description(@"Signed message has an invalid signature.")]
    InvalidSignature,
    
    /// <summary>
    /// Identification of the token provider or the token requestor is invalid.
    /// Encoded/decoded by serializers as "InvalidTokenIdentification".
    /// </summary>
    [EnumMember(Value = "TKID")]
    [IsoId("_gnSw04qAEeS3NqNpgnMh2w")]
    [Description(@"Identification of the token provider or the token requestor is invalid.")]
    InvalidTokenIdentification,
    
    /// <summary>
    /// Transaction is invalid.
    /// Encoded/decoded by serializers as "InvalidTransaction".
    /// </summary>
    [EnumMember(Value = "TXNV")]
    [IsoId("_guchs4qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction is invalid.")]
    InvalidTransaction,
    
    /// <summary>
    /// Date time of the transaction is invalid.
    /// Encoded/decoded by serializers as "InvalidTransactionDateTime".
    /// </summary>
    [EnumMember(Value = "DATI")]
    [IsoId("_jS9F04qAEeS3NqNpgnMh2w")]
    [Description(@"Date time of the transaction is invalid.")]
    InvalidTransactionDateTime,
    
    /// <summary>
    /// Issuer is inoperative.
    /// Encoded/decoded by serializers as "IssuerInoperative".
    /// </summary>
    [EnumMember(Value = "ISSP")]
    [IsoId("_jZ9Fs4qAEeS3NqNpgnMh2w")]
    [Description(@"Issuer is inoperative.")]
    IssuerInoperative,
    
    /// <summary>
    /// Issuer is not found.
    /// Encoded/decoded by serializers as "IssuerNotFound".
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_kL4R44qAEeS3NqNpgnMh2w")]
    [Description(@"Issuer is not found.")]
    IssuerNotFound,
    
    /// <summary>
    /// Transaction could not be processed as Issuer is signed off.
    /// Encoded/decoded by serializers as "IssuerSignedOff".
    /// </summary>
    [EnumMember(Value = "ISSO")]
    [IsoId("_kPwFQYqAEeS3NqNpgnMh2w")]
    [Description(@"Transaction could not be processed as Issuer is signed off.")]
    IssuerSignedOff,
    
    /// <summary>
    /// Transaction could not be processed as Issuer times out.
    /// Encoded/decoded by serializers as "IssuerTimeOut".
    /// </summary>
    [EnumMember(Value = "ISST")]
    [IsoId("_lDmkE4qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction could not be processed as Issuer times out.")]
    IssuerTimeOut,
    
    /// <summary>
    /// Transaction could not be processed as Issuer is unavailable.
    /// Encoded/decoded by serializers as "IssuerUnavailable".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_lK6F84qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction could not be processed as Issuer is unavailable.")]
    IssuerUnavailable,
    
    /// <summary>
    /// Storage space not available for the key.
    /// Encoded/decoded by serializers as "KeyStorageSaturation".
    /// </summary>
    [EnumMember(Value = "KEYS")]
    [IsoId("_lbAXc4qAEeS3NqNpgnMh2w")]
    [Description(@"Storage space not available for the key.")]
    KeyStorageSaturation,
    
    /// <summary>
    /// Transaction is processed and liability is accepted.
    /// Encoded/decoded by serializers as "LiabilityAccepted".
    /// </summary>
    [EnumMember(Value = "LBLA")]
    [IsoId("_meDv44qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction is processed and liability is accepted.")]
    LiabilityAccepted,
    
    /// <summary>
    /// Card has been declared lost.
    /// Encoded/decoded by serializers as "LostCard".
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_miFUQYqAEeS3NqNpgnMh2w")]
    [Description(@"Card has been declared lost.")]
    LostCard,
    
    /// <summary>
    /// MAC error.
    /// Encoded/decoded by serializers as "MACError".
    /// </summary>
    [EnumMember(Value = "MACR")]
    [IsoId("_nfszE4qAEeS3NqNpgnMh2w")]
    [Description(@"MAC error.")]
    MACError,
    
    /// <summary>
    /// MAC key error.
    /// Encoded/decoded by serializers as "MACKeyError".
    /// </summary>
    [EnumMember(Value = "MACK")]
    [IsoId("_noC2w4qAEeS3NqNpgnMh2w")]
    [Description(@"MAC key error.")]
    MACKeyError,
    
    /// <summary>
    /// ICC data elements required for processing the ICC transaction were not present in the message.
    /// Encoded/decoded by serializers as "MissingICCData".
    /// </summary>
    [EnumMember(Value = "ICCM")]
    [IsoId("_o8h9c4qAEeS3NqNpgnMh2w")]
    [Description(@"ICC data elements required for processing the ICC transaction were not present in the message.")]
    MissingICCData,
    
    /// <summary>
    /// New PIN is invalid (PIN change).
    /// Encoded/decoded by serializers as "NewPINInvalid".
    /// </summary>
    [EnumMember(Value = "PINN")]
    [IsoId("_pAaX4YqAEeS3NqNpgnMh2w")]
    [Description(@"New PIN is invalid (PIN change).")]
    NewPINInvalid,
    
    /// <summary>
    /// No card file record.
    /// Encoded/decoded by serializers as "NoCardRecord".
    /// </summary>
    [EnumMember(Value = "CRDA")]
    [IsoId("_qDT_U4qAEeS3NqNpgnMh2w")]
    [Description(@"No card file record.")]
    NoCardRecord,
    
    /// <summary>
    /// Transaction is processed, but liability is not accepted.
    /// Encoded/decoded by serializers as "NoLiabilityAccepted".
    /// </summary>
    [EnumMember(Value = "LBLU")]
    [IsoId("_qHMZwYqAEeS3NqNpgnMh2w")]
    [Description(@"Transaction is processed, but liability is not accepted.")]
    NoLiabilityAccepted,
    
    /// <summary>
    /// PIN could not be validated.
    /// Encoded/decoded by serializers as "NotAbleToValidatePIN".
    /// </summary>
    [EnumMember(Value = "PINA")]
    [IsoId("_q5jq04qAEeS3NqNpgnMh2w")]
    [Description(@"PIN could not be validated.")]
    NotAbleToValidatePIN,
    
    /// <summary>
    /// Process not permitted to the acceptor (for example fall back).
    /// Encoded/decoded by serializers as "NotPermittedToAcceptor".
    /// </summary>
    [EnumMember(Value = "NPRA")]
    [IsoId("_rBAWo4qAEeS3NqNpgnMh2w")]
    [Description(@"Process not permitted to the acceptor (for example fall back).")]
    NotPermittedToAcceptor,
    
    /// <summary>
    /// Transaction has been processed offline by the terminal.
    /// Encoded/decoded by serializers as "OffLineProcess".
    /// </summary>
    [EnumMember(Value = "OFFL")]
    [IsoId("_sDnqM4qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction has been processed offline by the terminal.")]
    OffLineProcess,
    
    /// <summary>
    /// Transaction has been processed offline after referral.
    /// Encoded/decoded by serializers as "OffLineProcessAfterReferral".
    /// </summary>
    [EnumMember(Value = "ONLP")]
    [IsoId("_sHongYqAEeS3NqNpgnMh2w")]
    [Description(@"Transaction has been processed offline after referral.")]
    OffLineProcessAfterReferral,
    
    /// <summary>
    /// Transaction not permitted to the cardholder or the customer.
    /// Encoded/decoded by serializers as "NotPermittedToCardholder".
    /// </summary>
    [EnumMember(Value = "NPRC")]
    [IsoId("_s1sAU4qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction not permitted to the cardholder or the customer.")]
    NotPermittedToCardholder,
    
    /// <summary>
    /// Original is found, but transaction does not match.
    /// Encoded/decoded by serializers as "OriginalDoesNotMatch".
    /// </summary>
    [EnumMember(Value = "TXNM")]
    [IsoId("_t_TTw4qAEeS3NqNpgnMh2w")]
    [Description(@"Original is found, but transaction does not match.")]
    OriginalDoesNotMatch,
    
    /// <summary>
    /// Other error.
    /// Encoded/decoded by serializers as "OtherError".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uH8SY4qAEeS3NqNpgnMh2w")]
    [Description(@"Other error.")]
    OtherError,
    
    /// <summary>
    /// Out of balance.
    /// Encoded/decoded by serializers as "OutOfBalance".
    /// </summary>
    [EnumMember(Value = "BALO")]
    [IsoId("_u1PdQ4qAEeS3NqNpgnMh2w")]
    [Description(@"Out of balance.")]
    OutOfBalance,
    
    /// <summary>
    /// Message is out of sequence.
    /// Encoded/decoded by serializers as "OutOfSequence".
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_u8iYE4qAEeS3NqNpgnMh2w")]
    [Description(@"Message is out of sequence.")]
    OutOfSequence,
    
    /// <summary>
    /// Cardholder must change the PIN to be able to perform the transaction.
    /// Encoded/decoded by serializers as "PINChangeRequired".
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_wFHJs4qAEeS3NqNpgnMh2w")]
    [Description(@"Cardholder must change the PIN to be able to perform the transaction.")]
    PINChangeRequired,
    
    /// <summary>
    /// Additional information are required to verify the PIN.
    /// Encoded/decoded by serializers as "PINDataRequired".
    /// </summary>
    [EnumMember(Value = "PIND")]
    [IsoId("_wOpgM4qAEeS3NqNpgnMh2w")]
    [Description(@"Additional information are required to verify the PIN.")]
    PINDataRequired,
    
    /// <summary>
    /// PIN length or PIN key is invalid.
    /// Encoded/decoded by serializers as "PINSecurityError".
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_x3UuM4qAEeS3NqNpgnMh2w")]
    [Description(@"PIN length or PIN key is invalid.")]
    PINSecurityError,
    
    /// <summary>
    /// Last attempt of the PIN verification fails.
    /// Encoded/decoded by serializers as "PINTriesExceeded".
    /// </summary>
    [EnumMember(Value = "PINX")]
    [IsoId("_x-xaA4qAEeS3NqNpgnMh2w")]
    [Description(@"Last attempt of the PIN verification fails.")]
    PINTriesExceeded,
    
    /// <summary>
    /// Decrypted PIN block is invalid.
    /// Encoded/decoded by serializers as "PINEncryptionError".
    /// </summary>
    [EnumMember(Value = "PINE")]
    [IsoId("_y4JSA4qAEeS3NqNpgnMh2w")]
    [Description(@"Decrypted PIN block is invalid.")]
    PINEncryptionError,
    
    /// <summary>
    /// Store and forward queue maximum exceeded.
    /// Encoded/decoded by serializers as "QueueMaximumExceeded".
    /// </summary>
    [EnumMember(Value = "QMAX")]
    [IsoId("_z2SVQ4qAEeS3NqNpgnMh2w")]
    [Description(@"Store and forward queue maximum exceeded.")]
    QueueMaximumExceeded,
    
    /// <summary>
    /// Recurring Error on Data.
    /// Encoded/decoded by serializers as "RecurringDataError".
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_0BA-k4qAEeS3NqNpgnMh2w")]
    [Description(@"Recurring Error on Data.")]
    RecurringDataError,
    
    /// <summary>
    /// Requested service not allowed by the card.
    /// Encoded/decoded by serializers as "RestrictedCard".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_0JzuM4qAEeS3NqNpgnMh2w")]
    [Description(@"Requested service not allowed by the card.")]
    RestrictedCard,
    
    /// <summary>
    /// Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).
    /// Encoded/decoded by serializers as "SecurityViolation".
    /// </summary>
    [EnumMember(Value = "SECV")]
    [IsoId("_1DK_I4qAEeS3NqNpgnMh2w")]
    [Description(@"Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).")]
    SecurityViolation,
    
    /// <summary>
    /// Cardholder or customer has not enabled the service with the service provider.
    /// Encoded/decoded by serializers as "ServiceNotEnabled".
    /// </summary>
    [EnumMember(Value = "SRVU")]
    [IsoId("_1KehA4qAEeS3NqNpgnMh2w")]
    [Description(@"Cardholder or customer has not enabled the service with the service provider.")]
    ServiceNotEnabled,
    
    /// <summary>
    /// Security software or hardware error.
    /// Encoded/decoded by serializers as "SoftwareOrHardwareError".
    /// </summary>
    [EnumMember(Value = "SFWE")]
    [IsoId("_2PUpM4qAEeS3NqNpgnMh2w")]
    [Description(@"Security software or hardware error.")]
    SoftwareOrHardwareError,
    
    /// <summary>
    /// Special card conditions not respected.
    /// Encoded/decoded by serializers as "SpecialConditions".
    /// </summary>
    [EnumMember(Value = "SPCC")]
    [IsoId("_2TMckYqAEeS3NqNpgnMh2w")]
    [Description(@"Special card conditions not respected.")]
    SpecialConditions,
    
    /// <summary>
    /// Card has been declared stolen.
    /// Encoded/decoded by serializers as "StolenCard".
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_2e-Ow4qAEeS3NqNpgnMh2w")]
    [Description(@"Card has been declared stolen.")]
    StolenCard,
    
    /// <summary>
    /// Surcharging is not permitted.
    /// Encoded/decoded by serializers as "SurchargeNotPermitted".
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_36BQc4qAEeS3NqNpgnMh2w")]
    [Description(@"Surcharging is not permitted.")]
    SurchargeNotPermitted,
    
    /// <summary>
    /// Counterfeit card suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as "SuspectedCounterfeitCard".
    /// </summary>
    [EnumMember(Value = "CNTC")]
    [IsoId("_4BLBU4qAEeS3NqNpgnMh2w")]
    [Description(@"Counterfeit card suspected by the issuer or the processor.")]
    SuspectedCounterfeitCard,
    
    /// <summary>
    /// Fraudulent transaction is suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as "SuspectedFraud".
    /// </summary>
    [EnumMember(Value = "FRDS")]
    [IsoId("_5OWmI4qAEeS3NqNpgnMh2w")]
    [Description(@"Fraudulent transaction is suspected by the issuer or the processor.")]
    SuspectedFraud,
    
    /// <summary>
    /// Processing temporary not available.
    /// Encoded/decoded by serializers as "SystemInoperative".
    /// </summary>
    [EnumMember(Value = "SYSP")]
    [IsoId("_5VgXA4qAEeS3NqNpgnMh2w")]
    [Description(@"Processing temporary not available.")]
    SystemInoperative,
    
    /// <summary>
    /// System Malfunction.
    /// Encoded/decoded by serializers as "SystemMalfunction".
    /// </summary>
    [EnumMember(Value = "SYSM")]
    [IsoId("_5cz444qAEeS3NqNpgnMh2w")]
    [Description(@"System Malfunction.")]
    SystemMalfunction,
    
    /// <summary>
    /// Server received a terminal identification that it does not have any knowledge of.
    /// Encoded/decoded by serializers as "TerminalNotConfigured".
    /// </summary>
    [EnumMember(Value = "TRMI")]
    [IsoId("_6ZT9Y4qAEeS3NqNpgnMh2w")]
    [Description(@"Server received a terminal identification that it does not have any knowledge of.")]
    TerminalNotConfigured,
    
    /// <summary>
    /// To account status error.
    /// Encoded/decoded by serializers as "ToAccountError".
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_6gnfQ4qAEeS3NqNpgnMh2w")]
    [Description(@"To account status error.")]
    ToAccountError,
    
    /// <summary>
    /// Totals are not available.
    /// Encoded/decoded by serializers as "TotalsNotAvailable".
    /// </summary>
    [EnumMember(Value = "TTLV")]
    [IsoId("_7jX8w4qAEeS3NqNpgnMh2w")]
    [Description(@"Totals are not available.")]
    TotalsNotAvailable,
    
    /// <summary>
    /// Transaction did not complete at the terminal.
    /// Encoded/decoded by serializers as "TransactionDidNotComplete".
    /// </summary>
    [EnumMember(Value = "TXNU")]
    [IsoId("_7tzEE4qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction did not complete at the terminal.")]
    TransactionDidNotComplete,
    
    /// <summary>
    /// Transaction identification already used for another transaction.
    /// Encoded/decoded by serializers as "TransactionDuplicate".
    /// </summary>
    [EnumMember(Value = "TXND")]
    [IsoId("_7xregYqAEeS3NqNpgnMh2w")]
    [Description(@"Transaction identification already used for another transaction.")]
    TransactionDuplicate,
    
    /// <summary>
    /// Transaction could not be processed as original is not found.
    /// Encoded/decoded by serializers as "UnableToFindOriginal".
    /// </summary>
    [EnumMember(Value = "ORGF")]
    [IsoId("_82E6w4qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction could not be processed as original is not found.")]
    UnableToFindOriginal,
    
    /// <summary>
    /// Transaction cannot be processed online by the terminal.
    /// Encoded/decoded by serializers as "UnableToGoOnLine".
    /// </summary>
    [EnumMember(Value = "UNBO")]
    [IsoId("_9BQQA4qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction cannot be processed online by the terminal.")]
    UnableToGoOnLine,
    
    /// <summary>
    /// Transaction cannot be processed offline.
    /// Encoded/decoded by serializers as "UnableToProcessOffLine".
    /// </summary>
    [EnumMember(Value = "UNBP")]
    [IsoId("_97EM44qAEeS3NqNpgnMh2w")]
    [Description(@"Transaction cannot be processed offline.")]
    UnableToProcessOffLine,
    
    /// <summary>
    /// Currency is unacceptable for the Issuer or the processor.
    /// Encoded/decoded by serializers as "UnacceptableCurrency".
    /// </summary>
    [EnumMember(Value = "UNBC")]
    [IsoId("_-CXuw4qAEeS3NqNpgnMh2w")]
    [Description(@"Currency is unacceptable for the Issuer or the processor.")]
    UnacceptableCurrency,
    
    /// <summary>
    /// Communication keys are not available.
    /// Encoded/decoded by serializers as "UnavailablecommunicationKey".
    /// </summary>
    [EnumMember(Value = "CMKY")]
    [IsoId("__LO0Q4qAEeS3NqNpgnMh2w")]
    [Description(@"Communication keys are not available.")]
    UnavailablecommunicationKey,
    
    /// <summary>
    /// Card is not active yet.
    /// Encoded/decoded by serializers as "UneffectiveCard".
    /// </summary>
    [EnumMember(Value = "CRDU")]
    [IsoId("__SYlI4qAEeS3NqNpgnMh2w")]
    [Description(@"Card is not active yet.")]
    UneffectiveCard,
    
    /// <summary>
    /// Requested service not supported.
    /// Encoded/decoded by serializers as "UnsupportedService".
    /// </summary>
    [EnumMember(Value = "SVSU")]
    [IsoId("_AUb4A4qBEeS3NqNpgnMh2w")]
    [Description(@"Requested service not supported.")]
    UnsupportedService,
    
    /// <summary>
    /// Vendor format has an error.
    /// Encoded/decoded by serializers as "VendorFormatError".
    /// </summary>
    [EnumMember(Value = "VNDR")]
    [IsoId("_Ag8qA4qBEeS3NqNpgnMh2w")]
    [Description(@"Vendor format has an error.")]
    VendorFormatError,
    
    /// <summary>
    /// Vendor not found.
    /// Encoded/decoded by serializers as "VendorNotFound".
    /// </summary>
    [EnumMember(Value = "VNDF")]
    [IsoId("_AoQL44qBEeS3NqNpgnMh2w")]
    [Description(@"Vendor not found.")]
    VendorNotFound,
    
    /// <summary>
    /// Amount of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as "WithdrawalAmountLimit".
    /// </summary>
    [EnumMember(Value = "AMTW")]
    [IsoId("_A4MsY4qBEeS3NqNpgnMh2w")]
    [Description(@"Amount of withdrawal transactions exceeds card limit.")]
    WithdrawalAmountLimit,
    
    /// <summary>
    /// Number of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as "WithdrawalNumberLimit".
    /// </summary>
    [EnumMember(Value = "NMBW")]
    [IsoId("_BCB904qBEeS3NqNpgnMh2w")]
    [Description(@"Number of withdrawal transactions exceeds card limit.")]
    WithdrawalNumberLimit,
    
    /// <summary>
    /// Other card used for the original transaction.
    /// Encoded/decoded by serializers as "WrongCard".
    /// </summary>
    [EnumMember(Value = "CRDW")]
    [IsoId("_BmFtI4qBEeS3NqNpgnMh2w")]
    [Description(@"Other card used for the original transaction.")]
    WrongCard,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResultDetail2CodeMetadataExtensions
{
    private static readonly ResultDetail2CodeDropdownSource _dropdownSource = new ResultDetail2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResultDetail2CodeDropdownRow GetMetadata(this ResultDetail2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


