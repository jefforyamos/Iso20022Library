﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnmatchedReason10Code.  ISO2002 ID# _VjPh8SwLEeOqZONeZTLNPw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VjPh8SwLEeOqZONeZTLNPw")]
[Description(@"Specifies the reason the transaction, transfer or settlement instruction is unmatched.")]
[DerivedFrom(typeof(UnmatchedReasonCode))]
public enum UnmatchedReason10Code
{
    /// <summary>
    /// Received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_V81GoSwLEeOqZONeZTLNPw")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = UnmatchedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction call delay does not match.
    /// Encoded/decoded by serializers as "CADE".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_V81GoywLEeOqZONeZTLNPw")]
    [Description(@"Transaction call delay does not match.")]
    RepurchaseCallDelay = UnmatchedReasonCode.RepurchaseCallDelay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty's instruction was too late for matching.
    /// Encoded/decoded by serializers as "CLAT".
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_V81GpSwLEeOqZONeZTLNPw")]
    [Description(@"Counterparty's instruction was too late for matching.")]
    CounterpartyTooLateForMatching = UnmatchedReasonCode.CounterpartyTooLateForMatching, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A matching instruction from your counterparty could not be found.
    /// Encoded/decoded by serializers as "CMIS".
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_V81GpywLEeOqZONeZTLNPw")]
    [Description(@"A matching instruction from your counterparty could not be found.")]
    NoMatch = UnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty cancelled their instruction.
    /// Encoded/decoded by serializers as "CPCA".
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_V81GqSwLEeOqZONeZTLNPw")]
    [Description(@"Counterparty cancelled their instruction.")]
    CounterpartyCancelled = UnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement date/time does not match.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_V81GqywLEeOqZONeZTLNPw")]
    [Description(@"Settlement date/time does not match.")]
    SettlementDate = UnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deal price does not match.
    /// Encoded/decoded by serializers as "DDEA".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_V81GrSwLEeOqZONeZTLNPw")]
    [Description(@"Deal price does not match.")]
    DealPrice = UnmatchedReasonCode.DealPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.
    /// Encoded/decoded by serializers as "DELN".
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_V81GrywLEeOqZONeZTLNPw")]
    [Description(@"Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.")]
    TransactionDirection = UnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Depository does not match.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_V81GsSwLEeOqZONeZTLNPw")]
    [Description(@"Depository does not match.")]
    ReceivingDeliveringDepository = UnmatchedReasonCode.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement amount does not match.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_V81GsywLEeOqZONeZTLNPw")]
    [Description(@"Settlement amount does not match.")]
    SettlementAmount = UnmatchedReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_V81GtSwLEeOqZONeZTLNPw")]
    [Description(@"Quantity of financial instruments does not match.")]
    FinancialInstrumentQuantity = UnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_V81GtywLEeOqZONeZTLNPw")]
    [Description(@"Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.")]
    FinancialInstrument = UnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty has been contacted or contacted us, and does not recognise the transaction.
    /// Encoded/decoded by serializers as "DTRA".
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_V81GuSwLEeOqZONeZTLNPw")]
    [Description(@"Counterparty has been contacted or contacted us, and does not recognise the transaction.")]
    NotRecognised = UnmatchedReasonCode.NotRecognised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as "DTRD".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_V81GuywLEeOqZONeZTLNPw")]
    [Description(@"Trade date does not match.")]
    TradeDate = UnmatchedReasonCode.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Forfeit amount does not match.
    /// Encoded/decoded by serializers as "FORF".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_V81GvSwLEeOqZONeZTLNPw")]
    [Description(@"Forfeit amount does not match.")]
    ForfeitRepurchaseAmount = UnmatchedReasonCode.ForfeitRepurchaseAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type does not match: your instruction is free of payment, your counterparty's instruction is against payment or vice versa.
    /// Encoded/decoded by serializers as "FRAP".
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("_V81GvywLEeOqZONeZTLNPw")]
    [Description(@"Payment type does not match: your instruction is free of payment, your counterparty's instruction is against payment or vice versa.")]
    PaymentCode = UnmatchedReasonCode.PaymentCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant of delivering or receiving depository does not match.
    /// Encoded/decoded by serializers as "ICAG".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_V81GwSwLEeOqZONeZTLNPw")]
    [Description(@"Participant of delivering or receiving depository does not match.")]
    ReceivingDeliveringParty1 = UnmatchedReasonCode.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 1 does not match.
    /// Encoded/decoded by serializers as "ICUS".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_V81GwywLEeOqZONeZTLNPw")]
    [Description(@"Client of delivering or receiving party 1 does not match.")]
    ReceivingDeliveringParty2 = UnmatchedReasonCode.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 2 does not match.
    /// Encoded/decoded by serializers as "IEXE".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_V81GxSwLEeOqZONeZTLNPw")]
    [Description(@"Client of delivering or receiving party 2 does not match.")]
    ReceivingDeliveringParty3 = UnmatchedReasonCode.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Common reference does not match.
    /// Encoded/decoded by serializers as "IIND".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_V81GxywLEeOqZONeZTLNPw")]
    [Description(@"Common reference does not match.")]
    CommonReference = UnmatchedReasonCode.CommonReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction was too late for matching.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_V81GySwLEeOqZONeZTLNPw")]
    [Description(@"Your instruction was too late for matching.")]
    MarketDeadlineMissed = UnmatchedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as "LEOG".
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_V81GyywLEeOqZONeZTLNPw")]
    [Description(@"Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.")]
    LetterOfGuarantee = UnmatchedReasonCode.LetterOfGuarantee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement amount currency does not match.
    /// Encoded/decoded by serializers as "NCRR".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_V81GzSwLEeOqZONeZTLNPw")]
    [Description(@"Settlement amount currency does not match.")]
    CurrencySettlementAmount = UnmatchedReasonCode.CurrencySettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Matching process has not yet started.
    /// Encoded/decoded by serializers as "NMAS".
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_V81GzywLEeOqZONeZTLNPw")]
    [Description(@"Matching process has not yet started.")]
    NoMatchingStarted = UnmatchedReasonCode.NoMatchingStarted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty's instruction is physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_V81G0SwLEeOqZONeZTLNPw")]
    [Description(@"Counterparty's instruction is physical settlement, your instruction is not, or vice versa.")]
    PhysicalSettlement = UnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as "PLCE".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_V81G0ywLEeOqZONeZTLNPw")]
    [Description(@"Place of trade does not match.")]
    PlaceOfTrade = UnmatchedReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as "PODU".
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_V81G1SwLEeOqZONeZTLNPw")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate = UnmatchedReasonCode.PossibleDuplicate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Registration details linked to the transaction are incorrect.
    /// Encoded/decoded by serializers as "REGD".
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_V81G1ywLEeOqZONeZTLNPw")]
    [Description(@"Registration details linked to the transaction are incorrect.")]
    RegistrationDetails = UnmatchedReasonCode.RegistrationDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Termination transaction amount does not match.
    /// Encoded/decoded by serializers as "REPA".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_V81G2SwLEeOqZONeZTLNPw")]
    [Description(@"Termination transaction amount does not match.")]
    RepurchaseAmount = UnmatchedReasonCode.RepurchaseAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repurchase rate does not match.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_V81G2ywLEeOqZONeZTLNPw")]
    [Description(@"Repurchase rate does not match.")]
    RepurchaseRate = UnmatchedReasonCode.RepurchaseRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Premium amount does not match.
    /// Encoded/decoded by serializers as "REPP".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_V81G3SwLEeOqZONeZTLNPw")]
    [Description(@"Premium amount does not match.")]
    RepurchasePremiumAmount = UnmatchedReasonCode.RepurchasePremiumAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repurchase rate type does not match.
    /// Encoded/decoded by serializers as "RERT".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_V81G3ywLEeOqZONeZTLNPw")]
    [Description(@"Repurchase rate type does not match.")]
    RepurchaseRateType = UnmatchedReasonCode.RepurchaseRateType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_V81G4SwLEeOqZONeZTLNPw")]
    [Description(@"Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.")]
    RTGSSystem = UnmatchedReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_V81G4ywLEeOqZONeZTLNPw")]
    [Description(@"Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD.")]
    SafekeepingAccount = UnmatchedReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).
    /// Encoded/decoded by serializers as "SETR".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_V81G5SwLEeOqZONeZTLNPw")]
    [Description(@"Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).")]
    SettlementTransaction = UnmatchedReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).
    /// Encoded/decoded by serializers as "SETS".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_V81G5ywLEeOqZONeZTLNPw")]
    [Description(@"Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).")]
    SettlementSystemMethod = UnmatchedReasonCode.SettlementSystemMethod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Closing date/time does not match.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_V81G6SwLEeOqZONeZTLNPw")]
    [Description(@"Closing date/time does not match.")]
    ClosingDateTime = UnmatchedReasonCode.ClosingDateTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Disagreement on the tax status of the financial instruments to be settled.
    /// Encoded/decoded by serializers as "TXST".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_V81G6ywLEeOqZONeZTLNPw")]
    [Description(@"Disagreement on the tax status of the financial instruments to be settled.")]
    TaxStatus = UnmatchedReasonCode.TaxStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Variable rate support does not match (repo).
    /// Encoded/decoded by serializers as "VASU".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_V81G7SwLEeOqZONeZTLNPw")]
    [Description(@"Variable rate support does not match (repo).")]
    VariableRateSupport = UnmatchedReasonCode.VariableRateSupport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of safekeeping information does not allow matching to take place.
    /// Encoded/decoded by serializers as "INPS".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_V81G7ywLEeOqZONeZTLNPw")]
    [Description(@"Place of safekeeping information does not allow matching to take place.")]
    PlaceOfSafekeeping = UnmatchedReasonCode.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Proprietary unmatched reason code described in a narrative field.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_V81G8SwLEeOqZONeZTLNPw")]
    [Description(@"Proprietary unmatched reason code described in a narrative field.")]
    Other = UnmatchedReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accrued interest amount does not match.
    /// Encoded/decoded by serializers as "ACRU".
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_V81G8ywLEeOqZONeZTLNPw")]
    [Description(@"Accrued interest amount does not match.")]
    AccruedInterestAmount1 = UnmatchedReasonCode.AccruedInterestAmount1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of listing does not match.
    /// Encoded/decoded by serializers as "PLIS".
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("_R6grQSwMEeOqZONeZTLNPw")]
    [Description(@"Place of listing does not match.")]
    PlaceOfListing = UnmatchedReasonCode.PlaceOfListing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor party does not match.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_SvB4cSwMEeOqZONeZTLNPw")]
    [Description(@"Investor party does not match.")]
    InvestorParty = UnmatchedReasonCode.InvestorParty, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnmatchedReason10CodeMetadataExtensions
{
    private static readonly UnmatchedReason10CodeDropdownSource _dropdownSource = new UnmatchedReason10CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnmatchedReason10CodeDropdownRow GetMetadata(this UnmatchedReason10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


