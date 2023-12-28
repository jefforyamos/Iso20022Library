﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResultDetailCode.  ISO2002 ID# _5_14oHuGEeSZrqGdHyoIrw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Detail of the result.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5_14oHuGEeSZrqGdHyoIrw")]
[Description(@"Detail of the result.")]
public enum ResultDetailCode
{
    /// <summary>
    /// Other card used for the original transaction.
    /// Encoded/decoded by serializers as "CRDW".
    /// </summary>
    [EnumMember(Value = "CRDW")]
    [IsoId("_CxNnoHuHEeSZrqGdHyoIrw")]
    [Description(@"Other card used for the original transaction.")]
    WrongCard,
    
    /// <summary>
    /// Number of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as "NMBW".
    /// </summary>
    [EnumMember(Value = "NMBW")]
    [IsoId("_FxvZYHuHEeSZrqGdHyoIrw")]
    [Description(@"Number of withdrawal transactions exceeds card limit.")]
    WithdrawalNumberLimit,
    
    /// <summary>
    /// Amount of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as "AMTW".
    /// </summary>
    [EnumMember(Value = "AMTW")]
    [IsoId("_IXTGYHuHEeSZrqGdHyoIrw")]
    [Description(@"Amount of withdrawal transactions exceeds card limit.")]
    WithdrawalAmountLimit,
    
    /// <summary>
    /// Vendor not found.
    /// Encoded/decoded by serializers as "VNDF".
    /// </summary>
    [EnumMember(Value = "VNDF")]
    [IsoId("_Rl1SgHuHEeSZrqGdHyoIrw")]
    [Description(@"Vendor not found.")]
    VendorNotFound,
    
    /// <summary>
    /// Vendor format has an error.
    /// Encoded/decoded by serializers as "VNDR".
    /// </summary>
    [EnumMember(Value = "VNDR")]
    [IsoId("_T0UjUHuHEeSZrqGdHyoIrw")]
    [Description(@"Vendor format has an error.")]
    VendorFormatError,
    
    /// <summary>
    /// Account of the cardholder or the customer is not found.
    /// Encoded/decoded by serializers as "ACTF".
    /// </summary>
    [EnumMember(Value = "ACTF")]
    [IsoId("_YK13oHuHEeSZrqGdHyoIrw")]
    [Description(@"Account of the cardholder or the customer is not found.")]
    AccountNotFound,
    
    /// <summary>
    /// Acquirer is not supported.
    /// Encoded/decoded by serializers as "ACQS".
    /// </summary>
    [EnumMember(Value = "ACQS")]
    [IsoId("_dw7WYHuHEeSZrqGdHyoIrw")]
    [Description(@"Acquirer is not supported.")]
    AcquirerNotSupported,
    
    /// <summary>
    /// Error on AML (Anti Money Laundering) validation.
    /// Encoded/decoded by serializers as "AMLV".
    /// </summary>
    [EnumMember(Value = "AMLV")]
    [IsoId("_gCNcgHuHEeSZrqGdHyoIrw")]
    [Description(@"Error on AML (Anti Money Laundering) validation.")]
    AMLValidation,
    
    /// <summary>
    /// Requested service not supported.
    /// Encoded/decoded by serializers as "SVSU".
    /// </summary>
    [EnumMember(Value = "SVSU")]
    [IsoId("_rLuuoHuHEeSZrqGdHyoIrw")]
    [Description(@"Requested service not supported.")]
    UnsupportedService,
    
    /// <summary>
    /// Card is not active yet.
    /// Encoded/decoded by serializers as "CRDU".
    /// </summary>
    [EnumMember(Value = "CRDU")]
    [IsoId("_t8TY0HuHEeSZrqGdHyoIrw")]
    [Description(@"Card is not active yet.")]
    UneffectiveCard,
    
    /// <summary>
    /// Communication keys are not available.
    /// Encoded/decoded by serializers as "CMKY".
    /// </summary>
    [EnumMember(Value = "CMKY")]
    [IsoId("_wkeU8HuHEeSZrqGdHyoIrw")]
    [Description(@"Communication keys are not available.")]
    UnavailablecommunicationKey,
    
    /// <summary>
    /// Currency is unacceptable for the Issuer or the processor.
    /// Encoded/decoded by serializers as "UNBC".
    /// </summary>
    [EnumMember(Value = "UNBC")]
    [IsoId("_zn-iMHuHEeSZrqGdHyoIrw")]
    [Description(@"Currency is unacceptable for the Issuer or the processor.")]
    UnacceptableCurrency,
    
    /// <summary>
    /// Transaction cannot be processed offline.
    /// Encoded/decoded by serializers as "UNBP".
    /// </summary>
    [EnumMember(Value = "UNBP")]
    [IsoId("_2QW5sHuHEeSZrqGdHyoIrw")]
    [Description(@"Transaction cannot be processed offline.")]
    UnableToProcessOffLine,
    
    /// <summary>
    /// Transaction cannot be processed online by the terminal.
    /// Encoded/decoded by serializers as "UNBO".
    /// </summary>
    [EnumMember(Value = "UNBO")]
    [IsoId("_5Uwe0HuHEeSZrqGdHyoIrw")]
    [Description(@"Transaction cannot be processed online by the terminal.")]
    UnableToGoOnLine,
    
    /// <summary>
    /// Transaction could not be processed as original is not found.
    /// Encoded/decoded by serializers as "ORGF".
    /// </summary>
    [EnumMember(Value = "ORGF")]
    [IsoId("_7nFt0HuHEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as original is not found.")]
    UnableToFindOriginal,
    
    /// <summary>
    /// Transaction identification already used for another transaction.
    /// Encoded/decoded by serializers as "TXND".
    /// </summary>
    [EnumMember(Value = "TXND")]
    [IsoId("__Yfi4HuHEeSZrqGdHyoIrw")]
    [Description(@"Transaction identification already used for another transaction.")]
    TransactionDuplicate,
    
    /// <summary>
    /// Transaction did not complete at the terminal.
    /// Encoded/decoded by serializers as "TXNU".
    /// </summary>
    [EnumMember(Value = "TXNU")]
    [IsoId("_CrpVsHuIEeSZrqGdHyoIrw")]
    [Description(@"Transaction did not complete at the terminal.")]
    TransactionDidNotComplete,
    
    /// <summary>
    /// Totals are not available.
    /// Encoded/decoded by serializers as "TTLV".
    /// </summary>
    [EnumMember(Value = "TTLV")]
    [IsoId("_Fo5J8HuIEeSZrqGdHyoIrw")]
    [Description(@"Totals are not available.")]
    TotalsNotAvailable,
    
    /// <summary>
    /// To account status error.
    /// Encoded/decoded by serializers as "ACTT".
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_H9m-kHuIEeSZrqGdHyoIrw")]
    [Description(@"To account status error.")]
    ToAccountError,
    
    /// <summary>
    /// System Malfunction.
    /// Encoded/decoded by serializers as "SYSM".
    /// </summary>
    [EnumMember(Value = "SYSM")]
    [IsoId("_LU2nMHuIEeSZrqGdHyoIrw")]
    [Description(@"System Malfunction.")]
    SystemMalfunction,
    
    /// <summary>
    /// Processing temporary not available.
    /// Encoded/decoded by serializers as "SYSP".
    /// </summary>
    [EnumMember(Value = "SYSP")]
    [IsoId("_N3IWsHuIEeSZrqGdHyoIrw")]
    [Description(@"Processing temporary not available.")]
    SystemInoperative,
    
    /// <summary>
    /// Fraudulent transaction is suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as "FRDS".
    /// </summary>
    [EnumMember(Value = "FRDS")]
    [IsoId("_Q4_lMHuIEeSZrqGdHyoIrw")]
    [Description(@"Fraudulent transaction is suspected by the issuer or the processor.")]
    SuspectedFraud,
    
    /// <summary>
    /// Counterfeit card suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as "CNTC".
    /// </summary>
    [EnumMember(Value = "CNTC")]
    [IsoId("_URGJcHuIEeSZrqGdHyoIrw")]
    [Description(@"Counterfeit card suspected by the issuer or the processor.")]
    SuspectedCounterfeitCard,
    
    /// <summary>
    /// Surcharging is not permitted.
    /// Encoded/decoded by serializers as "SRCH".
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_X4OBIHuIEeSZrqGdHyoIrw")]
    [Description(@"Surcharging is not permitted.")]
    SurchargeNotPermitted,
    
    /// <summary>
    /// Special card conditions not respected.
    /// Encoded/decoded by serializers as "SPCC".
    /// </summary>
    [EnumMember(Value = "SPCC")]
    [IsoId("_aN-XkHuIEeSZrqGdHyoIrw")]
    [Description(@"Special card conditions not respected.")]
    SpecialConditions,
    
    /// <summary>
    /// Card has been declared stolen.
    /// Encoded/decoded by serializers as "CRDS".
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_cuUNYHuIEeSZrqGdHyoIrw")]
    [Description(@"Card has been declared stolen.")]
    StolenCard,
    
    /// <summary>
    /// Security software or hardware error.
    /// Encoded/decoded by serializers as "SFWE".
    /// </summary>
    [EnumMember(Value = "SFWE")]
    [IsoId("_fAfrYHuIEeSZrqGdHyoIrw")]
    [Description(@"Security software or hardware error.")]
    SoftwareOrHardwareError,
    
    /// <summary>
    /// Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).
    /// Encoded/decoded by serializers as "SECV".
    /// </summary>
    [EnumMember(Value = "SECV")]
    [IsoId("_h9SzsHuIEeSZrqGdHyoIrw")]
    [Description(@"Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).")]
    SecurityViolation,
    
    /// <summary>
    /// Requested service not allowed by the card.
    /// Encoded/decoded by serializers as "CRDT".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_443-oHuIEeSZrqGdHyoIrw")]
    [Description(@"Requested service not allowed by the card.")]
    RestrictedCard,
    
    /// <summary>
    /// Recurring Error on Data.
    /// Encoded/decoded by serializers as "RECD".
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_9ZEMUHuIEeSZrqGdHyoIrw")]
    [Description(@"Recurring Error on Data.")]
    RecurringDataError,
    
    /// <summary>
    /// Store and forward queue maximum exceeded.
    /// Encoded/decoded by serializers as "QMAX".
    /// </summary>
    [EnumMember(Value = "QMAX")]
    [IsoId("_AJDAoHuJEeSZrqGdHyoIrw")]
    [Description(@"Store and forward queue maximum exceeded.")]
    QueueMaximumExceeded,
    
    /// <summary>
    /// Last attempt of the PIN verification fails.
    /// Encoded/decoded by serializers as "PINX".
    /// </summary>
    [EnumMember(Value = "PINX")]
    [IsoId("_DLvVkHuJEeSZrqGdHyoIrw")]
    [Description(@"Last attempt of the PIN verification fails.")]
    PINTriesExceeded,
    
    /// <summary>
    /// PIN length or PIN key is invalid.
    /// Encoded/decoded by serializers as "PINS".
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_FjpBEHuJEeSZrqGdHyoIrw")]
    [Description(@"PIN length or PIN key is invalid.")]
    PINSecurityError,
    
    /// <summary>
    /// Decrypted PIN block is invalid.
    /// Encoded/decoded by serializers as "PINE".
    /// </summary>
    [EnumMember(Value = "PINE")]
    [IsoId("_IAGccHuJEeSZrqGdHyoIrw")]
    [Description(@"Decrypted PIN block is invalid.")]
    PINEncryptionError,
    
    /// <summary>
    /// Additional information are required to verify the PIN.
    /// Encoded/decoded by serializers as "PIND".
    /// </summary>
    [EnumMember(Value = "PIND")]
    [IsoId("_KPqEQHuJEeSZrqGdHyoIrw")]
    [Description(@"Additional information are required to verify the PIN.")]
    PINDataRequired,
    
    /// <summary>
    /// Cardholder must change the PIN to be able to perform the transaction.
    /// Encoded/decoded by serializers as "PINC".
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_OmT7cHuJEeSZrqGdHyoIrw")]
    [Description(@"Cardholder must change the PIN to be able to perform the transaction.")]
    PINChangeRequired,
    
    /// <summary>
    /// Number of payment transactions exceeds card limit.
    /// Encoded/decoded by serializers as "NMBL".
    /// </summary>
    [EnumMember(Value = "NMBL")]
    [IsoId("_Q76g4HuJEeSZrqGdHyoIrw")]
    [Description(@"Number of payment transactions exceeds card limit.")]
    PaymentNumberLimit,
    
    /// <summary>
    /// Amount of payment transactions exceeds card limit.
    /// Encoded/decoded by serializers as "AMTL".
    /// </summary>
    [EnumMember(Value = "AMTL")]
    [IsoId("_Tbgv0HuJEeSZrqGdHyoIrw")]
    [Description(@"Amount of payment transactions exceeds card limit.")]
    PaymentAmountLimit,
    
    /// <summary>
    /// Message is out of sequence.
    /// Encoded/decoded by serializers as "SEQO".
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_dgliYHuJEeSZrqGdHyoIrw")]
    [Description(@"Message is out of sequence.")]
    OutOfSequence,
    
    /// <summary>
    /// Out of balance.
    /// Encoded/decoded by serializers as "BALO".
    /// </summary>
    [EnumMember(Value = "BALO")]
    [IsoId("_f02rEHuJEeSZrqGdHyoIrw")]
    [Description(@"Out of balance.")]
    OutOfBalance,
    
    /// <summary>
    /// Other error.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jgczEHuJEeSZrqGdHyoIrw")]
    [Description(@"Other error.")]
    OtherError,
    
    /// <summary>
    /// Original is found, but transaction does not match.
    /// Encoded/decoded by serializers as "TXNM".
    /// </summary>
    [EnumMember(Value = "TXNM")]
    [IsoId("_ll9uEHuJEeSZrqGdHyoIrw")]
    [Description(@"Original is found, but transaction does not match.")]
    OriginalDoesNotMatch,
    
    /// <summary>
    /// Transaction has been processed offline after referral.
    /// Encoded/decoded by serializers as "ONLP".
    /// </summary>
    [EnumMember(Value = "ONLP")]
    [IsoId("_o5tWwHuJEeSZrqGdHyoIrw")]
    [Description(@"Transaction has been processed offline after referral.")]
    OffLineProcessAfterReferral,
    
    /// <summary>
    /// Transaction has been processed offline by the terminal.
    /// Encoded/decoded by serializers as "OFFL".
    /// </summary>
    [EnumMember(Value = "OFFL")]
    [IsoId("_q7gPYHuJEeSZrqGdHyoIrw")]
    [Description(@"Transaction has been processed offline by the terminal.")]
    OffLineProcess,
    
    /// <summary>
    /// Transaction not permitted to the cardholder or the customer.
    /// Encoded/decoded by serializers as "NPRC".
    /// </summary>
    [EnumMember(Value = "NPRC")]
    [IsoId("_tlhloHuJEeSZrqGdHyoIrw")]
    [Description(@"Transaction not permitted to the cardholder or the customer.")]
    NotPermittedToCardholder,
    
    /// <summary>
    /// Process not permitted to the acceptor (for example fall back).
    /// Encoded/decoded by serializers as "NPRA".
    /// </summary>
    [EnumMember(Value = "NPRA")]
    [IsoId("_vd7RsHuJEeSZrqGdHyoIrw")]
    [Description(@"Process not permitted to the acceptor (for example fall back).")]
    NotPermittedToAcceptor,
    
    /// <summary>
    /// PIN could not be validated.
    /// Encoded/decoded by serializers as "PINA".
    /// </summary>
    [EnumMember(Value = "PINA")]
    [IsoId("_yjEdsHuJEeSZrqGdHyoIrw")]
    [Description(@"PIN could not be validated.")]
    NotAbleToValidatePIN,
    
    /// <summary>
    /// No card file record.
    /// Encoded/decoded by serializers as "CRDA".
    /// </summary>
    [EnumMember(Value = "CRDA")]
    [IsoId("_1IVPwHuJEeSZrqGdHyoIrw")]
    [Description(@"No card file record.")]
    NoCardRecord,
    
    /// <summary>
    /// New PIN is invalid (PIN change).
    /// Encoded/decoded by serializers as "PINN".
    /// </summary>
    [EnumMember(Value = "PINN")]
    [IsoId("_3jo0kHuJEeSZrqGdHyoIrw")]
    [Description(@"New PIN is invalid (PIN change).")]
    NewPINInvalid,
    
    /// <summary>
    /// Card has been declared lost.
    /// Encoded/decoded by serializers as "CRDL".
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_6y2ikHuJEeSZrqGdHyoIrw")]
    [Description(@"Card has been declared lost.")]
    LostCard,
    
    /// <summary>
    /// Transaction is processed, but liability is not accepted.
    /// Encoded/decoded by serializers as "LBLU".
    /// </summary>
    [EnumMember(Value = "LBLU")]
    [IsoId("_9eiswHuJEeSZrqGdHyoIrw")]
    [Description(@"Transaction is processed, but liability is not accepted.")]
    NoLiabilityAccepted,
    
    /// <summary>
    /// MAC key error.
    /// Encoded/decoded by serializers as "MACK".
    /// </summary>
    [EnumMember(Value = "MACK")]
    [IsoId("__i3U8HuJEeSZrqGdHyoIrw")]
    [Description(@"MAC key error.")]
    MACKeyError,
    
    /// <summary>
    /// MAC error.
    /// Encoded/decoded by serializers as "MACR".
    /// </summary>
    [EnumMember(Value = "MACR")]
    [IsoId("_Bwb_wHuKEeSZrqGdHyoIrw")]
    [Description(@"MAC error.")]
    MACError,
    
    /// <summary>
    /// Transaction is processed and liability is accepted.
    /// Encoded/decoded by serializers as "LBLA".
    /// </summary>
    [EnumMember(Value = "LBLA")]
    [IsoId("_EkrpAHuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction is processed and liability is accepted.")]
    LiabilityAccepted,
    
    /// <summary>
    /// Transaction could not be processed as Issuer is unavailable.
    /// Encoded/decoded by serializers as "ISSU".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_GdyfsHuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as Issuer is unavailable.")]
    IssuerUnavailable,
    
    /// <summary>
    /// Transaction could not be processed as Issuer times out.
    /// Encoded/decoded by serializers as "ISST".
    /// </summary>
    [EnumMember(Value = "ISST")]
    [IsoId("_KdyxcHuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as Issuer times out.")]
    IssuerTimeOut,
    
    /// <summary>
    /// Transaction could not be processed as Issuer is signed off.
    /// Encoded/decoded by serializers as "ISSO".
    /// </summary>
    [EnumMember(Value = "ISSO")]
    [IsoId("_N6x1sHuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as Issuer is signed off.")]
    IssuerSignedOff,
    
    /// <summary>
    /// Issuer is not found.
    /// Encoded/decoded by serializers as "ISSF".
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_QThOsHuKEeSZrqGdHyoIrw")]
    [Description(@"Issuer is not found.")]
    IssuerNotFound,
    
    /// <summary>
    /// Issuer is inoperative.
    /// Encoded/decoded by serializers as "ISSP".
    /// </summary>
    [EnumMember(Value = "ISSP")]
    [IsoId("_TE6_UHuKEeSZrqGdHyoIrw")]
    [Description(@"Issuer is inoperative.")]
    IssuerInoperative,
    
    /// <summary>
    /// Date time of the transaction is invalid.
    /// Encoded/decoded by serializers as "DATI".
    /// </summary>
    [EnumMember(Value = "DATI")]
    [IsoId("_VIWPoHuKEeSZrqGdHyoIrw")]
    [Description(@"Date time of the transaction is invalid.")]
    InvalidTransactionDateTime,
    
    /// <summary>
    /// Transaction is invalid.
    /// Encoded/decoded by serializers as "TXNV".
    /// </summary>
    [EnumMember(Value = "TXNV")]
    [IsoId("_YBUn4HuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction is invalid.")]
    InvalidTransaction,
    
    /// <summary>
    /// Identification of the token provider or the token requestor is invalid.
    /// Encoded/decoded by serializers as "TKID".
    /// </summary>
    [EnumMember(Value = "TKID")]
    [IsoId("_aAoNMHuKEeSZrqGdHyoIrw")]
    [Description(@"Identification of the token provider or the token requestor is invalid.")]
    InvalidTokenIdentification,
    
    /// <summary>
    /// Token cannot be used to surrogate a PAN (Primary Account Number).
    /// Encoded/decoded by serializers as "TKKO".
    /// </summary>
    [EnumMember(Value = "TKKO")]
    [IsoId("_c-gTkHuKEeSZrqGdHyoIrw")]
    [Description(@"Token cannot be used to surrogate a PAN (Primary Account Number).")]
    InvalidToken,
    
    /// <summary>
    /// Security code validation fails.
    /// Encoded/decoded by serializers as "CSCV".
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_gZa7QHuKEeSZrqGdHyoIrw")]
    [Description(@"Security code validation fails.")]
    InvalidSecurityCode,
    
    /// <summary>
    /// PIN is invalid.
    /// Encoded/decoded by serializers as "PINV".
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_il9EQHuKEeSZrqGdHyoIrw")]
    [Description(@"PIN is invalid.")]
    InvalidPIN,
    
    /// <summary>
    /// Original amount is invalid.
    /// Encoded/decoded by serializers as "AMTO".
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_lMtEEHuKEeSZrqGdHyoIrw")]
    [Description(@"Original amount is invalid.")]
    InvalidOriginalAmount,
    
    /// <summary>
    /// Digital certificate cannot be authenticated, is expired or revoked.
    /// Encoded/decoded by serializers as "CTFV".
    /// </summary>
    [EnumMember(Value = "CTFV")]
    [IsoId("_nSqrAHuKEeSZrqGdHyoIrw")]
    [Description(@"Digital certificate cannot be authenticated, is expired or revoked.")]
    InvalidCertificate,
    
    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as "CRDI".
    /// </summary>
    [EnumMember(Value = "CRDI")]
    [IsoId("_qUrqgHuKEeSZrqGdHyoIrw")]
    [Description(@"Identification of the card is invalid.")]
    InvalidCardNumber,
    
    /// <summary>
    /// Identification of the cardholder or the customer does not match.
    /// Encoded/decoded by serializers as "CHDI".
    /// </summary>
    [EnumMember(Value = "CHDI")]
    [IsoId("_skaRcHuKEeSZrqGdHyoIrw")]
    [Description(@"Identification of the cardholder or the customer does not match.")]
    InvalidCardholderIdentification,
    
    /// <summary>
    /// Requested amount is outside the card limits, or the currency is invalid.
    /// Encoded/decoded by serializers as "AMTI".
    /// </summary>
    [EnumMember(Value = "AMTI")]
    [IsoId("_vOU6AHuKEeSZrqGdHyoIrw")]
    [Description(@"Requested amount is outside the card limits, or the currency is invalid.")]
    InvalidAmount,
    
    /// <summary>
    /// Issuer denies the acceptor.
    /// Encoded/decoded by serializers as "ACPI".
    /// </summary>
    [EnumMember(Value = "ACPI")]
    [IsoId("_x4pLMHuKEeSZrqGdHyoIrw")]
    [Description(@"Issuer denies the acceptor.")]
    InvalidAcceptor,
    
    /// <summary>
    /// Account balance is not sufficient.
    /// Encoded/decoded by serializers as "FNDI".
    /// </summary>
    [EnumMember(Value = "FNDI")]
    [IsoId("_1YjAkHuKEeSZrqGdHyoIrw")]
    [Description(@"Account balance is not sufficient.")]
    InsufficientFunds,
    
    /// <summary>
    /// Original request is in progress.
    /// Encoded/decoded by serializers as "TXNG".
    /// </summary>
    [EnumMember(Value = "TXNG")]
    [IsoId("_3kxAgHuKEeSZrqGdHyoIrw")]
    [Description(@"Original request is in progress.")]
    InProgress,
    
    /// <summary>
    /// From account status error.
    /// Encoded/decoded by serializers as "ACEF".
    /// </summary>
    [EnumMember(Value = "ACEF")]
    [IsoId("_5rLTYHuKEeSZrqGdHyoIrw")]
    [Description(@"From account status error.")]
    FromAccountError,
    
    /// <summary>
    /// Invalid format of the message or its content.
    /// Encoded/decoded by serializers as "FMTR".
    /// </summary>
    [EnumMember(Value = "FMTR")]
    [IsoId("_9dB0YHuKEeSZrqGdHyoIrw")]
    [Description(@"Invalid format of the message or its content.")]
    FormatError,
    
    /// <summary>
    /// Card has expired.
    /// Encoded/decoded by serializers as "CRDX".
    /// </summary>
    [EnumMember(Value = "CRDX")]
    [IsoId("__qJMMHuKEeSZrqGdHyoIrw")]
    [Description(@"Card has expired.")]
    ExpiredCard,
    
    /// <summary>
    /// Validity period of the transaction is exceeded.
    /// Encoded/decoded by serializers as "TXNL".
    /// </summary>
    [EnumMember(Value = "TXNL")]
    [IsoId("_CT5csHuLEeSZrqGdHyoIrw")]
    [Description(@"Validity period of the transaction is exceeded.")]
    ExceededTransactionLifeCycle,
    
    /// <summary>
    /// Transaction fees are disputed by the issuer.
    /// Encoded/decoded by serializers as "FEES".
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_Ec_3MHuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction fees are disputed by the issuer.")]
    DisputedFees,
    
    /// <summary>
    /// Database access error.
    /// Encoded/decoded by serializers as "DBER".
    /// </summary>
    [EnumMember(Value = "DBER")]
    [IsoId("_HeKiIHuLEeSZrqGdHyoIrw")]
    [Description(@"Database access error.")]
    DatabaseError,
    
    /// <summary>
    /// Cutover is in progress, transaction could not be processed.
    /// Encoded/decoded by serializers as "CTVG".
    /// </summary>
    [EnumMember(Value = "CTVG")]
    [IsoId("_JyIv4HuLEeSZrqGdHyoIrw")]
    [Description(@"Cutover is in progress, transaction could not be processed.")]
    CutoverInProcess,
    
    /// <summary>
    /// Account is no more usable for the transaction.
    /// Encoded/decoded by serializers as "ACTC".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_LzBpkHuLEeSZrqGdHyoIrw")]
    [Description(@"Account is no more usable for the transaction.")]
    ClosedAccount,
    
    /// <summary>
    /// Cashback is not permitted.
    /// Encoded/decoded by serializers as "CSHI".
    /// </summary>
    [EnumMember(Value = "CSHI")]
    [IsoId("_OpkY4HuLEeSZrqGdHyoIrw")]
    [Description(@"Cashback is not permitted.")]
    CasbackNotAllowed,
    
    /// <summary>
    /// Cashback amount is higher than permitted.
    /// Encoded/decoded by serializers as "CSHE".
    /// </summary>
    [EnumMember(Value = "CSHE")]
    [IsoId("_QnyZEHuLEeSZrqGdHyoIrw")]
    [Description(@"Cashback amount is higher than permitted.")]
    CashbackAmountExceeded,
    
    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as "CRDF".
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_TMS9MHuLEeSZrqGdHyoIrw")]
    [Description(@"Identification of the card is invalid.")]
    CardVerificationFailed,
    
    /// <summary>
    /// Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).
    /// Encoded/decoded by serializers as "CRDR".
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_V26wYHuLEeSZrqGdHyoIrw")]
    [Description(@"Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).")]
    CardError,
    
    /// <summary>
    /// Bank not found.
    /// Encoded/decoded by serializers as "BANK".
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_foLPEHuLEeSZrqGdHyoIrw")]
    [Description(@"Bank not found.")]
    BankNotFound,
    
    /// <summary>
    /// Amount not found.
    /// Encoded/decoded by serializers as "AMTA".
    /// </summary>
    [EnumMember(Value = "AMTA")]
    [IsoId("_hnfbcHuLEeSZrqGdHyoIrw")]
    [Description(@"Amount not found.")]
    AmountNotFound,
    
    /// <summary>
    /// Message is acknowledged only without processing the service, for instance the reconciliation is not performed, acknowledged only.
    /// Encoded/decoded by serializers as "ACKO".
    /// </summary>
    [EnumMember(Value = "ACKO")]
    [IsoId("_HyHIEIO-EeSWSLYdc10LRg")]
    [Description(@"Message is acknowledged only without processing the service, for instance the reconciliation is not performed, acknowledged only.")]
    AcknowledgementOnly,
    
    /// <summary>
    /// Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_unlPQM4tEeSiNPH-YrkZ3A")]
    [Description(@"Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.")]
    AuthenticationFailed,
    
    /// <summary>
    /// Amount of deposit transactions exceeds the limit.
    /// Encoded/decoded by serializers as "AMTD".
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_AyGe8M4uEeSiNPH-YrkZ3A")]
    [Description(@"Amount of deposit transactions exceeds the limit.")]
    DepositAmountLimit,
    
    /// <summary>
    /// Number of deposit transactions or items exceeds the limit.
    /// Encoded/decoded by serializers as "NMBD".
    /// </summary>
    [EnumMember(Value = "NMBD")]
    [IsoId("_QkahIM4uEeSiNPH-YrkZ3A")]
    [Description(@"Number of deposit transactions or items exceeds the limit.")]
    DepositNumberLimit,
    
    /// <summary>
    /// Issuer declined the fall-back transaction.
    /// Encoded/decoded by serializers as "FDCL".
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_d32GEM4uEeSiNPH-YrkZ3A")]
    [Description(@"Issuer declined the fall-back transaction.")]
    FallbackDeclined,
    
    /// <summary>
    /// Part of the specified address is incorrect.
    /// Encoded/decoded by serializers as "ADDI".
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_nEifIM4uEeSiNPH-YrkZ3A")]
    [Description(@"Part of the specified address is incorrect.")]
    InvalidAddress,
    
    /// <summary>
    /// Invalid branch or bank information.
    /// Encoded/decoded by serializers as "BRHI".
    /// </summary>
    [EnumMember(Value = "BRHI")]
    [IsoId("_2YXOgM4uEeSiNPH-YrkZ3A")]
    [Description(@"Invalid branch or bank information.")]
    InvalidBranch,
    
    /// <summary>
    /// Signed message has an invalid signature.
    /// Encoded/decoded by serializers as "SGNI".
    /// </summary>
    [EnumMember(Value = "SGNI")]
    [IsoId("_9f548M4uEeSiNPH-YrkZ3A")]
    [Description(@"Signed message has an invalid signature.")]
    InvalidSignature,
    
    /// <summary>
    /// Storage space not available for the key.
    /// Encoded/decoded by serializers as "KEYS".
    /// </summary>
    [EnumMember(Value = "KEYS")]
    [IsoId("_DjdW0M4vEeSiNPH-YrkZ3A")]
    [Description(@"Storage space not available for the key.")]
    KeyStorageSaturation,
    
    /// <summary>
    /// ICC data elements required for processing the ICC transaction were not present in the message.
    /// Encoded/decoded by serializers as "ICCM".
    /// </summary>
    [EnumMember(Value = "ICCM")]
    [IsoId("_lNEVQM4wEeSiNPH-YrkZ3A")]
    [Description(@"ICC data elements required for processing the ICC transaction were not present in the message.")]
    MissingICCData,
    
    /// <summary>
    /// Cardholder or customer has not enabled the service with the service provider.
    /// Encoded/decoded by serializers as "SRVU".
    /// </summary>
    [EnumMember(Value = "SRVU")]
    [IsoId("_x9LKsM4wEeSiNPH-YrkZ3A")]
    [Description(@"Cardholder or customer has not enabled the service with the service provider.")]
    ServiceNotEnabled,
    
    /// <summary>
    /// Server received a terminal identification that it does not have any knowledge of.
    /// Encoded/decoded by serializers as "TRMI".
    /// </summary>
    [EnumMember(Value = "TRMI")]
    [IsoId("_5EFjAM4wEeSiNPH-YrkZ3A")]
    [Description(@"Server received a terminal identification that it does not have any knowledge of.")]
    TerminalNotConfigured,
    
    /// <summary>
    /// The certificate is unknown.
    /// Encoded/decoded by serializers as "CRTU".
    /// </summary>
    [EnumMember(Value = "CRTU")]
    [IsoId("_TuJvkI4YEeW6h7rGyYlyTg")]
    [Description(@"The certificate is unknown.")]
    UnknownCertificate,
    
    /// <summary>
    /// The requested media are not allowed for the service.
    /// Encoded/decoded by serializers as "MEDI".
    /// </summary>
    [EnumMember(Value = "MEDI")]
    [IsoId("_g2QO4K2AEeWMg5rOByfExw")]
    [Description(@"The requested media are not allowed for the service.")]
    InvalidMediaType,
    
    /// <summary>
    /// The requested service is not allowed.
    /// Encoded/decoded by serializers as "SRVI".
    /// </summary>
    [EnumMember(Value = "SRVI")]
    [IsoId("_kTHXUK2AEeWMg5rOByfExw")]
    [Description(@"The requested service is not allowed.")]
    InvalidService,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResultDetailCodeMetadataExtensions
{
    private static readonly ResultDetailCodeDropdownSource _dropdownSource = new ResultDetailCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResultDetailCodeDropdownRow GetMetadata(this ResultDetailCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


