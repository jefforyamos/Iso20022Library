﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnmatchedReason2Code.  ISO2002 ID# _Y5aOudp-Ed-ak6NoX_4Aeg_-1023353405.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y5aOudp-Ed-ak6NoX_4Aeg_-1023353405")]
[Description(@"Specifies the reason the transaction, transfer or settlement instruction is unmatched.")]
[DerivedFrom(typeof(UnmatchedReasonCode))]
public enum UnmatchedReason2Code
{
    /// <summary>
    /// A matching instruction from your counterparty could not be found.
    /// Encoded/decoded by serializers as "CMIS".
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_Y5jYoNp-Ed-ak6NoX_4Aeg_515435037")]
    [Description(@"A matching instruction from your counterparty could not be found.")]
    NoMatch = UnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement date/time does not match.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Y5jYodp-Ed-ak6NoX_4Aeg_-2020425758")]
    [Description(@"Settlement date/time does not match.")]
    SettlementDate = UnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.
    /// Encoded/decoded by serializers as "DELN".
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_Y5jYotp-Ed-ak6NoX_4Aeg_-367798250")]
    [Description(@"Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.")]
    TransactionDirection = UnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Depository does not match.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Y5jYo9p-Ed-ak6NoX_4Aeg_-481637316")]
    [Description(@"Depository does not match.")]
    ReceivingDeliveringDepository = UnmatchedReasonCode.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement amount does not match.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_Y5jYpNp-Ed-ak6NoX_4Aeg_1277469185")]
    [Description(@"Settlement amount does not match.")]
    SettlementAmount = UnmatchedReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deal price does not match.
    /// Encoded/decoded by serializers as "DDEA".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_Y5jYpdp-Ed-ak6NoX_4Aeg_-1364870603")]
    [Description(@"Deal price does not match.")]
    DealPrice = UnmatchedReasonCode.DealPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Y5jYptp-Ed-ak6NoX_4Aeg_-1656828341")]
    [Description(@"Quantity of financial instruments does not match.")]
    FinancialInstrumentQuantity = UnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Y5jYp9p-Ed-ak6NoX_4Aeg_-1478709669")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = UnmatchedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).
    /// Encoded/decoded by serializers as "SETR".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_Y5jYqNp-Ed-ak6NoX_4Aeg_280396832")]
    [Description(@"Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).")]
    SettlementTransaction = UnmatchedReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).
    /// Encoded/decoded by serializers as "SETS".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_Y5jYqdp-Ed-ak6NoX_4Aeg_1933024340")]
    [Description(@"Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).")]
    SettlementSystemMethod = UnmatchedReasonCode.SettlementSystemMethod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Y5tJoNp-Ed-ak6NoX_4Aeg_1641066602")]
    [Description(@"Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.")]
    FinancialInstrument = UnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty has been contacted or contacted us, and does not recognise the transaction.
    /// Encoded/decoded by serializers as "DTRA".
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_Y5tJodp-Ed-ak6NoX_4Aeg_1819185274")]
    [Description(@"Counterparty has been contacted or contacted us, and does not recognise the transaction.")]
    NotRecognised = UnmatchedReasonCode.NotRecognised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty's instruction was too late for matching.
    /// Encoded/decoded by serializers as "CLAT".
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_Y5tJotp-Ed-ak6NoX_4Aeg_-716675521")]
    [Description(@"Counterparty's instruction was too late for matching.")]
    CounterpartyTooLateForMatching = UnmatchedReasonCode.CounterpartyTooLateForMatching, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty's instruction is physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Y5tJo9p-Ed-ak6NoX_4Aeg_935951987")]
    [Description(@"Counterparty's instruction is physical settlement, your instruction is not, or vice versa.")]
    PhysicalSettlement = UnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Common reference does not match.
    /// Encoded/decoded by serializers as "IIND".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Y5tJpNp-Ed-ak6NoX_4Aeg_643994249")]
    [Description(@"Common reference does not match.")]
    CommonReference = UnmatchedReasonCode.CommonReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type does not match: your instruction is free of payment, your counterparty's instruction is against payment or vice versa.
    /// Encoded/decoded by serializers as "FRAP".
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("_Y5tJpdp-Ed-ak6NoX_4Aeg_822112921")]
    [Description(@"Payment type does not match: your instruction is free of payment, your counterparty's instruction is against payment or vice versa.")]
    PaymentCode = UnmatchedReasonCode.PaymentCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as "PLCE".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Y5tJptp-Ed-ak6NoX_4Aeg_-1713747874")]
    [Description(@"Place of trade does not match.")]
    PlaceOfTrade = UnmatchedReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as "PODU".
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_Y5tJp9p-Ed-ak6NoX_4Aeg_-61120366")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate = UnmatchedReasonCode.PossibleDuplicate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Registration details linked to the transaction are incorrect.
    /// Encoded/decoded by serializers as "REGD".
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_Y5tJqNp-Ed-ak6NoX_4Aeg_-353078104")]
    [Description(@"Registration details linked to the transaction are incorrect.")]
    RegistrationDetails = UnmatchedReasonCode.RegistrationDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_Y5tJqdp-Ed-ak6NoX_4Aeg_-174959432")]
    [Description(@"Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.")]
    RTGSSystem = UnmatchedReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant of delivering or receiving depository does not match.
    /// Encoded/decoded by serializers as "ICAG".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Y5tJqtp-Ed-ak6NoX_4Aeg_1584147069")]
    [Description(@"Participant of delivering or receiving depository does not match.")]
    ReceivingDeliveringParty1 = UnmatchedReasonCode.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty cancelled their instruction.
    /// Encoded/decoded by serializers as "CPCA".
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_Y526oNp-Ed-ak6NoX_4Aeg_1549307755")]
    [Description(@"Counterparty cancelled their instruction.")]
    CounterpartyCancelled = UnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 2 does not match.
    /// Encoded/decoded by serializers as "IEXE".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Y526odp-Ed-ak6NoX_4Aeg_1257350017")]
    [Description(@"Client of delivering or receiving party 2 does not match.")]
    ReceivingDeliveringParty3 = UnmatchedReasonCode.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement amount currency does not match.
    /// Encoded/decoded by serializers as "NCRR".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_Y526otp-Ed-ak6NoX_4Aeg_1435468689")]
    [Description(@"Settlement amount currency does not match.")]
    CurrencySettlementAmount = UnmatchedReasonCode.CurrencySettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as "LEOG".
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_Y526o9p-Ed-ak6NoX_4Aeg_-1100392106")]
    [Description(@"Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.")]
    LetterOfGuarantee = UnmatchedReasonCode.LetterOfGuarantee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Matching process has not yet started.
    /// Encoded/decoded by serializers as "NMAS".
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_Y526pNp-Ed-ak6NoX_4Aeg_552235402")]
    [Description(@"Matching process has not yet started.")]
    NoMatchingStarted = UnmatchedReasonCode.NoMatchingStarted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Y526pdp-Ed-ak6NoX_4Aeg_260277664")]
    [Description(@"Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD.")]
    SafekeepingAccount = UnmatchedReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as "DTRD".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Y526ptp-Ed-ak6NoX_4Aeg_438396336")]
    [Description(@"Trade date does not match.")]
    TradeDate = UnmatchedReasonCode.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction was too late for matching.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Y526p9p-Ed-ak6NoX_4Aeg_-2097464459")]
    [Description(@"Your instruction was too late for matching.")]
    MarketDeadlineMissed = UnmatchedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Disagreement on the tax status of the financial instruments to be settled.
    /// Encoded/decoded by serializers as "TXST".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_Y526qNp-Ed-ak6NoX_4Aeg_-444836951")]
    [Description(@"Disagreement on the tax status of the financial instruments to be settled.")]
    TaxStatus = UnmatchedReasonCode.TaxStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 1 does not match.
    /// Encoded/decoded by serializers as "ICUS".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Y526qdp-Ed-ak6NoX_4Aeg_-736794689")]
    [Description(@"Client of delivering or receiving party 1 does not match.")]
    ReceivingDeliveringParty2 = UnmatchedReasonCode.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Proprietary unmatched reason code described in a narrative field.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Y6AEkNp-Ed-ak6NoX_4Aeg_-558676017")]
    [Description(@"Proprietary unmatched reason code described in a narrative field.")]
    Other = UnmatchedReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Missing market execution details.
    /// Encoded/decoded by serializers as "MIME".
    /// </summary>
    [EnumMember(Value = "MIME")]
    [IsoId("_Y6AEkdp-Ed-ak6NoX_4Aeg_1200430484")]
    [Description(@"Missing market execution details.")]
    MissingMarketSide = UnmatchedReasonCode.MissingMarketSide, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Market side trade is unmatched.
    /// Encoded/decoded by serializers as "UNBR".
    /// </summary>
    [EnumMember(Value = "UNBR")]
    [IsoId("_Y6AEktp-Ed-ak6NoX_4Aeg_-1441909304")]
    [Description(@"Market side trade is unmatched.")]
    UnmatchedMarketSide = UnmatchedReasonCode.UnmatchedMarketSide, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of safekeeping information does not allow matching to take place.
    /// Encoded/decoded by serializers as "INPS".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_Y6AEk9p-Ed-ak6NoX_4Aeg_633337571")]
    [Description(@"Place of safekeeping information does not allow matching to take place.")]
    PlaceOfSafekeeping = UnmatchedReasonCode.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnmatchedReason2CodeMetadataExtensions
{
    private static readonly UnmatchedReason2CodeDropdownSource _dropdownSource = new UnmatchedReason2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnmatchedReason2CodeDropdownRow GetMetadata(this UnmatchedReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


