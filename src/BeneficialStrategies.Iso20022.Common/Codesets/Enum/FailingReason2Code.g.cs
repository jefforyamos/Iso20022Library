﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FailingReason2Code.  ISO2002 ID# _FkKJERqEEeG38P9Gj2JZJw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FkKJERqEEeG38P9Gj2JZJw")]
[Description(@"Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum FailingReason2Code
{
    /// <summary>
    /// Financial instruments are delivered, but still awaiting money from counterparty.
    /// Encoded/decoded by serializers as "AWMO".
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_FkKJFxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are delivered, but still awaiting money from counterparty.")]
    AwaitingMoney = PendingFailingReasonCode.AwaitingMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery).
    /// Encoded/decoded by serializers as "BYIY".
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_FkKJGxqEEeG38P9Gj2JZJw")]
    [Description(@"Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery).")]
    BuyInProcedure = PendingFailingReasonCode.BuyInProcedure, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late.
    /// Encoded/decoded by serializers as "CLAT".
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_FkKJHxqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late.")]
    CounterpartyTooLateForSettlement = PendingFailingReasonCode.CounterpartyTooLateForSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_FkKJIxqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = PendingFailingReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.
    /// Encoded/decoded by serializers as "CANR".
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("_FkKJJxqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.")]
    CancellationConfirmationRequested = PendingFailingReasonCode.CancellationConfirmationRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.
    /// Encoded/decoded by serializers as "CAIS".
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_FkKJKxqEEeG38P9Gj2JZJw")]
    [Description(@"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.")]
    AwaitingSecurities = PendingFailingReasonCode.AwaitingSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instruments are, for example, stolen, in dispute, under objection.
    /// Encoded/decoded by serializers as "OBJT".
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("_FkKJLxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are, for example, stolen, in dispute, under objection.")]
    UnderObjection = PendingFailingReasonCode.UnderObjection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.
    /// Encoded/decoded by serializers as "AWSH".
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_FkKJMxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.")]
    AwaitingSecuritiesFromCounterparty = PendingFailingReasonCode.AwaitingSecuritiesFromCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is physical. Financial instruments are being delivered.
    /// Encoded/decoded by serializers as "PHSE".
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_FkKJNxqEEeG38P9Gj2JZJw")]
    [Description(@"Settlement is physical. Financial instruments are being delivered.")]
    PhysicalDeliveryDelay = PendingFailingReasonCode.PhysicalDeliveryDelay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as "STCD".
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_FkKJOxqEEeG38P9Gj2JZJw")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepency = PendingFailingReasonCode.ConfirmationDiscrepency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as "DOCY".
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_FkKJPxqEEeG38P9Gj2JZJw")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou = PendingFailingReasonCode.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Covering money/financial instruments were received too late for completing settlement on a same day basis.
    /// Encoded/decoded by serializers as "MLAT".
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("_FkKJQxqEEeG38P9Gj2JZJw")]
    [Description(@"Covering money/financial instruments were received too late for completing settlement on a same day basis.")]
    MoneySecuritiesTooLateForSettlement = PendingFailingReasonCode.MoneySecuritiesTooLateForSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting documents or endorsements from counterparty.
    /// Encoded/decoded by serializers as "DOCC".
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_FkKJRxqEEeG38P9Gj2JZJw")]
    [Description(@"Awaiting documents or endorsements from counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty = PendingFailingReasonCode.AwaitingDocumentsOrEndorsementsFromCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as "BLOC".
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_FkKJSxqEEeG38P9Gj2JZJw")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingFailingReasonCode.AccountBlocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A chaser/enquiry has been sent.
    /// Encoded/decoded by serializers as "CHAS".
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_FkKJTxqEEeG38P9Gj2JZJw")]
    [Description(@"A chaser/enquiry has been sent.")]
    EnquirySent = PendingFailingReasonCode.EnquirySent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable.
    /// Encoded/decoded by serializers as "NEWI".
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_FkKJUxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable.")]
    NewIssues = PendingFailingReasonCode.NewIssues, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as "CLAC".
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_FkKJVxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.")]
    CounterpartyInsufficientSecurities = PendingFailingReasonCode.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MUNO".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_FkKJWxqEEeG38P9Gj2JZJw")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementAmount = PendingFailingReasonCode.MultipleSettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as "GLOB".
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_FkKJXxqEEeG38P9Gj2JZJw")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities = PendingFailingReasonCode.GlobalFormSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as "PREA".
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_FkKJYxqEEeG38P9Gj2JZJw")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold = PendingFailingReasonCode.YourInstructionOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_FkKJZxqEEeG38P9Gj2JZJw")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials = PendingFailingReasonCode.TradeSettlesInPartials, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as "NOFX".
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_FkKJaxqEEeG38P9Gj2JZJw")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction = PendingFailingReasonCode.NoForeignExchangeInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient money in counterparty's account.
    /// Encoded/decoded by serializers as "CMON".
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_FkKJbxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney = PendingFailingReasonCode.CounterpartyInsufficientMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as "YCOL".
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_FkKJcxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage = PendingFailingReasonCode.CollateralShortage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as "COLL".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_FkKJdxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral = PendingFailingReasonCode.SecuritiesPledgedAsCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.
    /// Encoded/decoded by serializers as "DEPO".
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_FkKJexqEEeG38P9Gj2JZJw")]
    [Description(@"Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.")]
    RefusedDepositForIssueOfDepositaryReceipts = PendingFailingReasonCode.RefusedDepositForIssueOfDepositaryReceipts, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as "FLIM".
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_FkKJfxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.")]
    MaximumForeignLimitReached = PendingFailingReasonCode.MaximumForeignLimitReached, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instruments require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as "INCA".
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_FkKJgxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments require income adjustment, for example, dividend or interest.")]
    IncomeAdjustementRequired = PendingFailingReasonCode.IncomeAdjustementRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as "LINK".
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_FkKJhxqEEeG38P9Gj2JZJw")]
    [Description(@"Your instruction is pending settlement because the instruction linked to it is pending.")]
    PendingLinkedInstruction = PendingFailingReasonCode.PendingLinkedInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as "LACK".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_FkKJixqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonCode.LackOfSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as "LALO".
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_FkKJjxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut = PendingFailingReasonCode.SecuritiesLoanedOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as "MONY".
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_FkKJkxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonCode.InsufficientMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Confirmation of settlement has not yet been received.
    /// Encoded/decoded by serializers as "NCON".
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_FkKJlxqEEeG38P9Gj2JZJw")]
    [Description(@"Confirmation of settlement has not yet been received.")]
    ConfirmationNotReceived = PendingFailingReasonCode.ConfirmationNotReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery/receipt was refused because physical financial instruments are not in good order.
    /// Encoded/decoded by serializers as "REFS".
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_FkKJmxqEEeG38P9Gj2JZJw")]
    [Description(@"Delivery/receipt was refused because physical financial instruments are not in good order.")]
    NotInGoodOrder = PendingFailingReasonCode.NotInGoodOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stamp duty information is missing.
    /// Encoded/decoded by serializers as "SDUT".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_FkKJnxqEEeG38P9Gj2JZJw")]
    [Description(@"Stamp duty information is missing.")]
    LackOfStampDutyInformation = PendingFailingReasonCode.LackOfStampDutyInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight.
    /// Encoded/decoded by serializers as "BATC".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_FkKJoxqEEeG38P9Gj2JZJw")]
    [Description(@"Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight.")]
    ProcessingBatchDifference = PendingFailingReasonCode.ProcessingBatchDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as "CYCL".
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_FkKJpxqEEeG38P9Gj2JZJw")]
    [Description(@"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.")]
    AwaitingNextSettlementCycle = PendingFailingReasonCode.AwaitingNextSettlementCycle, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instruments are blocked due to, for example, a corporate action event, realignment.
    /// Encoded/decoded by serializers as "SBLO".
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_FkKJqxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are blocked due to, for example, a corporate action event, realignment.")]
    SecuritiesBlocked = PendingFailingReasonCode.SecuritiesBlocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).
    /// Encoded/decoded by serializers as "CPEC".
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_FkKJrxqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).")]
    CounterpartyInReceivership = PendingFailingReasonCode.CounterpartyInReceivership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MINO".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_FkKJsxqEEeG38P9Gj2JZJw")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementAmount = PendingFailingReasonCode.MinimumSettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending reason being investigated.
    /// Encoded/decoded by serializers as "IAAD".
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_FkKJtxqEEeG38P9Gj2JZJw")]
    [Description(@"Pending reason being investigated.")]
    StatusReasonInvestigation = PendingFailingReasonCode.StatusReasonInvestigation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_FkKJuxqEEeG38P9Gj2JZJw")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical financial instruments have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as "PHCK".
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_FkKJvxqEEeG38P9Gj2JZJw")]
    [Description(@"Physical financial instruments have been received and are being checked for authenticity.")]
    PhysicalSecuritiesVerification = PendingFailingReasonCode.PhysicalSecuritiesVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as "BENO".
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_FkKJwxqEEeG38P9Gj2JZJw")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement = PendingFailingReasonCode.BeneficialOwnershipDisagreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as "BOTH".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_FkKJxxqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.")]
    BothInstructionsOnHold = PendingFailingReasonCode.BothInstructionsOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.
    /// Encoded/decoded by serializers as "CLHT".
    /// </summary>
    [EnumMember(Value = "CLHT")]
    [IsoId("_FkKJyxqEEeG38P9Gj2JZJw")]
    [Description(@"Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.")]
    ClearingHouseTrade = PendingFailingReasonCode.ClearingHouseTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as "DENO".
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_FkKJzxqEEeG38P9Gj2JZJw")]
    [Description(@"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.")]
    UnavailableDeliverableDenominatedQuantity = PendingFailingReasonCode.UnavailableDeliverableDenominatedQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.
    /// Encoded/decoded by serializers as "DISA".
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_FkKJ0xqEEeG38P9Gj2JZJw")]
    [Description(@"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.")]
    NaturalDisaster = PendingFailingReasonCode.NaturalDisaster, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty has returned or refuses the securities.
    /// Encoded/decoded by serializers as "DKNY".
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_FkKJ1xqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty has returned or refuses the securities.")]
    CounterpartyReturnedShares = PendingFailingReasonCode.CounterpartyReturnedShares, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.
    /// Encoded/decoded by serializers as "FROZ".
    /// </summary>
    [EnumMember(Value = "FROZ")]
    [IsoId("_FkKJ2xqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.")]
    SecuritiesFrozenAtCSD = PendingFailingReasonCode.SecuritiesFrozenAtCSD, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting settlement of a purchase to cover failing positions.
    /// Encoded/decoded by serializers as "LAAW".
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_FkKJ3xqEEeG38P9Gj2JZJw")]
    [Description(@"Awaiting settlement of a purchase to cover failing positions.")]
    AwaitingOtherTransaction = PendingFailingReasonCode.AwaitingOtherTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_FkKJ4xqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as "LIQU".
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_FkKJ5xqEEeG38P9Gj2JZJw")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity = PendingFailingReasonCode.InsufficientCentralBankLiquidity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty's instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as "PRCY".
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("_FkKJ6xqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold = PendingFailingReasonCode.CounterpartyInstructionOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.
    /// Encoded/decoded by serializers as "REGT".
    /// </summary>
    [EnumMember(Value = "REGT")]
    [IsoId("_FkKJ7xqEEeG38P9Gj2JZJw")]
    [Description(@"Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.")]
    CertificatesRejected = PendingFailingReasonCode.CertificatesRejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement system/method has been modified at central securities depository to allow settlement.
    /// Encoded/decoded by serializers as "SETS".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_FkKJ8xqEEeG38P9Gj2JZJw")]
    [Description(@"Settlement system/method has been modified at central securities depository to allow settlement.")]
    SettlementSystemMethodModified = PendingFailingReasonCode.SettlementSystemMethodModified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as "CERT".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_FkKJ9xqEEeG38P9Gj2JZJw")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonCode.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction was put on hold/frozen by the system.
    /// Encoded/decoded by serializers as "PRSY".
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("_FkKJ-xqEEeG38P9Gj2JZJw")]
    [Description(@"Transaction was put on hold/frozen by the system.")]
    SystemOnHold = PendingFailingReasonCode.SystemOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.
    /// Encoded/decoded by serializers as "CDLR".
    /// </summary>
    [EnumMember(Value = "CDLR")]
    [IsoId("_LxIBohqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.")]
    ConditionalDeliveryAwaitingRelease = PendingFailingReasonCode.ConditionalDeliveryAwaitingRelease, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central securities depository sets the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as "CSDH".
    /// </summary>
    [EnumMember(Value = "CSDH")]
    [IsoId("_PSblMhqEEeG38P9Gj2JZJw")]
    [Description(@"Central securities depository sets the instruction in a hold/frozen/preadvice mode.")]
    CSDHold = PendingFailingReasonCode.CSDHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
    /// Encoded/decoded by serializers as "CVAL".
    /// </summary>
    [EnumMember(Value = "CVAL")]
    [IsoId("_P-idQhqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.")]
    CSDValidation = PendingFailingReasonCode.CSDValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not all the instructions part of a pool have been received.
    /// Encoded/decoded by serializers as "INBC".
    /// </summary>
    [EnumMember(Value = "INBC")]
    [IsoId("_RHGn0hqEEeG38P9Gj2JZJw")]
    [Description(@"Not all the instructions part of a pool have been received.")]
    IncompleteNumberCount = PendingFailingReasonCode.IncompleteNumberCount, // same ordinal as derivation source for type conversions
    
}
