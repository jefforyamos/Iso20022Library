﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepairReason6Code.  ISO2002 ID# _ixP4oT9qEeCY7potQsO_IA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the securities financing instruction has a repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ixP4oT9qEeCY7potQsO_IA")]
[Description(@"Specifies the reason why the securities financing instruction has a repair status.")]
[DerivedFrom(typeof(RepairReasonV2Code))]
public enum RepairReason6Code
{
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as "BATC".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_ixZClT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatch = RepairReasonV2Code.ProcessingBatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CAEV".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ixZCmT9qEeCY7potQsO_IA")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateAction = RepairReasonV2Code.CorporateAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ixZCnT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RepairReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as "CASY".
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ixZCoT9qEeCY7potQsO_IA")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem = RepairReasonV2Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ixZCpT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate = RepairReasonV2Code.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DDEA".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ixZCqT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RepairReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ixZCrT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount = RepairReasonV2Code.SettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ixZCsT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity = RepairReasonV2Code.Quantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ixZCtT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security = RepairReasonV2Code.Security, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as "DTRD".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ixZCuT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate = RepairReasonV2Code.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "IIND".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_ixZCvT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference = RepairReasonV2Code.CommonReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MINO".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ixZCwT9qEeCY7potQsO_IA")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity = RepairReasonV2Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MUNO".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ixZCxT9qEeCY7potQsO_IA")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity = RepairReasonV2Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "NCRR".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ixZCyT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency = RepairReasonV2Code.SettlementAmountCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ixZCzT9qEeCY7potQsO_IA")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RepairReasonV2Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PLCE".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ixZC0T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RepairReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "REFE".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ixZC1T9qEeCY7potQsO_IA")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    Reference = RepairReasonV2Code.Reference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ixZC2T9qEeCY7potQsO_IA")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed = RepairReasonV2Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ixZC3T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount = RepairReasonV2Code.SafekeepingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SETR".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ixZC4T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction = RepairReasonV2Code.SettlementTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SETS".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_ixZC5T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod = RepairReasonV2Code.SettlementSystemMethod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TXST".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ixZC6T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus = RepairReasonV2Code.TaxStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing Place of Safekeeping.
    /// Encoded/decoded by serializers as "INPS".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_ixZC7T9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised, invalid or missing Place of Safekeeping.")]
    PlaceOfSafekeeping = RepairReasonV2Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as "SDUT".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_ixZC8T9qEeCY7potQsO_IA")]
    [Description(@"Required stamp duty information is missing.")]
    StampDuty = RepairReasonV2Code.StampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ixZC9T9qEeCY7potQsO_IA")]
    [Description(@"Other. See Narrative.")]
    Other = RepairReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 2 mismatch.
    /// Encoded/decoded by serializers as "IEXE".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ixZC-T9qEeCY7potQsO_IA")]
    [Description(@"Client of delivering or receiving party 2 mismatch.")]
    ReceivingDeliveringParty3 = RepairReasonV2Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant of delivering or receiving depository mismatch.
    /// Encoded/decoded by serializers as "ICAG".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ixZC_T9qEeCY7potQsO_IA")]
    [Description(@"Participant of delivering or receiving depository mismatch.")]
    ReceivingDeliveringParty1 = RepairReasonV2Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Depository mismatch.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ixZDAT9qEeCY7potQsO_IA")]
    [Description(@"Depository mismatch.")]
    ReceivingDeliveringDepository = RepairReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client of delivering or receiving party 1 mismatch.
    /// Encoded/decoded by serializers as "ICUS".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ixZDBT9qEeCY7potQsO_IA")]
    [Description(@"Client of delivering or receiving party 1 mismatch.")]
    ReceivingDeliveringParty2 = RepairReasonV2Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as "REPA".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ixZDCT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RepairReasonV2Code.TerminationTransactionAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as "CADE".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ixZDDT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RepairReasonV2Code.TransactionCallDelay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as "RERT".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_ixZDET9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RepairReasonV2Code.RepurchaseRateType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as "RSPR".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_ixZDFT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RepairReasonV2Code.SpreadRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as "VASU".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_ixZDGT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupport = RepairReasonV2Code.VariableRateSupport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_ixZDHT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RepairReasonV2Code.RepurchaseRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as "REPP".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_ixZDIT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RepairReasonV2Code.PremiumAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ixZDJT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTime = RepairReasonV2Code.ClosingDateTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as "FORF".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ixZDKT9qEeCY7potQsO_IA")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RepairReasonV2Code.ForfeitAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_q1_VsWtdEeCY4-KZ9JEyUQ_92472732")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = RepairReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as "BUSE".
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_q1_VsmtdEeCY4-KZ9JEyUQ_1934269726")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRepair = RepairReasonV2Code.TypeOfOrderRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognized or invalid commercialization contract.
    /// Encoded/decoded by serializers as "COMC".
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_q1_Vs2tdEeCY4-KZ9JEyUQ_753035981")]
    [Description(@"Unrecognized or invalid commercialization contract.")]
    CommercializationContractRepair = RepairReasonV2Code.CommercializationContractRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as "FEEE".
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_q1_VtGtdEeCY4-KZ9JEyUQ_1766970131")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRepair = RepairReasonV2Code.FeeCommissionRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as "INNA".
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_q1_VtWtdEeCY4-KZ9JEyUQ_838136585")]
    [Description(@"Unrecognised or invalid service level agreement pre-agreed narrative information.")]
    NarrativeInformationRepair = RepairReasonV2Code.NarrativeInformationRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is in repair since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as "NRGM".
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_q2JGsGtdEeCY4-KZ9JEyUQ_1412835247")]
    [Description(@"Cancellation request is in repair since more than one instruction match to the cancellation criteria.")]
    NoMatch = RepairReasonV2Code.NoMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is in repair since the instruction could not be found.
    /// Encoded/decoded by serializers as "NRGN".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_q2JGsWtdEeCY4-KZ9JEyUQ_892857611")]
    [Description(@"Cancellation request is in repair since the instruction could not be found.")]
    NotFound = RepairReasonV2Code.NotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message was not recognised. Unknown linked reference.
    /// Encoded/decoded by serializers as "ULNK".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_q2JGsmtdEeCY4-KZ9JEyUQ_-1505593503")]
    [Description(@"Message was not recognised. Unknown linked reference.")]
    Unknown = RepairReasonV2Code.Unknown, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RepairReason6CodeMetadataExtensions
{
    private static readonly RepairReason6CodeDropdownSource _dropdownSource = new RepairReason6CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRepairReason6CodeDropdownRow GetMetadata(this RepairReason6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


