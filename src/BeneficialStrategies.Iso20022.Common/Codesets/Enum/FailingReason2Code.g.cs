﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FailingReason2Code.  ISO2002 ID# _FkKJERqEEeG38P9Gj2JZJw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "AwaitingMoney".
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_FkKJFxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are delivered, but still awaiting money from counterparty.")]
    AwaitingMoney,
    
    /// <summary>
    /// Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery).
    /// Encoded/decoded by serializers as "BuyInProcedure".
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_FkKJGxqEEeG38P9Gj2JZJw")]
    [Description(@"Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery).")]
    BuyInProcedure,
    
    /// <summary>
    /// Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late.
    /// Encoded/decoded by serializers as "CounterpartyTooLateForSettlement".
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_FkKJHxqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late.")]
    CounterpartyTooLateForSettlement,
    
    /// <summary>
    /// Instruction was received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_FkKJIxqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.
    /// Encoded/decoded by serializers as "CancellationConfirmationRequested".
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("_FkKJJxqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.")]
    CancellationConfirmationRequested,
    
    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.
    /// Encoded/decoded by serializers as "AwaitingSecurities".
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_FkKJKxqEEeG38P9Gj2JZJw")]
    [Description(@"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.")]
    AwaitingSecurities,
    
    /// <summary>
    /// Financial instruments are, for example, stolen, in dispute, under objection.
    /// Encoded/decoded by serializers as "UnderObjection".
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("_FkKJLxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are, for example, stolen, in dispute, under objection.")]
    UnderObjection,
    
    /// <summary>
    /// Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.
    /// Encoded/decoded by serializers as "AwaitingSecuritiesFromCounterparty".
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_FkKJMxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.")]
    AwaitingSecuritiesFromCounterparty,
    
    /// <summary>
    /// Settlement is physical. Financial instruments are being delivered.
    /// Encoded/decoded by serializers as "PhysicalDeliveryDelay".
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_FkKJNxqEEeG38P9Gj2JZJw")]
    [Description(@"Settlement is physical. Financial instruments are being delivered.")]
    PhysicalDeliveryDelay,
    
    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as "ConfirmationDiscrepency".
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_FkKJOxqEEeG38P9Gj2JZJw")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepency,
    
    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as "AwaitingDocumentsOrEndorsementsFromYou".
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_FkKJPxqEEeG38P9Gj2JZJw")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou,
    
    /// <summary>
    /// Covering money/financial instruments were received too late for completing settlement on a same day basis.
    /// Encoded/decoded by serializers as "MoneySecuritiesTooLateForSettlement".
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("_FkKJQxqEEeG38P9Gj2JZJw")]
    [Description(@"Covering money/financial instruments were received too late for completing settlement on a same day basis.")]
    MoneySecuritiesTooLateForSettlement,
    
    /// <summary>
    /// Awaiting documents or endorsements from counterparty.
    /// Encoded/decoded by serializers as "AwaitingDocumentsOrEndorsementsFromCounterparty".
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_FkKJRxqEEeG38P9Gj2JZJw")]
    [Description(@"Awaiting documents or endorsements from counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty,
    
    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as "AccountBlocked".
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_FkKJSxqEEeG38P9Gj2JZJw")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked,
    
    /// <summary>
    /// A chaser/enquiry has been sent.
    /// Encoded/decoded by serializers as "EnquirySent".
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_FkKJTxqEEeG38P9Gj2JZJw")]
    [Description(@"A chaser/enquiry has been sent.")]
    EnquirySent,
    
    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable.
    /// Encoded/decoded by serializers as "NewIssues".
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_FkKJUxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable.")]
    NewIssues,
    
    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as "CounterpartyInsufficientSecurities".
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_FkKJVxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.")]
    CounterpartyInsufficientSecurities,
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MultipleSettlementAmount".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_FkKJWxqEEeG38P9Gj2JZJw")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementAmount,
    
    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as "GlobalFormSecurities".
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_FkKJXxqEEeG38P9Gj2JZJw")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities,
    
    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as "YourInstructionOnHold".
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_FkKJYxqEEeG38P9Gj2JZJw")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold,
    
    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as "TradeSettlesInPartials".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_FkKJZxqEEeG38P9Gj2JZJw")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials,
    
    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as "NoForeignExchangeInstruction".
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_FkKJaxqEEeG38P9Gj2JZJw")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction,
    
    /// <summary>
    /// Insufficient money in counterparty's account.
    /// Encoded/decoded by serializers as "CounterpartyInsufficientMoney".
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_FkKJbxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney,
    
    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as "CollateralShortage".
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_FkKJcxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage,
    
    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as "SecuritiesPledgedAsCollateral".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_FkKJdxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral,
    
    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.
    /// Encoded/decoded by serializers as "RefusedDepositForIssueOfDepositaryReceipts".
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_FkKJexqEEeG38P9Gj2JZJw")]
    [Description(@"Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.")]
    RefusedDepositForIssueOfDepositaryReceipts,
    
    /// <summary>
    /// Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as "MaximumForeignLimitReached".
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_FkKJfxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.")]
    MaximumForeignLimitReached,
    
    /// <summary>
    /// Financial instruments require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as "IncomeAdjustementRequired".
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_FkKJgxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments require income adjustment, for example, dividend or interest.")]
    IncomeAdjustementRequired,
    
    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as "PendingLinkedInstruction".
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_FkKJhxqEEeG38P9Gj2JZJw")]
    [Description(@"Your instruction is pending settlement because the instruction linked to it is pending.")]
    PendingLinkedInstruction,
    
    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as "LackOfSecurities".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_FkKJixqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities,
    
    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as "SecuritiesLoanedOut".
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_FkKJjxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut,
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as "InsufficientMoney".
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_FkKJkxqEEeG38P9Gj2JZJw")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,
    
    /// <summary>
    /// Confirmation of settlement has not yet been received.
    /// Encoded/decoded by serializers as "ConfirmationNotReceived".
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_FkKJlxqEEeG38P9Gj2JZJw")]
    [Description(@"Confirmation of settlement has not yet been received.")]
    ConfirmationNotReceived,
    
    /// <summary>
    /// Delivery/receipt was refused because physical financial instruments are not in good order.
    /// Encoded/decoded by serializers as "NotInGoodOrder".
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_FkKJmxqEEeG38P9Gj2JZJw")]
    [Description(@"Delivery/receipt was refused because physical financial instruments are not in good order.")]
    NotInGoodOrder,
    
    /// <summary>
    /// Stamp duty information is missing.
    /// Encoded/decoded by serializers as "LackOfStampDutyInformation".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_FkKJnxqEEeG38P9Gj2JZJw")]
    [Description(@"Stamp duty information is missing.")]
    LackOfStampDutyInformation,
    
    /// <summary>
    /// Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight.
    /// Encoded/decoded by serializers as "ProcessingBatchDifference".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_FkKJoxqEEeG38P9Gj2JZJw")]
    [Description(@"Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight.")]
    ProcessingBatchDifference,
    
    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as "AwaitingNextSettlementCycle".
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_FkKJpxqEEeG38P9Gj2JZJw")]
    [Description(@"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.")]
    AwaitingNextSettlementCycle,
    
    /// <summary>
    /// Financial instruments are blocked due to, for example, a corporate action event, realignment.
    /// Encoded/decoded by serializers as "SecuritiesBlocked".
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_FkKJqxqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are blocked due to, for example, a corporate action event, realignment.")]
    SecuritiesBlocked,
    
    /// <summary>
    /// Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).
    /// Encoded/decoded by serializers as "CounterpartyInReceivership".
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_FkKJrxqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).")]
    CounterpartyInReceivership,
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MinimumSettlementAmount".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_FkKJsxqEEeG38P9Gj2JZJw")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementAmount,
    
    /// <summary>
    /// Pending reason being investigated.
    /// Encoded/decoded by serializers as "StatusReasonInvestigation".
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_FkKJtxqEEeG38P9Gj2JZJw")]
    [Description(@"Pending reason being investigated.")]
    StatusReasonInvestigation,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_FkKJuxqEEeG38P9Gj2JZJw")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Physical financial instruments have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as "PhysicalSecuritiesVerification".
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_FkKJvxqEEeG38P9Gj2JZJw")]
    [Description(@"Physical financial instruments have been received and are being checked for authenticity.")]
    PhysicalSecuritiesVerification,
    
    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as "BeneficialOwnershipDisagreement".
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_FkKJwxqEEeG38P9Gj2JZJw")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement,
    
    /// <summary>
    /// Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as "BothInstructionsOnHold".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_FkKJxxqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.")]
    BothInstructionsOnHold,
    
    /// <summary>
    /// Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.
    /// Encoded/decoded by serializers as "ClearingHouseTrade".
    /// </summary>
    [EnumMember(Value = "CLHT")]
    [IsoId("_FkKJyxqEEeG38P9Gj2JZJw")]
    [Description(@"Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.")]
    ClearingHouseTrade,
    
    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as "UnavailableDeliverableDenominatedQuantity".
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_FkKJzxqEEeG38P9Gj2JZJw")]
    [Description(@"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.")]
    UnavailableDeliverableDenominatedQuantity,
    
    /// <summary>
    /// Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.
    /// Encoded/decoded by serializers as "NaturalDisaster".
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_FkKJ0xqEEeG38P9Gj2JZJw")]
    [Description(@"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.")]
    NaturalDisaster,
    
    /// <summary>
    /// Counterparty has returned or refuses the securities.
    /// Encoded/decoded by serializers as "CounterpartyReturnedShares".
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_FkKJ1xqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty has returned or refuses the securities.")]
    CounterpartyReturnedShares,
    
    /// <summary>
    /// Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.
    /// Encoded/decoded by serializers as "SecuritiesFrozenAtCSD".
    /// </summary>
    [EnumMember(Value = "FROZ")]
    [IsoId("_FkKJ2xqEEeG38P9Gj2JZJw")]
    [Description(@"Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.")]
    SecuritiesFrozenAtCSD,
    
    /// <summary>
    /// Awaiting settlement of a purchase to cover failing positions.
    /// Encoded/decoded by serializers as "AwaitingOtherTransaction".
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_FkKJ3xqEEeG38P9Gj2JZJw")]
    [Description(@"Awaiting settlement of a purchase to cover failing positions.")]
    AwaitingOtherTransaction,
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_FkKJ4xqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as "InsufficientCentralBankLiquidity".
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_FkKJ5xqEEeG38P9Gj2JZJw")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity,
    
    /// <summary>
    /// Counterparty's instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as "CounterpartyInstructionOnHold".
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("_FkKJ6xqEEeG38P9Gj2JZJw")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold,
    
    /// <summary>
    /// Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.
    /// Encoded/decoded by serializers as "CertificatesRejected".
    /// </summary>
    [EnumMember(Value = "REGT")]
    [IsoId("_FkKJ7xqEEeG38P9Gj2JZJw")]
    [Description(@"Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.")]
    CertificatesRejected,
    
    /// <summary>
    /// Settlement system/method has been modified at central securities depository to allow settlement.
    /// Encoded/decoded by serializers as "SettlementSystemMethodModified".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_FkKJ8xqEEeG38P9Gj2JZJw")]
    [Description(@"Settlement system/method has been modified at central securities depository to allow settlement.")]
    SettlementSystemMethodModified,
    
    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as "WrongCertificatesNumbers".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_FkKJ9xqEEeG38P9Gj2JZJw")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers,
    
    /// <summary>
    /// Transaction was put on hold/frozen by the system.
    /// Encoded/decoded by serializers as "SystemOnHold".
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("_FkKJ-xqEEeG38P9Gj2JZJw")]
    [Description(@"Transaction was put on hold/frozen by the system.")]
    SystemOnHold,
    
    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.
    /// Encoded/decoded by serializers as "ConditionalDeliveryAwaitingRelease".
    /// </summary>
    [EnumMember(Value = "CDLR")]
    [IsoId("_LxIBohqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.")]
    ConditionalDeliveryAwaitingRelease,
    
    /// <summary>
    /// Central securities depository sets the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as "CSDHold".
    /// </summary>
    [EnumMember(Value = "CSDH")]
    [IsoId("_PSblMhqEEeG38P9Gj2JZJw")]
    [Description(@"Central securities depository sets the instruction in a hold/frozen/preadvice mode.")]
    CSDHold,
    
    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
    /// Encoded/decoded by serializers as "CSDValidation".
    /// </summary>
    [EnumMember(Value = "CVAL")]
    [IsoId("_P-idQhqEEeG38P9Gj2JZJw")]
    [Description(@"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.")]
    CSDValidation,
    
    /// <summary>
    /// Not all the instructions part of a pool have been received.
    /// Encoded/decoded by serializers as "IncompleteNumberCount".
    /// </summary>
    [EnumMember(Value = "INBC")]
    [IsoId("_RHGn0hqEEeG38P9Gj2JZJw")]
    [Description(@"Not all the instructions part of a pool have been received.")]
    IncompleteNumberCount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FailingReason2CodeMetadataExtensions
{
    private static readonly FailingReason2CodeDropdownSource _dropdownSource = new FailingReason2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFailingReason2CodeDropdownRow GetMetadata(this FailingReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


