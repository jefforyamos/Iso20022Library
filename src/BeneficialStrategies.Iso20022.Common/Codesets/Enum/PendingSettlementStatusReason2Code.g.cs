﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingSettlementStatusReason2Code.  ISO2002 ID# _aDxJA9p-Ed-ak6NoX_4Aeg_-1233849534.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction settlement pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aDxJA9p-Ed-ak6NoX_4Aeg_-1233849534")]
[Description(@"Specifies the reason for a transfer or settlement instruction settlement pending status.")]
[DerivedFrom(typeof(PendingSettlementStatusReasonCode))]
public enum PendingSettlementStatusReason2Code
{
    /// <summary>
    /// Securities have not yet been received from the counterparty.
    /// Encoded/decoded by serializers as "AWSH".
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_aDxJBNp-Ed-ak6NoX_4Aeg_-1233849291")]
    [Description(@"Securities have not yet been received from the counterparty.")]
    AwaitingSharesFromCounterparty = PendingSettlementStatusReasonCode.AwaitingSharesFromCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as "BLOC".
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_aDxJBdp-Ed-ak6NoX_4Aeg_-1233849275")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingSettlementStatusReasonCode.AccountBlocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc.
    /// Encoded/decoded by serializers as "CAIS".
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_aDxJBtp-Ed-ak6NoX_4Aeg_-1233849257")]
    [Description(@"Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc.")]
    AwaitingSecurities = PendingSettlementStatusReasonCode.AwaitingSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities.
    /// Encoded/decoded by serializers as "CLAC".
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_aDxJB9p-Ed-ak6NoX_4Aeg_-1233849232")]
    [Description(@"Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities.")]
    CounterpartyInsufficientSecurities = PendingSettlementStatusReasonCode.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting documents or endorsements from the counterparty.
    /// Encoded/decoded by serializers as "DOCC".
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_aDxJCNp-Ed-ak6NoX_4Aeg_-1233849215")]
    [Description(@"Awaiting documents or endorsements from the counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty = PendingSettlementStatusReasonCode.AwaitingDocumentsOrEndorsementsFromCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as "DOCY".
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_aDxJCdp-Ed-ak6NoX_4Aeg_-1233849196")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou = PendingSettlementStatusReasonCode.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending reason is being investigated.
    /// Encoded/decoded by serializers as "IAAD".
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_aD6S8Np-Ed-ak6NoX_4Aeg_-1233849171")]
    [Description(@"Pending reason is being investigated.")]
    StatusReasonInvestigation = PendingSettlementStatusReasonCode.StatusReasonInvestigation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient deliverable securities in your account.
    /// Encoded/decoded by serializers as "LACK".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_aD6S8dp-Ed-ak6NoX_4Aeg_-1233849154")]
    [Description(@"Insufficient deliverable securities in your account.")]
    LackOfSecurities = PendingSettlementStatusReasonCode.LackOfSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as "LINK".
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_aD6S8tp-Ed-ak6NoX_4Aeg_-1233849136")]
    [Description(@"Your instruction is pending settlement because the instruction linked to it is pending.")]
    PendingLinkedInstruction = PendingSettlementStatusReasonCode.PendingLinkedInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical shares have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as "PHCK".
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_aD6S89p-Ed-ak6NoX_4Aeg_-1233848853")]
    [Description(@"Physical shares have been received and are being checked for authenticity.")]
    PhysicalSecuritiesVerification = PendingSettlementStatusReasonCode.PhysicalSecuritiesVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is physical and securities are being delivered.
    /// Encoded/decoded by serializers as "PHSE".
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_aD6S9Np-Ed-ak6NoX_4Aeg_-1233848828")]
    [Description(@"Settlement is physical and securities are being delivered.")]
    PhysicalDeliveryDelay = PendingSettlementStatusReasonCode.PhysicalDeliveryDelay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment.
    /// Encoded/decoded by serializers as "SBLO".
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_aD6S9dp-Ed-ak6NoX_4Aeg_-1233848811")]
    [Description(@"Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment.")]
    SecuritiesBlocked = PendingSettlementStatusReasonCode.SecuritiesBlocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information, for example, telephone number, contact person, is missing.
    /// Encoded/decoded by serializers as "MINF".
    /// </summary>
    [EnumMember(Value = "MINF")]
    [IsoId("_aD6S9tp-Ed-ak6NoX_4Aeg_-1233848793")]
    [Description(@"Information, for example, telephone number, contact person, is missing.")]
    MissingInformation = PendingSettlementStatusReasonCode.MissingInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account must already be opened in order to process the transfer.
    /// Encoded/decoded by serializers as "ACOP".
    /// </summary>
    [EnumMember(Value = "ACOP")]
    [IsoId("_aD6S99p-Ed-ak6NoX_4Aeg_-2010200617")]
    [Description(@"Account must already be opened in order to process the transfer.")]
    AccountNotOpen = PendingSettlementStatusReasonCode.AccountNotOpen, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intermediary is investigating the reason why the transfer is pending.
    /// Encoded/decoded by serializers as "IINV".
    /// </summary>
    [EnumMember(Value = "IINV")]
    [IsoId("_aD6S-Np-Ed-ak6NoX_4Aeg_-1483792246")]
    [Description(@"Intermediary is investigating the reason why the transfer is pending.")]
    UnderInvestigation = PendingSettlementStatusReasonCode.UnderInvestigation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client has been informed of a problem and is investigating.
    /// Encoded/decoded by serializers as "CINV".
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_aD6S-dp-Ed-ak6NoX_4Aeg_1492449293")]
    [Description(@"Client has been informed of a problem and is investigating.")]
    UnderClientInvestigation = PendingSettlementStatusReasonCode.UnderClientInvestigation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer agent is investigating.
    /// Encoded/decoded by serializers as "AINV".
    /// </summary>
    [EnumMember(Value = "AINV")]
    [IsoId("_aEED8Np-Ed-ak6NoX_4Aeg_1868323412")]
    [Description(@"Transfer agent is investigating.")]
    UnderTransferAgentInvestigation = PendingSettlementStatusReasonCode.UnderTransferAgentInvestigation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is being processed by the transfer agent, awaiting status from transfer agent.
    /// Encoded/decoded by serializers as "WTRF".
    /// </summary>
    [EnumMember(Value = "WTRF")]
    [IsoId("_aEED8dp-Ed-ak6NoX_4Aeg_-1972271569")]
    [Description(@"Transfer is being processed by the transfer agent, awaiting status from transfer agent.")]
    AwaitingTransferAgentStatus = PendingSettlementStatusReasonCode.AwaitingTransferAgentStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Usual transfer agent's processing timeframe.
    /// Encoded/decoded by serializers as "USUA".
    /// </summary>
    [EnumMember(Value = "USUA")]
    [IsoId("_aEED8tp-Ed-ak6NoX_4Aeg_-192646664")]
    [Description(@"Usual transfer agent's processing timeframe.")]
    UsualTransactionTime = PendingSettlementStatusReasonCode.UsualTransactionTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// At your request, the Intermediary is checking the status of your instruction with the transfer agent.
    /// Encoded/decoded by serializers as "ASTA".
    /// </summary>
    [EnumMember(Value = "ASTA")]
    [IsoId("_aEED89p-Ed-ak6NoX_4Aeg_180454812")]
    [Description(@"At your request, the Intermediary is checking the status of your instruction with the transfer agent.")]
    AwaitingStatus = PendingSettlementStatusReasonCode.AwaitingStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Application form has been sent to the transfer agent.
    /// Encoded/decoded by serializers as "AFST".
    /// </summary>
    [EnumMember(Value = "AFST")]
    [IsoId("_aEED9Np-Ed-ak6NoX_4Aeg_116465332")]
    [Description(@"Application form has been sent to the transfer agent.")]
    ApplicationFormSent = PendingSettlementStatusReasonCode.ApplicationFormSent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent.
    /// Encoded/decoded by serializers as "STST".
    /// </summary>
    [EnumMember(Value = "STST")]
    [IsoId("_aEED9dp-Ed-ak6NoX_4Aeg_521891765")]
    [Description(@"Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent.")]
    StockTransferFormSent = PendingSettlementStatusReasonCode.StockTransferFormSent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Longer processing timeframe for this type of transfer, due to documentation requirements.
    /// Encoded/decoded by serializers as "LPRO".
    /// </summary>
    [EnumMember(Value = "LPRO")]
    [IsoId("_aEED9tp-Ed-ak6NoX_4Aeg_1023363327")]
    [Description(@"Longer processing timeframe for this type of transfer, due to documentation requirements.")]
    LongerProcessing = PendingSettlementStatusReasonCode.LongerProcessing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional documents have been requested by the transfer agent.
    /// Encoded/decoded by serializers as "ADRQ".
    /// </summary>
    [EnumMember(Value = "ADRQ")]
    [IsoId("_aEED99p-Ed-ak6NoX_4Aeg_-797492601")]
    [Description(@"Additional documents have been requested by the transfer agent.")]
    AdditionalDocumentsRequested = PendingSettlementStatusReasonCode.AdditionalDocumentsRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional documents have been sent.
    /// Encoded/decoded by serializers as "ADS1".
    /// </summary>
    [EnumMember(Value = "ADS1")]
    [IsoId("_aEED-Np-Ed-ak6NoX_4Aeg_-553683232")]
    [Description(@"Additional documents have been sent.")]
    AdditionalDocumentsSent1 = PendingSettlementStatusReasonCode.AdditionalDocumentsSent1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Upon request of the transfer agent, the intermediary has sent additional documents. The transfer agent has confirmed that all the necessary information is now in place.
    /// Encoded/decoded by serializers as "ADS2".
    /// </summary>
    [EnumMember(Value = "ADS2")]
    [IsoId("_aEED-dp-Ed-ak6NoX_4Aeg_-181502211")]
    [Description(@"Upon request of the transfer agent, the intermediary has sent additional documents. The transfer agent has confirmed that all the necessary information is now in place.")]
    AdditionalDocumentsSent2 = PendingSettlementStatusReasonCode.AdditionalDocumentsSent2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Documents are rejected by the transfer agent.
    /// Encoded/decoded by serializers as "DRJC".
    /// </summary>
    [EnumMember(Value = "DRJC")]
    [IsoId("_aEED-tp-Ed-ak6NoX_4Aeg_-93440871")]
    [Description(@"Documents are rejected by the transfer agent.")]
    DocumentsRejected = PendingSettlementStatusReasonCode.DocumentsRejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty has not sent an instruction to receive. Check with counterparty.
    /// Encoded/decoded by serializers as "CYIN".
    /// </summary>
    [EnumMember(Value = "CYIN")]
    [IsoId("_aEN08Np-Ed-ak6NoX_4Aeg_-1586114201")]
    [Description(@"Counterparty has not sent an instruction to receive. Check with counterparty.")]
    AwaitingCounterpartyReceipt = PendingSettlementStatusReasonCode.AwaitingCounterpartyReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty has not sent an instruction to deliver or delivered the shares. Check with counterparty.
    /// Encoded/decoded by serializers as "CYDV".
    /// </summary>
    [EnumMember(Value = "CYDV")]
    [IsoId("_aEN08dp-Ed-ak6NoX_4Aeg_-626574858")]
    [Description(@"Counterparty has not sent an instruction to deliver or delivered the shares. Check with counterparty.")]
    AwaitingCounterpartyDelivery = PendingSettlementStatusReasonCode.AwaitingCounterpartyDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Normal processing period for the instruction has lapsed. The transfer agent has been or will be contacted.
    /// Encoded/decoded by serializers as "OVER".
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_aEN08tp-Ed-ak6NoX_4Aeg_233223132")]
    [Description(@"Normal processing period for the instruction has lapsed. The transfer agent has been or will be contacted.")]
    NormalProcessingPeriodLapsed = PendingSettlementStatusReasonCode.NormalProcessingPeriodLapsed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wrong counterparty account details.
    /// Encoded/decoded by serializers as "WCPA".
    /// </summary>
    [EnumMember(Value = "WCPA")]
    [IsoId("_aEN089p-Ed-ak6NoX_4Aeg_633107237")]
    [Description(@"Wrong counterparty account details.")]
    WrongCounterpartyAccount = PendingSettlementStatusReasonCode.WrongCounterpartyAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is pending as stamp duty information is missing.
    /// Encoded/decoded by serializers as "SDUT".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_aEN09Np-Ed-ak6NoX_4Aeg_1897405770")]
    [Description(@"Instruction is pending as stamp duty information is missing.")]
    LackOfStampDutyInformation = PendingSettlementStatusReasonCode.LackOfStampDutyInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is being processed by transfer agent.
    /// Encoded/decoded by serializers as "TAPR".
    /// </summary>
    [EnumMember(Value = "TAPR")]
    [IsoId("_aFGlwNp-Ed-ak6NoX_4Aeg_-1973666314")]
    [Description(@"Transfer is being processed by transfer agent.")]
    TransferAgentProcessing = PendingSettlementStatusReasonCode.TransferAgentProcessing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Confirmation is expected from transfer agent.
    /// Encoded/decoded by serializers as "XCNF".
    /// </summary>
    [EnumMember(Value = "XCNF")]
    [IsoId("_aFGlwdp-Ed-ak6NoX_4Aeg_-1442639559")]
    [Description(@"Confirmation is expected from transfer agent.")]
    ExpectedConfirmation = PendingSettlementStatusReasonCode.ExpectedConfirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Special follow-up is taking place.
    /// Encoded/decoded by serializers as "ESCA".
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("_aFGlwtp-Ed-ak6NoX_4Aeg_-1442639421")]
    [Description(@"Special follow-up is taking place.")]
    Escalation = PendingSettlementStatusReasonCode.Escalation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer agent claims non-receipt of physical shares.
    /// Encoded/decoded by serializers as "NRCP".
    /// </summary>
    [EnumMember(Value = "NRCP")]
    [IsoId("_aFGlw9p-Ed-ak6NoX_4Aeg_-1442639043")]
    [Description(@"Transfer agent claims non-receipt of physical shares.")]
    TransferAgentNonReceipt = PendingSettlementStatusReasonCode.TransferAgentNonReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Confirmed but finality is to be verified.
    /// Encoded/decoded by serializers as "FVER".
    /// </summary>
    [EnumMember(Value = "FVER")]
    [IsoId("_aFGlxNp-Ed-ak6NoX_4Aeg_-1442638983")]
    [Description(@"Confirmed but finality is to be verified.")]
    FinalVerification = PendingSettlementStatusReasonCode.FinalVerification, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingSettlementStatusReason2CodeMetadataExtensions
{
    private static readonly PendingSettlementStatusReason2CodeDropdownSource _dropdownSource = new PendingSettlementStatusReason2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingSettlementStatusReason2CodeDropdownRow GetMetadata(this PendingSettlementStatusReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


