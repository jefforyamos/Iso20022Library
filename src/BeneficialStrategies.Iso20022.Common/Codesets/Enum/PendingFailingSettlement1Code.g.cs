﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingFailingSettlement1Code.  ISO2002 ID# _zcQUlA93EeGeV5vP7Mvdig_816274429.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zcQUlA93EeGeV5vP7Mvdig_816274429")]
[Description(@"Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.")]
[DerivedFrom(typeof(PendingFailingSettlementCode))]
public enum PendingFailingSettlement1Code
{
    /// <summary>
    /// Securities have been delivered, but the money is still expected from the counterparty.
    /// Encoded/decoded by serializers as "AwaitingMoney".
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_zcQUlQ93EeGeV5vP7Mvdig_-1625508054")]
    [Description(@"Securities have been delivered, but the money is still expected from the counterparty.")]
    AwaitingMoney,
    
    /// <summary>
    /// Securities have not yet been received from the counterparty. If the settlement instruction was a received against payment, the cash has been delivered.
    /// Encoded/decoded by serializers as "AwaitingSecuritiesFromCounterparty".
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_zcQUlg93EeGeV5vP7Mvdig_-475206144")]
    [Description(@"Securities have not yet been received from the counterparty. If the settlement instruction was a received against payment, the cash has been delivered.")]
    AwaitingSecuritiesFromCounterparty,
    
    /// <summary>
    /// Awaiting settlement of a linked 'buy'.
    /// Encoded/decoded by serializers as "AwaitingOtherTransaction".
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_zcaFkA93EeGeV5vP7Mvdig_-486304921")]
    [Description(@"Awaiting settlement of a linked 'buy'.")]
    AwaitingOtherTransaction,
    
    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as "AwaitingDocumentsOrEndorsementsFromYou".
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_zcaFkQ93EeGeV5vP7Mvdig_-600143987")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou,
    
    /// <summary>
    /// Counterparty's instruction was too late for settlement, (that is, received too late, matching, or settlement problems were solved too late).
    /// Encoded/decoded by serializers as "CounterpartyTooLateForSettlement".
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_zcaFkg93EeGeV5vP7Mvdig_274460232")]
    [Description(@"Counterparty's instruction was too late for settlement, (that is, received too late, matching, or settlement problems were solved too late).")]
    CounterpartyTooLateForSettlement,
    
    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as "WrongCertificateNumbers".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_zcaFkw93EeGeV5vP7Mvdig_1798705517")]
    [Description(@"Certificate number error.")]
    WrongCertificateNumbers,
    
    /// <summary>
    /// Securities quantity is lower than the minimum existing settlement quantity for the instructed financial instrument.
    /// Encoded/decoded by serializers as "MinimumSettlementAmount".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_zcaFlA93EeGeV5vP7Mvdig_-1735496626")]
    [Description(@"Securities quantity is lower than the minimum existing settlement quantity for the instructed financial instrument.")]
    MinimumSettlementAmount,
    
    /// <summary>
    /// Settlement is physical, and there is a delay in the delivery of the securities.
    /// Encoded/decoded by serializers as "PhysicalDeliveryDelay".
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_zcaFlQ93EeGeV5vP7Mvdig_-684363554")]
    [Description(@"Settlement is physical, and there is a delay in the delivery of the securities.")]
    PhysicalDeliveryDelay,
    
    /// <summary>
    /// Securities are blocked, for example, because of a corporate action event or re-alignment.
    /// Encoded/decoded by serializers as "SecuritiesBlocked".
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_zcaFlg93EeGeV5vP7Mvdig_1766734753")]
    [Description(@"Securities are blocked, for example, because of a corporate action event or re-alignment.")]
    SecuritiesBlocked,
    
    /// <summary>
    /// Counterparty has returned, refused, or does not recognize the securities.
    /// Encoded/decoded by serializers as "CounterpartyReturnedSecurities".
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_zcjPgA93EeGeV5vP7Mvdig_1652895687")]
    [Description(@"Counterparty has returned, refused, or does not recognize the securities.")]
    CounterpartyReturnedSecurities,
    
    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as "ConfirmationDiscrepancy".
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_zcjPgQ93EeGeV5vP7Mvdig_-655709609")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepancy,
    
    /// <summary>
    /// Disagreement over beneficial ownership.
    /// Encoded/decoded by serializers as "BeneficialOwnershipDisagreement".
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_zcjPgg93EeGeV5vP7Mvdig_-537838624")]
    [Description(@"Disagreement over beneficial ownership.")]
    BeneficialOwnershipDisagreement,
    
    /// <summary>
    /// Insufficient deliverable securities in your account.
    /// Encoded/decoded by serializers as "LackOfSecurities".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_zcjPgw93EeGeV5vP7Mvdig_1629300829")]
    [Description(@"Insufficient deliverable securities in your account.")]
    LackOfSecurities,
    
    /// <summary>
    /// Settlement instruction was too late for settlement, that is, received too late, matching, or settlement problems were solved too late.
    /// Encoded/decoded by serializers as "TooLateForSettlement".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_zcjPhA93EeGeV5vP7Mvdig_-1587646129")]
    [Description(@"Settlement instruction was too late for settlement, that is, received too late, matching, or settlement problems were solved too late.")]
    TooLateForSettlement,
    
    /// <summary>
    /// Transaction suspended. Because the suspension period is finished, the cancellation or confirmation of instructions is required.
    /// Encoded/decoded by serializers as "CancellationConfirmationRequest".
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("_zctAgA93EeGeV5vP7Mvdig_-1133558860")]
    [Description(@"Transaction suspended. Because the suspension period is finished, the cancellation or confirmation of instructions is required.")]
    CancellationConfirmationRequest,
    
    /// <summary>
    /// Payment for a buy of securities was received after the cut-off time for completing the settlement on a same day basis.
    /// Encoded/decoded by serializers as "MoneyTooLateForSettlement".
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("_zctAgQ93EeGeV5vP7Mvdig_-1247397926")]
    [Description(@"Payment for a buy of securities was received after the cut-off time for completing the settlement on a same day basis.")]
    MoneyTooLateForSettlement,
    
    /// <summary>
    /// Securities are stolen, in dispute, and under objection.
    /// Encoded/decoded by serializers as "UnderObjection".
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("_zctAgg93EeGeV5vP7Mvdig_-547611834")]
    [Description(@"Securities are stolen, in dispute, and under objection.")]
    UnderObjection,
    
    /// <summary>
    /// Awaiting documents or endorsements from the counterparty.
    /// Encoded/decoded by serializers as "AwaitingDocumentsOrEndorsementsFromCounterparty".
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_zctAgw93EeGeV5vP7Mvdig_-160034632")]
    [Description(@"Awaiting documents or endorsements from the counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty,
    
    /// <summary>
    /// Account is blocked, so no instruction can settle.
    /// Encoded/decoded by serializers as "AccountBlocked".
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_zctAhA93EeGeV5vP7Mvdig_-171133409")]
    [Description(@"Account is blocked, so no instruction can settle.")]
    AccountBlocked,
    
    /// <summary>
    /// Enquiry/chaser sent to the agent or depository.
    /// Encoded/decoded by serializers as "EnquirySent".
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_zctAhQ93EeGeV5vP7Mvdig_589631744")]
    [Description(@"Enquiry/chaser sent to the agent or depository.")]
    EnquirySent,
    
    /// <summary>
    /// Securities are new issues, and not yet available/tradeable.
    /// Encoded/decoded by serializers as "NewIssues".
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_zctAhg93EeGeV5vP7Mvdig_278240485")]
    [Description(@"Securities are new issues, and not yet available/tradeable.")]
    NewIssues,
    
    /// <summary>
    /// Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities.
    /// Encoded/decoded by serializers as "CounterpartyInsufficientSecurities".
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_zc2xgA93EeGeV5vP7Mvdig_267141708")]
    [Description(@"Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities.")]
    CounterpartyInsufficientSecurities,
    
    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as "TradeSettlesInPartials".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_zc2xgQ93EeGeV5vP7Mvdig_153302642")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials,
    
    /// <summary>
    /// Insufficient money in counterparty's account.
    /// Encoded/decoded by serializers as "CounterpartyInsufficientMoney".
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_zc2xgg93EeGeV5vP7Mvdig_592259215")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney,
    
    /// <summary>
    /// Securities are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as "SecuritiesPledgedAsCollateral".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_zc2xgw93EeGeV5vP7Mvdig_1307176003")]
    [Description(@"Securities are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral,
    
    /// <summary>
    /// Deposit of shares for the issuance of a depositary receipt has been refused. The allotment for depositary receipts granted by the issuer would be exceeded by the transaction.
    /// Encoded/decoded by serializers as "RefusedDepositForIssueOfDepositaryReceipts".
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_zc2xhA93EeGeV5vP7Mvdig_888642413")]
    [Description(@"Deposit of shares for the issuance of a depositary receipt has been refused. The allotment for depositary receipts granted by the issuer would be exceeded by the transaction.")]
    RefusedDepositForIssueOfDepositaryReceipts,
    
    /// <summary>
    /// Insufficient deliverable securities in your account, as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as "MaximumForeignLimitReached".
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_zc2xhQ93EeGeV5vP7Mvdig_253610567")]
    [Description(@"Insufficient deliverable securities in your account, as maximum foreign limit has been reached.")]
    MaximumForeignLimitReached,
    
    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as "NoForeignExchangeInstruction".
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_zc2xhg93EeGeV5vP7Mvdig_1331630905")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction,
    
    /// <summary>
    /// Securities require income adjustment, that is, dividend or interest.
    /// Encoded/decoded by serializers as "IncomeAdjustementRequired".
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_zc_7cA93EeGeV5vP7Mvdig_1217791839")]
    [Description(@"Securities require income adjustment, that is, dividend or interest.")]
    IncomeAdjustementRequired,
    
    /// <summary>
    /// Linked instruction is pending/failing.
    /// Encoded/decoded by serializers as "PendingLinkedInstruction".
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_zc_7cQ93EeGeV5vP7Mvdig_-1132413222")]
    [Description(@"Linked instruction is pending/failing.")]
    PendingLinkedInstruction,
    
    /// <summary>
    /// A buy-in procedure has started on the market, on your behalf, if your instruction is a receipt, or on behalf of the counterparty if the instruction is a delivery.
    /// Encoded/decoded by serializers as "BuyInProcedure".
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_zc_7cg93EeGeV5vP7Mvdig_-678325953")]
    [Description(@"A buy-in procedure has started on the market, on your behalf, if your instruction is a receipt, or on behalf of the counterparty if the instruction is a delivery.")]
    BuyInProcedure,
    
    /// <summary>
    /// Awaiting securities from a corporate action issue or other procedure(s), for example, conversion, dematerialisation, exchange, registration, stamping, and splitting.
    /// Encoded/decoded by serializers as "AwaitingSecurities".
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_zc_7cw93EeGeV5vP7Mvdig_-92378927")]
    [Description(@"Awaiting securities from a corporate action issue or other procedure(s), for example, conversion, dematerialisation, exchange, registration, stamping, and splitting.")]
    AwaitingSecurities,
    
    /// <summary>
    /// Insufficient deliverable securities in your account as securities are loaned out.
    /// Encoded/decoded by serializers as "SecuritiesLoanedOut".
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_zc_7dA93EeGeV5vP7Mvdig_1688133855")]
    [Description(@"Insufficient deliverable securities in your account as securities are loaned out.")]
    SecuritiesLoanedOut,
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as "InsufficientMoney".
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_zc_7dQ93EeGeV5vP7Mvdig_-710296717")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,
    
    /// <summary>
    /// Settlement confirmation has not yet been received.
    /// Encoded/decoded by serializers as "ConfirmationNotReceived".
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_zc_7dg93EeGeV5vP7Mvdig_-721395494")]
    [Description(@"Settlement confirmation has not yet been received.")]
    ConfirmationNotReceived,
    
    /// <summary>
    /// Not enough collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as "CollateralShortage".
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_zdJscA93EeGeV5vP7Mvdig_-835234560")]
    [Description(@"Not enough collateral in your account to execute the instruction.")]
    CollateralShortage,
    
    /// <summary>
    /// Delivery/receipt is refused because the physical securities are not in good order.
    /// Encoded/decoded by serializers as "NotInGoodOrder".
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_zdJscQ93EeGeV5vP7Mvdig_1574713721")]
    [Description(@"Delivery/receipt is refused because the physical securities are not in good order.")]
    NotInGoodOrder,
    
    /// <summary>
    /// Instruction is failing since stamp duty information is missing.
    /// Encoded/decoded by serializers as "LackOfStampDutyInformation".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_zdJscg93EeGeV5vP7Mvdig_-2109851647")]
    [Description(@"Instruction is failing since stamp duty information is missing.")]
    LackOfStampDutyInformation,
    
    /// <summary>
    /// Your instruction is confirmed in the local market, but is ready for settlement at the next settlement cycle.
    /// Encoded/decoded by serializers as "AwaitingNextSettlementCycle".
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_zdJscw93EeGeV5vP7Mvdig_-2120950424")]
    [Description(@"Your instruction is confirmed in the local market, but is ready for settlement at the next settlement cycle.")]
    AwaitingNextSettlementCycle,
    
    /// <summary>
    /// Processing batch differs in the counterparty's instruction, for example, day time/real time vs overnight.
    /// Encoded/decoded by serializers as "ProcessingBatchDifference".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_zdJsdA93EeGeV5vP7Mvdig_2060177806")]
    [Description(@"Processing batch differs in the counterparty's instruction, for example, day time/real time vs overnight.")]
    ProcessingBatchDifference,
    
    /// <summary>
    /// Guaranteed delivery indicator differs in the counterparty's instruction.
    /// Encoded/decoded by serializers as "GuaranteedDeliveryIndicatorDifference".
    /// </summary>
    [EnumMember(Value = "GUAD")]
    [IsoId("_zdJsdQ93EeGeV5vP7Mvdig_-131996815")]
    [Description(@"Guaranteed delivery indicator differs in the counterparty's instruction.")]
    GuaranteedDeliveryIndicatorDifference,
    
    /// <summary>
    /// Instruction is a preadvice, that is, matching only.
    /// Encoded/decoded by serializers as "PreadviceInstructed".
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_zdJsdg93EeGeV5vP7Mvdig_-1824177012")]
    [Description(@"Instruction is a preadvice, that is, matching only.")]
    PreadviceInstructed,
    
    /// <summary>
    /// Securities are in global form.
    /// Encoded/decoded by serializers as "GlobalFormSecurities".
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_zdTdcA93EeGeV5vP7Mvdig_-2141953673")]
    [Description(@"Securities are in global form.")]
    GlobalFormSecurities,
    
    /// <summary>
    /// Counterparty is in receivership, that is, a form of bankruptcy.
    /// Encoded/decoded by serializers as "CounterpartyInReceivership".
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_zdTdcQ93EeGeV5vP7Mvdig_-1381188520")]
    [Description(@"Counterparty is in receivership, that is, a form of bankruptcy.")]
    CounterpartyInReceivership,
    
    /// <summary>
    /// Amount is not a multiple of an existing settlement amount lot for the instructed financial instrument.
    /// Encoded/decoded by serializers as "MultipleSettlementAmount".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_zdTdcg93EeGeV5vP7Mvdig_-795241494")]
    [Description(@"Amount is not a multiple of an existing settlement amount lot for the instructed financial instrument.")]
    MultipleSettlementAmount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingFailingSettlement1CodeMetadataExtensions
{
    private static readonly PendingFailingSettlement1CodeDropdownSource _dropdownSource = new PendingFailingSettlement1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingFailingSettlement1CodeDropdownRow GetMetadata(this PendingFailingSettlement1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


