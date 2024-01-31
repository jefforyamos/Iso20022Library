﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingSettlement2Code.  ISO2002 ID# _aDKsE9p-Ed-ak6NoX_4Aeg_-1807424402.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending settlement, that is, pending delivery or receipt of the financial instrument. Settlement on the instructed settlement date is still possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aDKsE9p-Ed-ak6NoX_4Aeg_-1807424402")]
[Description(@"Specifies the reason the transaction/instruction is pending settlement, that is, pending delivery or receipt of the financial instrument. Settlement on the instructed settlement date is still possible.")]
[DerivedFrom(typeof(PendingSettlementStatusReasonCode))]
public enum PendingSettlement2Code
{
    /// <summary>
    /// Securities have been delivered, but the settlement amount has not been received from the counterparty.
    /// Encoded/decoded by serializers as "AWMO".
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_aDKsFNp-Ed-ak6NoX_4Aeg_508168770")]
    [Description(@"Securities have been delivered, but the settlement amount has not been received from the counterparty.")]
    AwaitingMoney = PendingSettlementStatusReasonCode.AwaitingMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc.
    /// Encoded/decoded by serializers as "CAIS".
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_aDKsFdp-Ed-ak6NoX_4Aeg_508169110")]
    [Description(@"Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc.")]
    AwaitingSecurities = PendingSettlementStatusReasonCode.AwaitingSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction that has been refused or not recognised, and is represented automatically.
    /// Encoded/decoded by serializers as "REFU".
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_aDKsFtp-Ed-ak6NoX_4Aeg_508169480")]
    [Description(@"Instruction that has been refused or not recognised, and is represented automatically.")]
    InstructionRefusedOrNotRecognised = PendingSettlementStatusReasonCode.InstructionRefusedOrNotRecognised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities have not yet been received from the counterparty.
    /// Encoded/decoded by serializers as "AWSH".
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_aDKsF9p-Ed-ak6NoX_4Aeg_508169596")]
    [Description(@"Securities have not yet been received from the counterparty.")]
    AwaitingSharesFromCounterparty = PendingSettlementStatusReasonCode.AwaitingSharesFromCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is physical and securities are being delivered.
    /// Encoded/decoded by serializers as "PHSE".
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_aDKsGNp-Ed-ak6NoX_4Aeg_508169718")]
    [Description(@"Settlement is physical and securities are being delivered.")]
    PhysicalDeliveryDelay = PendingSettlementStatusReasonCode.PhysicalDeliveryDelay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is being amended in the market.
    /// Encoded/decoded by serializers as "TAMM".
    /// </summary>
    [EnumMember(Value = "TAMM")]
    [IsoId("_aDKsGdp-Ed-ak6NoX_4Aeg_508170058")]
    [Description(@"Trade is being amended in the market.")]
    TradeAmendedInMarket = PendingSettlementStatusReasonCode.TradeAmendedInMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as "DOCY".
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_aDUdENp-Ed-ak6NoX_4Aeg_508170459")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou = PendingSettlementStatusReasonCode.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting documents or endorsements from the counterparty.
    /// Encoded/decoded by serializers as "DOCC".
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_aDUdEdp-Ed-ak6NoX_4Aeg_508170612")]
    [Description(@"Awaiting documents or endorsements from the counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty = PendingSettlementStatusReasonCode.AwaitingDocumentsOrEndorsementsFromCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as "BLOC".
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_aDUdEtp-Ed-ak6NoX_4Aeg_508170951")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingSettlementStatusReasonCode.AccountBlocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Chaser/enquiry sent to the agent or depository.
    /// Encoded/decoded by serializers as "CHAS".
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_aDUdE9p-Ed-ak6NoX_4Aeg_508171096")]
    [Description(@"Chaser/enquiry sent to the agent or depository.")]
    EnquirySent = PendingSettlementStatusReasonCode.EnquirySent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities are new issues and are not yet available/tradable.
    /// Encoded/decoded by serializers as "NEWI".
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_aDUdFNp-Ed-ak6NoX_4Aeg_508171498")]
    [Description(@"Securities are new issues and are not yet available/tradable.")]
    NewIssues = PendingSettlementStatusReasonCode.NewIssues, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities.
    /// Encoded/decoded by serializers as "CLAC".
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_aDUdFdp-Ed-ak6NoX_4Aeg_508171651")]
    [Description(@"Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities.")]
    CounterpartyInsufficientSecurities = PendingSettlementStatusReasonCode.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities quantity is not a multiple of an existing settlement amount lot for the instructed financial instrument.
    /// Encoded/decoded by serializers as "MUNO".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_aDUdFtp-Ed-ak6NoX_4Aeg_508171983")]
    [Description(@"Securities quantity is not a multiple of an existing settlement amount lot for the instructed financial instrument.")]
    MultipleSettlementAmount = PendingSettlementStatusReasonCode.MultipleSettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement cannot be executed as securities are in global form.
    /// Encoded/decoded by serializers as "GLOB".
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_aDUdF9p-Ed-ak6NoX_4Aeg_509092107")]
    [Description(@"Settlement cannot be executed as securities are in global form.")]
    GlobalFormSecurities = PendingSettlementStatusReasonCode.GlobalFormSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction is a preadvice, that is, matching only.
    /// Encoded/decoded by serializers as "PREA".
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_aDUdGNp-Ed-ak6NoX_4Aeg_509092260")]
    [Description(@"Your instruction is a preadvice, that is, matching only.")]
    PreadviceInstructed = PendingSettlementStatusReasonCode.PreadviceInstructed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Guaranteed delivery indicator differs in the counterparty's instruction.
    /// Encoded/decoded by serializers as "GUAD".
    /// </summary>
    [EnumMember(Value = "GUAD")]
    [IsoId("_aDUdGdp-Ed-ak6NoX_4Aeg_509092631")]
    [Description(@"Guaranteed delivery indicator differs in the counterparty's instruction.")]
    GuaranteedDeliveryIndicatorDifference = PendingSettlementStatusReasonCode.GuaranteedDeliveryIndicatorDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_aDdnANp-Ed-ak6NoX_4Aeg_509093032")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials = PendingSettlementStatusReasonCode.TradeSettlesInPartials, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has not been matched because the matching process is not required.
    /// Encoded/decoded by serializers as "NMAS".
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_aDdnAdp-Ed-ak6NoX_4Aeg_509093208")]
    [Description(@"Instruction has not been matched because the matching process is not required.")]
    NoMatchingRequired = PendingSettlementStatusReasonCode.NoMatchingRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient money in the counterparty's account.
    /// Encoded/decoded by serializers as "CMON".
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_aDdnAtp-Ed-ak6NoX_4Aeg_509093579")]
    [Description(@"Insufficient money in the counterparty's account.")]
    CounterpartyInsufficientMoney = PendingSettlementStatusReasonCode.CounterpartyInsufficientMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not enough collateral in your account to execute the transaction.
    /// Encoded/decoded by serializers as "YCOL".
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_aDdnA9p-Ed-ak6NoX_4Aeg_509094010")]
    [Description(@"Not enough collateral in your account to execute the transaction.")]
    CollateralShortage = PendingSettlementStatusReasonCode.CollateralShortage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as "COLL".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_aDdnBNp-Ed-ak6NoX_4Aeg_509094163")]
    [Description(@"Securities are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral = PendingSettlementStatusReasonCode.SecuritiesPledgedAsCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment for depositary receipts granted by the issuer is exceeded by the transaction.
    /// Encoded/decoded by serializers as "DEPO".
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_aDdnBdp-Ed-ak6NoX_4Aeg_509095141")]
    [Description(@"Deposit of shares for the issuing of depositary receipts has been refused. The allotment for depositary receipts granted by the issuer is exceeded by the transaction.")]
    RefusedDepositForIssueOfDepositaryReceipts = PendingSettlementStatusReasonCode.RefusedDepositForIssueOfDepositaryReceipts, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient deliverable securities in your account because the maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as "FLIM".
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_aDdnBtp-Ed-ak6NoX_4Aeg_510016553")]
    [Description(@"Insufficient deliverable securities in your account because the maximum foreign limit has been reached.")]
    MaximumForeignLimitReached = PendingSettlementStatusReasonCode.MaximumForeignLimitReached, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Foreign exchange instruction is missing.
    /// Encoded/decoded by serializers as "NOFX".
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_aDdnB9p-Ed-ak6NoX_4Aeg_510018055")]
    [Description(@"Foreign exchange instruction is missing.")]
    NoForeignExchangeInstruction = PendingSettlementStatusReasonCode.NoForeignExchangeInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as "INCA".
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_aDdnCNp-Ed-ak6NoX_4Aeg_510939611")]
    [Description(@"Securities require income adjustment, for example, dividend or interest.")]
    IncomeAdjustementRequired = PendingSettlementStatusReasonCode.IncomeAdjustementRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as "LINK".
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_aDdnCdp-Ed-ak6NoX_4Aeg_510941236")]
    [Description(@"Your instruction is pending settlement because the instruction linked to it is pending.")]
    PendingLinkedInstruction = PendingSettlementStatusReasonCode.PendingLinkedInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is awaiting the settlement date, and no settlement problems have been reported.
    /// Encoded/decoded by serializers as "FUTU".
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_aDnYANp-Ed-ak6NoX_4Aeg_511862793")]
    [Description(@"Instruction is awaiting the settlement date, and no settlement problems have been reported.")]
    AwaitingSettlementDate = PendingSettlementStatusReasonCode.AwaitingSettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient deliverable securities in your account.
    /// Encoded/decoded by serializers as "LACK".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_aDnYAdp-Ed-ak6NoX_4Aeg_511864604")]
    [Description(@"Insufficient deliverable securities in your account.")]
    LackOfSecurities = PendingSettlementStatusReasonCode.LackOfSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient deliverable securities in your account because securities are loaned out.
    /// Encoded/decoded by serializers as "LALO".
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_aDnYAtp-Ed-ak6NoX_4Aeg_511866044")]
    [Description(@"Insufficient deliverable securities in your account because securities are loaned out.")]
    SecuritiesLoanedOut = PendingSettlementStatusReasonCode.SecuritiesLoanedOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as "MONY".
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_aDnYA9p-Ed-ak6NoX_4Aeg_512787201")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingSettlementStatusReasonCode.InsufficientMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement confirmation has not been received.
    /// Encoded/decoded by serializers as "NCON".
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_aDnYBNp-Ed-ak6NoX_4Aeg_512788618")]
    [Description(@"Settlement confirmation has not been received.")]
    ConfirmationNotReceived = PendingSettlementStatusReasonCode.ConfirmationNotReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery/receipt has been refused because the physical securities are not in good order.
    /// Encoded/decoded by serializers as "REFS".
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_aDnYBdp-Ed-ak6NoX_4Aeg_513709774")]
    [Description(@"Delivery/receipt has been refused because the physical securities are not in good order.")]
    NotInGoodOrder = PendingSettlementStatusReasonCode.NotInGoodOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is pending as stamp duty information is missing.
    /// Encoded/decoded by serializers as "SDUT".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_aDnYBtp-Ed-ak6NoX_4Aeg_513711184")]
    [Description(@"Instruction is pending as stamp duty information is missing.")]
    LackOfStampDutyInformation = PendingSettlementStatusReasonCode.LackOfStampDutyInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing batch differs in the counterparty's instruction, for example, day time/real time versus overnight.
    /// Encoded/decoded by serializers as "BATC".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_aDnYB9p-Ed-ak6NoX_4Aeg_513712624")]
    [Description(@"Processing batch differs in the counterparty's instruction, for example, day time/real time versus overnight.")]
    ProcessingBatchDifference = PendingSettlementStatusReasonCode.ProcessingBatchDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is confirmed in the local market or is ready for settlement, awaiting the next settlement cycle.
    /// Encoded/decoded by serializers as "CYCL".
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_aDnYCNp-Ed-ak6NoX_4Aeg_514633757")]
    [Description(@"Instruction is confirmed in the local market or is ready for settlement, awaiting the next settlement cycle.")]
    AwaitingNextSettlementCycle = PendingSettlementStatusReasonCode.AwaitingNextSettlementCycle, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment.
    /// Encoded/decoded by serializers as "SBLO".
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_aDnYCdp-Ed-ak6NoX_4Aeg_514635198")]
    [Description(@"Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment.")]
    SecuritiesBlocked = PendingSettlementStatusReasonCode.SecuritiesBlocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty is in receivership, that is, the form of bankruptcy where a court appointed person, the receiver, manages the affairs of the business.
    /// Encoded/decoded by serializers as "CPEC".
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_aDxJANp-Ed-ak6NoX_4Aeg_514636607")]
    [Description(@"Counterparty is in receivership, that is, the form of bankruptcy where a court appointed person, the receiver, manages the affairs of the business.")]
    CounterpartyInReceivership = PendingSettlementStatusReasonCode.CounterpartyInReceivership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities amount is lower than the minimum existing settlement amount for the instructed financial instrument.
    /// Encoded/decoded by serializers as "MINO".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_aDxJAdp-Ed-ak6NoX_4Aeg_515557794")]
    [Description(@"Securities amount is lower than the minimum existing settlement amount for the instructed financial instrument.")]
    MinimumSettlementAmount = PendingSettlementStatusReasonCode.MinimumSettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart (bilateral limit) prevents settlement.
    /// Encoded/decoded by serializers as "PCAP".
    /// </summary>
    [EnumMember(Value = "PCAP")]
    [IsoId("_aDxJAtp-Ed-ak6NoX_4Aeg_515559203")]
    [Description(@"Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart (bilateral limit) prevents settlement.")]
    PendingCAP = PendingSettlementStatusReasonCode.PendingCAP, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingSettlement2CodeMetadataExtensions
{
    private static readonly PendingSettlement2CodeDropdownSource _dropdownSource = new PendingSettlement2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingSettlement2CodeDropdownRow GetMetadata(this PendingSettlement2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


