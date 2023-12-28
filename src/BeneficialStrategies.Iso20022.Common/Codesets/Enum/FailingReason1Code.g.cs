﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FailingReason1Code.  ISO2002 ID# _am7gdtp-Ed-ak6NoX_4Aeg_1744847021.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_am7gdtp-Ed-ak6NoX_4Aeg_1744847021")]
[Description(@"Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum FailingReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AwaitingMoney".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_am7gd9p-Ed-ak6NoX_4Aeg_-904852840")]
    [Description(@"??")]
    AwaitingMoney,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BuyInProcedure".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_am7geNp-Ed-ak6NoX_4Aeg_747774668")]
    [Description(@"??")]
    BuyInProcedure,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CounterpartyTooLateForSettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRcNp-Ed-ak6NoX_4Aeg_455816930")]
    [Description(@"??")]
    CounterpartyTooLateForSettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRcdp-Ed-ak6NoX_4Aeg_633935602")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancellationConfirmationRequested".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRctp-Ed-ak6NoX_4Aeg_-1901925193")]
    [Description(@"??")]
    CancellationConfirmationRequested,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AwaitingSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRc9p-Ed-ak6NoX_4Aeg_-249297685")]
    [Description(@"??")]
    AwaitingSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnderObjection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRdNp-Ed-ak6NoX_4Aeg_-541255423")]
    [Description(@"??")]
    UnderObjection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AwaitingSecuritiesFromCounterparty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRddp-Ed-ak6NoX_4Aeg_-363136751")]
    [Description(@"??")]
    AwaitingSecuritiesFromCounterparty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhysicalDeliveryDelay".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRdtp-Ed-ak6NoX_4Aeg_1395969750")]
    [Description(@"??")]
    PhysicalDeliveryDelay,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConfirmationDiscrepency".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRd9p-Ed-ak6NoX_4Aeg_-1246370038")]
    [Description(@"??")]
    ConfirmationDiscrepency,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AwaitingDocumentsOrEndorsementsFromYou".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFReNp-Ed-ak6NoX_4Aeg_-1538327776")]
    [Description(@"??")]
    AwaitingDocumentsOrEndorsementsFromYou,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MoneySecuritiesTooLateForSettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRedp-Ed-ak6NoX_4Aeg_-1360209104")]
    [Description(@"??")]
    MoneySecuritiesTooLateForSettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AwaitingDocumentsOrEndorsementsFromCounterparty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anFRetp-Ed-ak6NoX_4Aeg_398897397")]
    [Description(@"??")]
    AwaitingDocumentsOrEndorsementsFromCounterparty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountBlocked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObYNp-Ed-ak6NoX_4Aeg_2051524905")]
    [Description(@"??")]
    AccountBlocked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EnquirySent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObYdp-Ed-ak6NoX_4Aeg_1759567167")]
    [Description(@"??")]
    EnquirySent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NewIssues".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObYtp-Ed-ak6NoX_4Aeg_1937685839")]
    [Description(@"??")]
    NewIssues,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CounterpartyInsufficientSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObY9p-Ed-ak6NoX_4Aeg_-598174956")]
    [Description(@"??")]
    CounterpartyInsufficientSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultipleSettlementAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObZNp-Ed-ak6NoX_4Aeg_1054452552")]
    [Description(@"??")]
    MultipleSettlementAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GlobalFormSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObZdp-Ed-ak6NoX_4Aeg_762494814")]
    [Description(@"??")]
    GlobalFormSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "YourInstructionOnHold".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObZtp-Ed-ak6NoX_4Aeg_940613486")]
    [Description(@"??")]
    YourInstructionOnHold,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TradeSettlesInPartials".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObZ9p-Ed-ak6NoX_4Aeg_57380199")]
    [Description(@"??")]
    TradeSettlesInPartials,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoForeignExchangeInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObaNp-Ed-ak6NoX_4Aeg_-234577539")]
    [Description(@"??")]
    NoForeignExchangeInstruction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CounterpartyInsufficientMoney".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anObadp-Ed-ak6NoX_4Aeg_-56458867")]
    [Description(@"??")]
    CounterpartyInsufficientMoney,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CollateralShortage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMYNp-Ed-ak6NoX_4Aeg_1702647634")]
    [Description(@"??")]
    CollateralShortage,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesPledgedAsCollateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMYdp-Ed-ak6NoX_4Aeg_-939692154")]
    [Description(@"??")]
    SecuritiesPledgedAsCollateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RefusedDepositForIssueOfDepositaryReceipts".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMYtp-Ed-ak6NoX_4Aeg_-1231649892")]
    [Description(@"??")]
    RefusedDepositForIssueOfDepositaryReceipts,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MaximumForeignLimitReached".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMY9p-Ed-ak6NoX_4Aeg_-1053531220")]
    [Description(@"??")]
    MaximumForeignLimitReached,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncomeAdjustementRequired".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMZNp-Ed-ak6NoX_4Aeg_705575281")]
    [Description(@"??")]
    IncomeAdjustementRequired,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingLinkedInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMZdp-Ed-ak6NoX_4Aeg_-1936764507")]
    [Description(@"??")]
    PendingLinkedInstruction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMZtp-Ed-ak6NoX_4Aeg_2066245051")]
    [Description(@"??")]
    LackOfSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesLoanedOut".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMZ9p-Ed-ak6NoX_4Aeg_-2050603573")]
    [Description(@"??")]
    SecuritiesLoanedOut,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsufficientMoney".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMaNp-Ed-ak6NoX_4Aeg_-291497072")]
    [Description(@"??")]
    InsufficientMoney,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConfirmationNotReceived".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anYMadp-Ed-ak6NoX_4Aeg_1361130436")]
    [Description(@"??")]
    ConfirmationNotReceived,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotInGoodOrder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9YNp-Ed-ak6NoX_4Aeg_1069172698")]
    [Description(@"??")]
    NotInGoodOrder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfStampDutyInformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9Ydp-Ed-ak6NoX_4Aeg_1247291370")]
    [Description(@"??")]
    LackOfStampDutyInformation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProcessingBatchDifference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9Ytp-Ed-ak6NoX_4Aeg_-1288569425")]
    [Description(@"??")]
    ProcessingBatchDifference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AwaitingNextSettlementCycle".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9Y9p-Ed-ak6NoX_4Aeg_-1323408739")]
    [Description(@"??")]
    AwaitingNextSettlementCycle,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesBlocked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9ZNp-Ed-ak6NoX_4Aeg_-1615366477")]
    [Description(@"??")]
    SecuritiesBlocked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CounterpartyInReceivership".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9Zdp-Ed-ak6NoX_4Aeg_-1437247805")]
    [Description(@"??")]
    CounterpartyInReceivership,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MinimumSettlementAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9Ztp-Ed-ak6NoX_4Aeg_321858696")]
    [Description(@"??")]
    MinimumSettlementAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StatusReasonInvestigation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9Z9p-Ed-ak6NoX_4Aeg_1974486204")]
    [Description(@"??")]
    StatusReasonInvestigation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9aNp-Ed-ak6NoX_4Aeg_1682528466")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhysicalSecuritiesVerification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9adp-Ed-ak6NoX_4Aeg_1860647138")]
    [Description(@"??")]
    PhysicalSecuritiesVerification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BeneficialOwnershipDisagreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anh9atp-Ed-ak6NoX_4Aeg_-675213657")]
    [Description(@"??")]
    BeneficialOwnershipDisagreement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BothInstructionsOnHold".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHUNp-Ed-ak6NoX_4Aeg_977413851")]
    [Description(@"??")]
    BothInstructionsOnHold,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClearingHouseTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHUdp-Ed-ak6NoX_4Aeg_685456113")]
    [Description(@"??")]
    ClearingHouseTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnavailableDeliverableDenominatedQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHUtp-Ed-ak6NoX_4Aeg_863574785")]
    [Description(@"??")]
    UnavailableDeliverableDenominatedQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NaturalDisaster".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHU9p-Ed-ak6NoX_4Aeg_-1672286010")]
    [Description(@"??")]
    NaturalDisaster,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CounterpartyReturnedShares".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHVNp-Ed-ak6NoX_4Aeg_-19658502")]
    [Description(@"??")]
    CounterpartyReturnedShares,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesFrozenAtCSD".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHVdp-Ed-ak6NoX_4Aeg_-311616240")]
    [Description(@"??")]
    SecuritiesFrozenAtCSD,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AwaitingOtherTransaction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHVtp-Ed-ak6NoX_4Aeg_-133497568")]
    [Description(@"??")]
    AwaitingOtherTransaction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHV9p-Ed-ak6NoX_4Aeg_1625608933")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsufficientCentralBankLiquidity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHWNp-Ed-ak6NoX_4Aeg_-1016730855")]
    [Description(@"??")]
    InsufficientCentralBankLiquidity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CounterpartyInstructionOnHold".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_anrHWdp-Ed-ak6NoX_4Aeg_-1308688593")]
    [Description(@"??")]
    CounterpartyInstructionOnHold,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CertificatesRejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_an04UNp-Ed-ak6NoX_4Aeg_-1130569921")]
    [Description(@"??")]
    CertificatesRejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementSystemMethodModified".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_an04Udp-Ed-ak6NoX_4Aeg_628536580")]
    [Description(@"??")]
    SettlementSystemMethodModified,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WrongCertificatesNumbers".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_an04Utp-Ed-ak6NoX_4Aeg_-2013803208")]
    [Description(@"??")]
    WrongCertificatesNumbers,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SystemOnHold".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_an04U9p-Ed-ak6NoX_4Aeg_-1746851229")]
    [Description(@"??")]
    SystemOnHold,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FailingReason1CodeMetadataExtensions
{
    private static readonly FailingReason1CodeDropdownSource _dropdownSource = new FailingReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFailingReason1CodeDropdownRow GetMetadata(this FailingReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

