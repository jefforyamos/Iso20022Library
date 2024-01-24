﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepairReasonCode.  ISO2002 ID# _Zu5sR9p-Ed-ak6NoX_4Aeg_-1795442208.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zu5sR9p-Ed-ak6NoX_4Aeg_-1795442208")]
[Description(@"Specifies the reason why the instruction is in repair.")]
[Derivations(typeof(RepairReason1Code),typeof(RepairReason2Code),typeof(RepairReason3Code))]
public enum RepairReasonCode
{
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/realtime while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as "BATC".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_Zu5sSNp-Ed-ak6NoX_4Aeg_-965197741")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/realtime while only possible to settle in overnight batch.")]
    ProcessingBatch,
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as "CADE".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_Zu5sSdp-Ed-ak6NoX_4Aeg_-964273788")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay,
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CAEV".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZvDdQNp-Ed-ak6NoX_4Aeg_-963350638")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateAction,
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZvDdQdp-Ed-ak6NoX_4Aeg_-953191968")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as "CASY".
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ZvDdQtp-Ed-ak6NoX_4Aeg_-952267985")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZvDdQ9p-Ed-ak6NoX_4Aeg_-951344063")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate,
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DDEA".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZvDdRNp-Ed-ak6NoX_4Aeg_-950420820")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,
    
    /// <summary>
    /// Unrecognised or invalid place of settlement.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZvDdRdp-Ed-ak6NoX_4Aeg_-949497514")]
    [Description(@"Unrecognised or invalid place of settlement.")]
    PlaceOfSettlement,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZvDdRtp-Ed-ak6NoX_4Aeg_-941185279")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount,
    
    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZvDdR9p-Ed-ak6NoX_4Aeg_-940261811")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZvDdSNp-Ed-ak6NoX_4Aeg_-939338660")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security,
    
    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as "DTRD".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ZvDdSdp-Ed-ak6NoX_4Aeg_-938415292")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate,
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as "FORF".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ZvMnMNp-Ed-ak6NoX_4Aeg_-937492142")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount,
    
    /// <summary>
    /// Unrecognised or invalid receiving or delivering agent.
    /// Encoded/decoded by serializers as "ICAG".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZvMnMdp-Ed-ak6NoX_4Aeg_-936568128")]
    [Description(@"Unrecognised or invalid receiving or delivering agent.")]
    Agent,
    
    /// <summary>
    /// Unrecognised or invalid receiving or delivering custodian.
    /// Encoded/decoded by serializers as "ICUS".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ZvMnMtp-Ed-ak6NoX_4Aeg_-935644175")]
    [Description(@"Unrecognised or invalid receiving or delivering custodian.")]
    ReceivingOrDeliveringCustodian,
    
    /// <summary>
    /// Unrecognised or invalid buyer or seller.
    /// Encoded/decoded by serializers as "IEXE".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZvMnM9p-Ed-ak6NoX_4Aeg_-933799529")]
    [Description(@"Unrecognised or invalid buyer or seller.")]
    BuyerorSeller,
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "IIND".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_ZvMnNNp-Ed-ak6NoX_4Aeg_-932876462")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference,
    
    /// <summary>
    /// Unrecognised or invalid letter of guarantee indicator instructed.
    /// Encoded/decoded by serializers as "LEOG".
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_ZvMnNdp-Ed-ak6NoX_4Aeg_-925488695")]
    [Description(@"Unrecognised or invalid letter of guarantee indicator instructed.")]
    LetterOfGuaranteeIndicator,
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MINO".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ZvMnNtp-Ed-ak6NoX_4Aeg_-924565296")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MUNO".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ZvMnN9p-Ed-ak6NoX_4Aeg_-923641806")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "NCRR".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZvMnONp-Ed-ak6NoX_4Aeg_-923638318")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency,
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZvMnOdp-Ed-ak6NoX_4Aeg_-921794703")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PLCE".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ZvMnOtp-Ed-ak6NoX_4Aeg_-920871212")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "REFE".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZvWYMNp-Ed-ak6NoX_4Aeg_-912559584")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    Reference,
    
    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as "REPA".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ZvWYMdp-Ed-ak6NoX_4Aeg_-911635387")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_ZvWYMtp-Ed-ak6NoX_4Aeg_-910711866")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate,
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as "REPP".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_ZvWYM9p-Ed-ak6NoX_4Aeg_-909788005")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as "RERT".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_ZvWYNNp-Ed-ak6NoX_4Aeg_-908863877")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType,
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as "RSPR".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_ZvWYNdp-Ed-ak6NoX_4Aeg_-907939962")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate,
    
    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZvWYNtp-Ed-ak6NoX_4Aeg_-907016410")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZvWYN9p-Ed-ak6NoX_4Aeg_-904245324")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount,
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SETR".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZvWYONp-Ed-ak6NoX_4Aeg_-895010114")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction,
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SETS".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_ZvWYOdp-Ed-ak6NoX_4Aeg_-893165521")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod,
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ZvWYOtp-Ed-ak6NoX_4Aeg_-892239673")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTime,
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TXST".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ZvgJMNp-Ed-ak6NoX_4Aeg_-883006851")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus,
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as "VASU".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_ZvgJMdp-Ed-ak6NoX_4Aeg_-882082138")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupport,
    
    /// <summary>
    /// Received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZvgJMtp-Ed-ak6NoX_4Aeg_-1814110963")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as "BUSE".
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_ZvgJM9p-Ed-ak6NoX_4Aeg_982700249")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRepair,
    
    /// <summary>
    /// Unrecognized or invalid commercialization contract.
    /// Encoded/decoded by serializers as "COMC".
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_ZvgJNNp-Ed-ak6NoX_4Aeg_983624695")]
    [Description(@"Unrecognized or invalid commercialization contract.")]
    CommercializationContractRepair,
    
    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as "FEEE".
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_ZvgJNdp-Ed-ak6NoX_4Aeg_985470381")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRepair,
    
    /// <summary>
    /// Unrecognised or invalid service level agreement preagreed narrative information.
    /// Encoded/decoded by serializers as "INNA".
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_ZvgJNtp-Ed-ak6NoX_4Aeg_1012254360")]
    [Description(@"Unrecognised or invalid service level agreement preagreed narrative information.")]
    NarrativeInformationRepair,
    
    /// <summary>
    /// Cancellation request is in repair since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as "NRGM".
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_ZvgJN9p-Ed-ak6NoX_4Aeg_1013177511")]
    [Description(@"Cancellation request is in repair since more than one instruction match to the cancellation criteria.")]
    NoMatch,
    
    /// <summary>
    /// Cancellation request is in repair since the instruction could not be found.
    /// Encoded/decoded by serializers as "NRGN".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_ZvgJONp-Ed-ak6NoX_4Aeg_1015023144")]
    [Description(@"Cancellation request is in repair since the instruction could not be found.")]
    NotFound,
    
    /// <summary>
    /// Message was not recognised. Unknown linked reference.
    /// Encoded/decoded by serializers as "ULNK".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_ZvgJOdp-Ed-ak6NoX_4Aeg_1586684343")]
    [Description(@"Message was not recognised. Unknown linked reference.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RepairReasonCodeMetadataExtensions
{
    private static readonly RepairReasonCodeDropdownSource _dropdownSource = new RepairReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRepairReasonCodeDropdownRow GetMetadata(this RepairReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


