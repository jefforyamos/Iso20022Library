﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason31Code.  ISO2002 ID# _2TSkwQrlEeG2Qoz6TTiHZw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2TSkwQrlEeG2Qoz6TTiHZw")]
[Description(@"Specifies the reason why the settlement instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason31Code
{
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_2TcVxQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV2Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_2TcVyQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV2Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_2TcVzQrlEeG2Qoz6TTiHZw")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_2TcV0QrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV2Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_2TcV1QrlEeG2Qoz6TTiHZw")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_2TcV2QrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RejectionReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DDEA".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_2TcV3QrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RejectionReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as "DTRD".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_2TcV4QrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate = RejectionReasonV2Code.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PLCE".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_2TcV5QrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RejectionReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_2TcV6QrlEeG2Qoz6TTiHZw")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed = RejectionReasonV2Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "NCRR".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_2TcV7QrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection = RejectionReasonV2Code.SettlementAmountCurrencyRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_2TcV8QrlEeG2Qoz6TTiHZw")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RejectionReasonV2Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "REFE".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_2TcV9QrlEeG2Qoz6TTiHZw")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_2TcV-QrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection = RejectionReasonV2Code.SettlementAmountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MINO".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_2TcV_QrlEeG2Qoz6TTiHZw")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity = RejectionReasonV2Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as "BATC".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_2TcWAQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatchRejection = RejectionReasonV2Code.ProcessingBatchRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MUNO".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_2TcWBQrlEeG2Qoz6TTiHZw")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity = RejectionReasonV2Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TXST".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_2TcWCQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection = RejectionReasonV2Code.TaxStatusRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SETS".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_2TcWDQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection = RejectionReasonV2Code.SettlementSystemMethodRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "IIND".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_2TcWEQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection = RejectionReasonV2Code.CommonReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CAEV".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_2TcWFQrlEeG2Qoz6TTiHZw")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection = RejectionReasonV2Code.CorporateActionRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as "CASY".
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_2TcWGQrlEeG2Qoz6TTiHZw")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem = RejectionReasonV2Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_2TcWHQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV2Code.SettlementDateRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SETR".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_2TcWIQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection = RejectionReasonV2Code.SettlementTransactionRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as "SDUT".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_2TcWJQrlEeG2Qoz6TTiHZw")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty = RejectionReasonV2Code.LackOfStampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as "INPS".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_2TcWKQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping = RejectionReasonV2Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_2TcWLQrlEeG2Qoz6TTiHZw")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as "ICUS".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_2TcWMQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2 = RejectionReasonV2Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as "ICAG".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_2TcWNQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1 = RejectionReasonV2Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_2TcWOQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository = RejectionReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as "IEXE".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_2TcWPQrlEeG2Qoz6TTiHZw")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3 = RejectionReasonV2Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as "INVL".
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_45vCkgrlEeG2Qoz6TTiHZw")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink = RejectionReasonV2Code.InvalidLink, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction aims at using an invalid balance.
    /// Encoded/decoded by serializers as "INVB".
    /// </summary>
    [EnumMember(Value = "INVB")]
    [IsoId("_9Ior8grlEeG2Qoz6TTiHZw")]
    [Description(@"Instruction aims at using an invalid balance.")]
    InvalidBalance = RejectionReasonV2Code.InvalidBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or unrecognized lot number.
    /// Encoded/decoded by serializers as "INVN".
    /// </summary>
    [EnumMember(Value = "INVN")]
    [IsoId("_92-YqgrlEeG2Qoz6TTiHZw")]
    [Description(@"Invalid or unrecognized lot number.")]
    InvalidLotNumber = RejectionReasonV2Code.InvalidLotNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account servicer validation rule rejection.
    /// Encoded/decoded by serializers as "VALR".
    /// </summary>
    [EnumMember(Value = "VALR")]
    [IsoId("_-j-okgrlEeG2Qoz6TTiHZw")]
    [Description(@"Account servicer validation rule rejection.")]
    InvalidRule = RejectionReasonV2Code.InvalidRule, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason31CodeMetadataExtensions
{
    private static readonly RejectionReason31CodeDropdownSource _dropdownSource = new RejectionReason31CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason31CodeDropdownRow GetMetadata(this RejectionReason31Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


