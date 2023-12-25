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
    /// </summary>
    [EnumMember(Value = "CRDW")]
    [IsoId("_CxNnoHuHEeSZrqGdHyoIrw")]
    [Description(@"Other card used for the original transaction.")]
    CRDW,
    
    /// <summary>
    /// Number of withdrawal transactions exceeds card limit.
    /// </summary>
    [EnumMember(Value = "NMBW")]
    [IsoId("_FxvZYHuHEeSZrqGdHyoIrw")]
    [Description(@"Number of withdrawal transactions exceeds card limit.")]
    NMBW,
    
    /// <summary>
    /// Amount of withdrawal transactions exceeds card limit.
    /// </summary>
    [EnumMember(Value = "AMTW")]
    [IsoId("_IXTGYHuHEeSZrqGdHyoIrw")]
    [Description(@"Amount of withdrawal transactions exceeds card limit.")]
    AMTW,
    
    /// <summary>
    /// Vendor not found.
    /// </summary>
    [EnumMember(Value = "VNDF")]
    [IsoId("_Rl1SgHuHEeSZrqGdHyoIrw")]
    [Description(@"Vendor not found.")]
    VNDF,
    
    /// <summary>
    /// Vendor format has an error.
    /// </summary>
    [EnumMember(Value = "VNDR")]
    [IsoId("_T0UjUHuHEeSZrqGdHyoIrw")]
    [Description(@"Vendor format has an error.")]
    VNDR,
    
    /// <summary>
    /// Account of the cardholder or the customer is not found.
    /// </summary>
    [EnumMember(Value = "ACTF")]
    [IsoId("_YK13oHuHEeSZrqGdHyoIrw")]
    [Description(@"Account of the cardholder or the customer is not found.")]
    ACTF,
    
    /// <summary>
    /// Acquirer is not supported.
    /// </summary>
    [EnumMember(Value = "ACQS")]
    [IsoId("_dw7WYHuHEeSZrqGdHyoIrw")]
    [Description(@"Acquirer is not supported.")]
    ACQS,
    
    /// <summary>
    /// Error on AML (Anti Money Laundering) validation.
    /// </summary>
    [EnumMember(Value = "AMLV")]
    [IsoId("_gCNcgHuHEeSZrqGdHyoIrw")]
    [Description(@"Error on AML (Anti Money Laundering) validation.")]
    AMLV,
    
    /// <summary>
    /// Requested service not supported.
    /// </summary>
    [EnumMember(Value = "SVSU")]
    [IsoId("_rLuuoHuHEeSZrqGdHyoIrw")]
    [Description(@"Requested service not supported.")]
    SVSU,
    
    /// <summary>
    /// Card is not active yet.
    /// </summary>
    [EnumMember(Value = "CRDU")]
    [IsoId("_t8TY0HuHEeSZrqGdHyoIrw")]
    [Description(@"Card is not active yet.")]
    CRDU,
    
    /// <summary>
    /// Communication keys are not available.
    /// </summary>
    [EnumMember(Value = "CMKY")]
    [IsoId("_wkeU8HuHEeSZrqGdHyoIrw")]
    [Description(@"Communication keys are not available.")]
    CMKY,
    
    /// <summary>
    /// Currency is unacceptable for the Issuer or the processor.
    /// </summary>
    [EnumMember(Value = "UNBC")]
    [IsoId("_zn-iMHuHEeSZrqGdHyoIrw")]
    [Description(@"Currency is unacceptable for the Issuer or the processor.")]
    UNBC,
    
    /// <summary>
    /// Transaction cannot be processed offline.
    /// </summary>
    [EnumMember(Value = "UNBP")]
    [IsoId("_2QW5sHuHEeSZrqGdHyoIrw")]
    [Description(@"Transaction cannot be processed offline.")]
    UNBP,
    
    /// <summary>
    /// Transaction cannot be processed online by the terminal.
    /// </summary>
    [EnumMember(Value = "UNBO")]
    [IsoId("_5Uwe0HuHEeSZrqGdHyoIrw")]
    [Description(@"Transaction cannot be processed online by the terminal.")]
    UNBO,
    
    /// <summary>
    /// Transaction could not be processed as original is not found.
    /// </summary>
    [EnumMember(Value = "ORGF")]
    [IsoId("_7nFt0HuHEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as original is not found.")]
    ORGF,
    
    /// <summary>
    /// Transaction identification already used for another transaction.
    /// </summary>
    [EnumMember(Value = "TXND")]
    [IsoId("__Yfi4HuHEeSZrqGdHyoIrw")]
    [Description(@"Transaction identification already used for another transaction.")]
    TXND,
    
    /// <summary>
    /// Transaction did not complete at the terminal.
    /// </summary>
    [EnumMember(Value = "TXNU")]
    [IsoId("_CrpVsHuIEeSZrqGdHyoIrw")]
    [Description(@"Transaction did not complete at the terminal.")]
    TXNU,
    
    /// <summary>
    /// Totals are not available.
    /// </summary>
    [EnumMember(Value = "TTLV")]
    [IsoId("_Fo5J8HuIEeSZrqGdHyoIrw")]
    [Description(@"Totals are not available.")]
    TTLV,
    
    /// <summary>
    /// To account status error.
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_H9m-kHuIEeSZrqGdHyoIrw")]
    [Description(@"To account status error.")]
    ACTT,
    
    /// <summary>
    /// System Malfunction.
    /// </summary>
    [EnumMember(Value = "SYSM")]
    [IsoId("_LU2nMHuIEeSZrqGdHyoIrw")]
    [Description(@"System Malfunction.")]
    SYSM,
    
    /// <summary>
    /// Processing temporary not available.
    /// </summary>
    [EnumMember(Value = "SYSP")]
    [IsoId("_N3IWsHuIEeSZrqGdHyoIrw")]
    [Description(@"Processing temporary not available.")]
    SYSP,
    
    /// <summary>
    /// Fraudulent transaction is suspected by the issuer or the processor.
    /// </summary>
    [EnumMember(Value = "FRDS")]
    [IsoId("_Q4_lMHuIEeSZrqGdHyoIrw")]
    [Description(@"Fraudulent transaction is suspected by the issuer or the processor.")]
    FRDS,
    
    /// <summary>
    /// Counterfeit card suspected by the issuer or the processor.
    /// </summary>
    [EnumMember(Value = "CNTC")]
    [IsoId("_URGJcHuIEeSZrqGdHyoIrw")]
    [Description(@"Counterfeit card suspected by the issuer or the processor.")]
    CNTC,
    
    /// <summary>
    /// Surcharging is not permitted.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_X4OBIHuIEeSZrqGdHyoIrw")]
    [Description(@"Surcharging is not permitted.")]
    SRCH,
    
    /// <summary>
    /// Special card conditions not respected.
    /// </summary>
    [EnumMember(Value = "SPCC")]
    [IsoId("_aN-XkHuIEeSZrqGdHyoIrw")]
    [Description(@"Special card conditions not respected.")]
    SPCC,
    
    /// <summary>
    /// Card has been declared stolen.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_cuUNYHuIEeSZrqGdHyoIrw")]
    [Description(@"Card has been declared stolen.")]
    CRDS,
    
    /// <summary>
    /// Security software or hardware error.
    /// </summary>
    [EnumMember(Value = "SFWE")]
    [IsoId("_fAfrYHuIEeSZrqGdHyoIrw")]
    [Description(@"Security software or hardware error.")]
    SFWE,
    
    /// <summary>
    /// Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).
    /// </summary>
    [EnumMember(Value = "SECV")]
    [IsoId("_h9SzsHuIEeSZrqGdHyoIrw")]
    [Description(@"Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).")]
    SECV,
    
    /// <summary>
    /// Requested service not allowed by the card.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_443-oHuIEeSZrqGdHyoIrw")]
    [Description(@"Requested service not allowed by the card.")]
    CRDT,
    
    /// <summary>
    /// Recurring Error on Data.
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_9ZEMUHuIEeSZrqGdHyoIrw")]
    [Description(@"Recurring Error on Data.")]
    RECD,
    
    /// <summary>
    /// Store and forward queue maximum exceeded.
    /// </summary>
    [EnumMember(Value = "QMAX")]
    [IsoId("_AJDAoHuJEeSZrqGdHyoIrw")]
    [Description(@"Store and forward queue maximum exceeded.")]
    QMAX,
    
    /// <summary>
    /// Last attempt of the PIN verification fails.
    /// </summary>
    [EnumMember(Value = "PINX")]
    [IsoId("_DLvVkHuJEeSZrqGdHyoIrw")]
    [Description(@"Last attempt of the PIN verification fails.")]
    PINX,
    
    /// <summary>
    /// PIN length or PIN key is invalid.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_FjpBEHuJEeSZrqGdHyoIrw")]
    [Description(@"PIN length or PIN key is invalid.")]
    PINS,
    
    /// <summary>
    /// Decrypted PIN block is invalid.
    /// </summary>
    [EnumMember(Value = "PINE")]
    [IsoId("_IAGccHuJEeSZrqGdHyoIrw")]
    [Description(@"Decrypted PIN block is invalid.")]
    PINE,
    
    /// <summary>
    /// Additional information are required to verify the PIN.
    /// </summary>
    [EnumMember(Value = "PIND")]
    [IsoId("_KPqEQHuJEeSZrqGdHyoIrw")]
    [Description(@"Additional information are required to verify the PIN.")]
    PIND,
    
    /// <summary>
    /// Cardholder must change the PIN to be able to perform the transaction.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_OmT7cHuJEeSZrqGdHyoIrw")]
    [Description(@"Cardholder must change the PIN to be able to perform the transaction.")]
    PINC,
    
    /// <summary>
    /// Number of payment transactions exceeds card limit.
    /// </summary>
    [EnumMember(Value = "NMBL")]
    [IsoId("_Q76g4HuJEeSZrqGdHyoIrw")]
    [Description(@"Number of payment transactions exceeds card limit.")]
    NMBL,
    
    /// <summary>
    /// Amount of payment transactions exceeds card limit.
    /// </summary>
    [EnumMember(Value = "AMTL")]
    [IsoId("_Tbgv0HuJEeSZrqGdHyoIrw")]
    [Description(@"Amount of payment transactions exceeds card limit.")]
    AMTL,
    
    /// <summary>
    /// Message is out of sequence.
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_dgliYHuJEeSZrqGdHyoIrw")]
    [Description(@"Message is out of sequence.")]
    SEQO,
    
    /// <summary>
    /// Out of balance.
    /// </summary>
    [EnumMember(Value = "BALO")]
    [IsoId("_f02rEHuJEeSZrqGdHyoIrw")]
    [Description(@"Out of balance.")]
    BALO,
    
    /// <summary>
    /// Other error.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jgczEHuJEeSZrqGdHyoIrw")]
    [Description(@"Other error.")]
    OTHR,
    
    /// <summary>
    /// Original is found, but transaction does not match.
    /// </summary>
    [EnumMember(Value = "TXNM")]
    [IsoId("_ll9uEHuJEeSZrqGdHyoIrw")]
    [Description(@"Original is found, but transaction does not match.")]
    TXNM,
    
    /// <summary>
    /// Transaction has been processed offline after referral.
    /// </summary>
    [EnumMember(Value = "ONLP")]
    [IsoId("_o5tWwHuJEeSZrqGdHyoIrw")]
    [Description(@"Transaction has been processed offline after referral.")]
    ONLP,
    
    /// <summary>
    /// Transaction has been processed offline by the terminal.
    /// </summary>
    [EnumMember(Value = "OFFL")]
    [IsoId("_q7gPYHuJEeSZrqGdHyoIrw")]
    [Description(@"Transaction has been processed offline by the terminal.")]
    OFFL,
    
    /// <summary>
    /// Transaction not permitted to the cardholder or the customer.
    /// </summary>
    [EnumMember(Value = "NPRC")]
    [IsoId("_tlhloHuJEeSZrqGdHyoIrw")]
    [Description(@"Transaction not permitted to the cardholder or the customer.")]
    NPRC,
    
    /// <summary>
    /// Process not permitted to the acceptor (for example fall back).
    /// </summary>
    [EnumMember(Value = "NPRA")]
    [IsoId("_vd7RsHuJEeSZrqGdHyoIrw")]
    [Description(@"Process not permitted to the acceptor (for example fall back).")]
    NPRA,
    
    /// <summary>
    /// PIN could not be validated.
    /// </summary>
    [EnumMember(Value = "PINA")]
    [IsoId("_yjEdsHuJEeSZrqGdHyoIrw")]
    [Description(@"PIN could not be validated.")]
    PINA,
    
    /// <summary>
    /// No card file record.
    /// </summary>
    [EnumMember(Value = "CRDA")]
    [IsoId("_1IVPwHuJEeSZrqGdHyoIrw")]
    [Description(@"No card file record.")]
    CRDA,
    
    /// <summary>
    /// New PIN is invalid (PIN change).
    /// </summary>
    [EnumMember(Value = "PINN")]
    [IsoId("_3jo0kHuJEeSZrqGdHyoIrw")]
    [Description(@"New PIN is invalid (PIN change).")]
    PINN,
    
    /// <summary>
    /// Card has been declared lost.
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_6y2ikHuJEeSZrqGdHyoIrw")]
    [Description(@"Card has been declared lost.")]
    CRDL,
    
    /// <summary>
    /// Transaction is processed, but liability is not accepted.
    /// </summary>
    [EnumMember(Value = "LBLU")]
    [IsoId("_9eiswHuJEeSZrqGdHyoIrw")]
    [Description(@"Transaction is processed, but liability is not accepted.")]
    LBLU,
    
    /// <summary>
    /// MAC key error.
    /// </summary>
    [EnumMember(Value = "MACK")]
    [IsoId("__i3U8HuJEeSZrqGdHyoIrw")]
    [Description(@"MAC key error.")]
    MACK,
    
    /// <summary>
    /// MAC error.
    /// </summary>
    [EnumMember(Value = "MACR")]
    [IsoId("_Bwb_wHuKEeSZrqGdHyoIrw")]
    [Description(@"MAC error.")]
    MACR,
    
    /// <summary>
    /// Transaction is processed and liability is accepted.
    /// </summary>
    [EnumMember(Value = "LBLA")]
    [IsoId("_EkrpAHuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction is processed and liability is accepted.")]
    LBLA,
    
    /// <summary>
    /// Transaction could not be processed as Issuer is unavailable.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_GdyfsHuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as Issuer is unavailable.")]
    ISSU,
    
    /// <summary>
    /// Transaction could not be processed as Issuer times out.
    /// </summary>
    [EnumMember(Value = "ISST")]
    [IsoId("_KdyxcHuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as Issuer times out.")]
    ISST,
    
    /// <summary>
    /// Transaction could not be processed as Issuer is signed off.
    /// </summary>
    [EnumMember(Value = "ISSO")]
    [IsoId("_N6x1sHuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as Issuer is signed off.")]
    ISSO,
    
    /// <summary>
    /// Issuer is not found.
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_QThOsHuKEeSZrqGdHyoIrw")]
    [Description(@"Issuer is not found.")]
    ISSF,
    
    /// <summary>
    /// Issuer is inoperative.
    /// </summary>
    [EnumMember(Value = "ISSP")]
    [IsoId("_TE6_UHuKEeSZrqGdHyoIrw")]
    [Description(@"Issuer is inoperative.")]
    ISSP,
    
    /// <summary>
    /// Date time of the transaction is invalid.
    /// </summary>
    [EnumMember(Value = "DATI")]
    [IsoId("_VIWPoHuKEeSZrqGdHyoIrw")]
    [Description(@"Date time of the transaction is invalid.")]
    DATI,
    
    /// <summary>
    /// Transaction is invalid.
    /// </summary>
    [EnumMember(Value = "TXNV")]
    [IsoId("_YBUn4HuKEeSZrqGdHyoIrw")]
    [Description(@"Transaction is invalid.")]
    TXNV,
    
    /// <summary>
    /// Identification of the token provider or the token requestor is invalid.
    /// </summary>
    [EnumMember(Value = "TKID")]
    [IsoId("_aAoNMHuKEeSZrqGdHyoIrw")]
    [Description(@"Identification of the token provider or the token requestor is invalid.")]
    TKID,
    
    /// <summary>
    /// Token cannot be used to surrogate a PAN (Primary Account Number).
    /// </summary>
    [EnumMember(Value = "TKKO")]
    [IsoId("_c-gTkHuKEeSZrqGdHyoIrw")]
    [Description(@"Token cannot be used to surrogate a PAN (Primary Account Number).")]
    TKKO,
    
    /// <summary>
    /// Security code validation fails.
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_gZa7QHuKEeSZrqGdHyoIrw")]
    [Description(@"Security code validation fails.")]
    CSCV,
    
    /// <summary>
    /// PIN is invalid.
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_il9EQHuKEeSZrqGdHyoIrw")]
    [Description(@"PIN is invalid.")]
    PINV,
    
    /// <summary>
    /// Original amount is invalid.
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_lMtEEHuKEeSZrqGdHyoIrw")]
    [Description(@"Original amount is invalid.")]
    AMTO,
    
    /// <summary>
    /// Digital certificate cannot be authenticated, is expired or revoked.
    /// </summary>
    [EnumMember(Value = "CTFV")]
    [IsoId("_nSqrAHuKEeSZrqGdHyoIrw")]
    [Description(@"Digital certificate cannot be authenticated, is expired or revoked.")]
    CTFV,
    
    /// <summary>
    /// Identification of the card is invalid.
    /// </summary>
    [EnumMember(Value = "CRDI")]
    [IsoId("_qUrqgHuKEeSZrqGdHyoIrw")]
    [Description(@"Identification of the card is invalid.")]
    CRDI,
    
    /// <summary>
    /// Identification of the cardholder or the customer does not match.
    /// </summary>
    [EnumMember(Value = "CHDI")]
    [IsoId("_skaRcHuKEeSZrqGdHyoIrw")]
    [Description(@"Identification of the cardholder or the customer does not match.")]
    CHDI,
    
    /// <summary>
    /// Requested amount is outside the card limits, or the currency is invalid.
    /// </summary>
    [EnumMember(Value = "AMTI")]
    [IsoId("_vOU6AHuKEeSZrqGdHyoIrw")]
    [Description(@"Requested amount is outside the card limits, or the currency is invalid.")]
    AMTI,
    
    /// <summary>
    /// Issuer denies the acceptor.
    /// </summary>
    [EnumMember(Value = "ACPI")]
    [IsoId("_x4pLMHuKEeSZrqGdHyoIrw")]
    [Description(@"Issuer denies the acceptor.")]
    ACPI,
    
    /// <summary>
    /// Account balance is not sufficient.
    /// </summary>
    [EnumMember(Value = "FNDI")]
    [IsoId("_1YjAkHuKEeSZrqGdHyoIrw")]
    [Description(@"Account balance is not sufficient.")]
    FNDI,
    
    /// <summary>
    /// Original request is in progress.
    /// </summary>
    [EnumMember(Value = "TXNG")]
    [IsoId("_3kxAgHuKEeSZrqGdHyoIrw")]
    [Description(@"Original request is in progress.")]
    TXNG,
    
    /// <summary>
    /// From account status error.
    /// </summary>
    [EnumMember(Value = "ACEF")]
    [IsoId("_5rLTYHuKEeSZrqGdHyoIrw")]
    [Description(@"From account status error.")]
    ACEF,
    
    /// <summary>
    /// Invalid format of the message or its content.
    /// </summary>
    [EnumMember(Value = "FMTR")]
    [IsoId("_9dB0YHuKEeSZrqGdHyoIrw")]
    [Description(@"Invalid format of the message or its content.")]
    FMTR,
    
    /// <summary>
    /// Card has expired.
    /// </summary>
    [EnumMember(Value = "CRDX")]
    [IsoId("__qJMMHuKEeSZrqGdHyoIrw")]
    [Description(@"Card has expired.")]
    CRDX,
    
    /// <summary>
    /// Validity period of the transaction is exceeded.
    /// </summary>
    [EnumMember(Value = "TXNL")]
    [IsoId("_CT5csHuLEeSZrqGdHyoIrw")]
    [Description(@"Validity period of the transaction is exceeded.")]
    TXNL,
    
    /// <summary>
    /// Transaction fees are disputed by the issuer.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_Ec_3MHuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction fees are disputed by the issuer.")]
    FEES,
    
    /// <summary>
    /// Database access error.
    /// </summary>
    [EnumMember(Value = "DBER")]
    [IsoId("_HeKiIHuLEeSZrqGdHyoIrw")]
    [Description(@"Database access error.")]
    DBER,
    
    /// <summary>
    /// Cutover is in progress, transaction could not be processed.
    /// </summary>
    [EnumMember(Value = "CTVG")]
    [IsoId("_JyIv4HuLEeSZrqGdHyoIrw")]
    [Description(@"Cutover is in progress, transaction could not be processed.")]
    CTVG,
    
    /// <summary>
    /// Account is no more usable for the transaction.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_LzBpkHuLEeSZrqGdHyoIrw")]
    [Description(@"Account is no more usable for the transaction.")]
    ACTC,
    
    /// <summary>
    /// Cashback is not permitted.
    /// </summary>
    [EnumMember(Value = "CSHI")]
    [IsoId("_OpkY4HuLEeSZrqGdHyoIrw")]
    [Description(@"Cashback is not permitted.")]
    CSHI,
    
    /// <summary>
    /// Cashback amount is higher than permitted.
    /// </summary>
    [EnumMember(Value = "CSHE")]
    [IsoId("_QnyZEHuLEeSZrqGdHyoIrw")]
    [Description(@"Cashback amount is higher than permitted.")]
    CSHE,
    
    /// <summary>
    /// Identification of the card is invalid.
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_TMS9MHuLEeSZrqGdHyoIrw")]
    [Description(@"Identification of the card is invalid.")]
    CRDF,
    
    /// <summary>
    /// Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_V26wYHuLEeSZrqGdHyoIrw")]
    [Description(@"Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).")]
    CRDR,
    
    /// <summary>
    /// Bank not found.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_foLPEHuLEeSZrqGdHyoIrw")]
    [Description(@"Bank not found.")]
    BANK,
    
    /// <summary>
    /// Amount not found.
    /// </summary>
    [EnumMember(Value = "AMTA")]
    [IsoId("_hnfbcHuLEeSZrqGdHyoIrw")]
    [Description(@"Amount not found.")]
    AMTA,
    
    /// <summary>
    /// Message is acknowledged only without processing the service, for instance the reconciliation is not performed, acknowledged only.
    /// </summary>
    [EnumMember(Value = "ACKO")]
    [IsoId("_HyHIEIO-EeSWSLYdc10LRg")]
    [Description(@"Message is acknowledged only without processing the service, for instance the reconciliation is not performed, acknowledged only.")]
    ACKO,
    
    /// <summary>
    /// Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_unlPQM4tEeSiNPH-YrkZ3A")]
    [Description(@"Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.")]
    AUTH,
    
    /// <summary>
    /// Amount of deposit transactions exceeds the limit.
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_AyGe8M4uEeSiNPH-YrkZ3A")]
    [Description(@"Amount of deposit transactions exceeds the limit.")]
    AMTD,
    
    /// <summary>
    /// Number of deposit transactions or items exceeds the limit.
    /// </summary>
    [EnumMember(Value = "NMBD")]
    [IsoId("_QkahIM4uEeSiNPH-YrkZ3A")]
    [Description(@"Number of deposit transactions or items exceeds the limit.")]
    NMBD,
    
    /// <summary>
    /// Issuer declined the fall-back transaction.
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_d32GEM4uEeSiNPH-YrkZ3A")]
    [Description(@"Issuer declined the fall-back transaction.")]
    FDCL,
    
    /// <summary>
    /// Part of the specified address is incorrect.
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_nEifIM4uEeSiNPH-YrkZ3A")]
    [Description(@"Part of the specified address is incorrect.")]
    ADDI,
    
    /// <summary>
    /// Invalid branch or bank information.
    /// </summary>
    [EnumMember(Value = "BRHI")]
    [IsoId("_2YXOgM4uEeSiNPH-YrkZ3A")]
    [Description(@"Invalid branch or bank information.")]
    BRHI,
    
    /// <summary>
    /// Signed message has an invalid signature.
    /// </summary>
    [EnumMember(Value = "SGNI")]
    [IsoId("_9f548M4uEeSiNPH-YrkZ3A")]
    [Description(@"Signed message has an invalid signature.")]
    SGNI,
    
    /// <summary>
    /// Storage space not available for the key.
    /// </summary>
    [EnumMember(Value = "KEYS")]
    [IsoId("_DjdW0M4vEeSiNPH-YrkZ3A")]
    [Description(@"Storage space not available for the key.")]
    KEYS,
    
    /// <summary>
    /// ICC data elements required for processing the ICC transaction were not present in the message.
    /// </summary>
    [EnumMember(Value = "ICCM")]
    [IsoId("_lNEVQM4wEeSiNPH-YrkZ3A")]
    [Description(@"ICC data elements required for processing the ICC transaction were not present in the message.")]
    ICCM,
    
    /// <summary>
    /// Cardholder or customer has not enabled the service with the service provider.
    /// </summary>
    [EnumMember(Value = "SRVU")]
    [IsoId("_x9LKsM4wEeSiNPH-YrkZ3A")]
    [Description(@"Cardholder or customer has not enabled the service with the service provider.")]
    SRVU,
    
    /// <summary>
    /// Server received a terminal identification that it does not have any knowledge of.
    /// </summary>
    [EnumMember(Value = "TRMI")]
    [IsoId("_5EFjAM4wEeSiNPH-YrkZ3A")]
    [Description(@"Server received a terminal identification that it does not have any knowledge of.")]
    TRMI,
    
    /// <summary>
    /// The certificate is unknown.
    /// </summary>
    [EnumMember(Value = "CRTU")]
    [IsoId("_TuJvkI4YEeW6h7rGyYlyTg")]
    [Description(@"The certificate is unknown.")]
    CRTU,
    
    /// <summary>
    /// The requested media are not allowed for the service.
    /// </summary>
    [EnumMember(Value = "MEDI")]
    [IsoId("_g2QO4K2AEeWMg5rOByfExw")]
    [Description(@"The requested media are not allowed for the service.")]
    MEDI,
    
    /// <summary>
    /// The requested service is not allowed.
    /// </summary>
    [EnumMember(Value = "SRVI")]
    [IsoId("_kTHXUK2AEeWMg5rOByfExw")]
    [Description(@"The requested service is not allowed.")]
    SRVI,
    
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


