﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason70Code.  ISO2002 ID# _11OY2ytUEeyhipY4f42fZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the securities financing instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11OY2ytUEeyhipY4f42fZQ")]
[Description(@"Specifies the reason why the securities financing instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason70Code
{
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_BwVtkStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_BwVtkytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_BwVtlStaEeyF-PUIGuhxvA")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_BwVtlytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_BwVtmStaEeyF-PUIGuhxvA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_BwVtmytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RejectionReasonV3Code.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DDEA".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_BwVtnStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RejectionReasonV3Code.DealPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as "DTRD".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_BwVtnytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate = RejectionReasonV3Code.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PLCE".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_BwVtoStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RejectionReasonV3Code.PlaceOfTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_BwVtoytaEeyF-PUIGuhxvA")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed = RejectionReasonV3Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "NCRR".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_BwVtpStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection = RejectionReasonV3Code.SettlementAmountCurrencyRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_BwVtpytaEeyF-PUIGuhxvA")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RejectionReasonV3Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "REFE".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_BwVtqStaEeyF-PUIGuhxvA")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection = RejectionReasonV3Code.ReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_BwVtqytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection = RejectionReasonV3Code.SettlementAmountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MINO".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_BwVtrStaEeyF-PUIGuhxvA")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity = RejectionReasonV3Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as "BATC".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_BwVtrytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatchRejection = RejectionReasonV3Code.ProcessingBatchRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MUNO".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_BwVtsStaEeyF-PUIGuhxvA")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity = RejectionReasonV3Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TXST".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_BwVtsytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection = RejectionReasonV3Code.TaxStatusRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SETS".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_BwVttStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection = RejectionReasonV3Code.SettlementSystemMethodRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "IIND".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_BwVttytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection = RejectionReasonV3Code.CommonReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CAEV".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_BwVtuStaEeyF-PUIGuhxvA")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection = RejectionReasonV3Code.CorporateActionRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as "CASY".
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_BwVtuytaEeyF-PUIGuhxvA")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem = RejectionReasonV3Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_BwVtvStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV3Code.SettlementDateRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SETR".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_BwVtvytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection = RejectionReasonV3Code.SettlementTransactionRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as "SDUT".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_BwVtwStaEeyF-PUIGuhxvA")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty = RejectionReasonV3Code.LackOfStampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as "CADE".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_BwVtwytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RejectionReasonV3Code.TransactionCallDelay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as "FORF".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_BwVtxStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RejectionReasonV3Code.ForfeitAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_BwVtxytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection = RejectionReasonV3Code.ClosingDateTimeRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as "VASU".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_BwVtyStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection = RejectionReasonV3Code.VariableRateSupportRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as "REPA".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_BwVtyytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RejectionReasonV3Code.TerminationTransactionAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_BwVtzStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RejectionReasonV3Code.RepurchaseRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as "REPP".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_BwVtzytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RejectionReasonV3Code.PremiumAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as "RERT".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_BwVt0StaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RejectionReasonV3Code.RepurchaseRateType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as "RSPR".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_BwVt0ytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RejectionReasonV3Code.SpreadRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as "ICAG".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_BwVt1StaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1 = RejectionReasonV3Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as "INPS".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_BwVt1ytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping = RejectionReasonV3Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as "ICUS".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_BwVt2StaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2 = RejectionReasonV3Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_BwVt2ytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository = RejectionReasonV3Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_BwVt3StaEeyF-PUIGuhxvA")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as "IEXE".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_BwVt3ytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3 = RejectionReasonV3Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_BwVt4StaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.")]
    InvalidInvestorParty = RejectionReasonV3Code.InvalidInvestorParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.
    /// Encoded/decoded by serializers as "PLIS".
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("_BwVt4ytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.")]
    PlaceOfListing = RejectionReasonV3Code.PlaceOfListing, // same ordinal as derivation source for type conversions
    
}
