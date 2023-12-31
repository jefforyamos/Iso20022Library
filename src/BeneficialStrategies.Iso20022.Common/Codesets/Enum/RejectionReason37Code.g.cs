﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason37Code.  ISO2002 ID# _okzg0SwrEeOEV5XHD-BKpw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_okzg0SwrEeOEV5XHD-BKpw")]
[Description(@"Specifies the reason why the settlement instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason37Code
{
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_o-_icSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_o-_icywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_o-_idSwrEeOEV5XHD-BKpw")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_o-_idywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_o-_ieSwrEeOEV5XHD-BKpw")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_o-_ieywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_o-_ifSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,
    
    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_o-_ifywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate,
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_o-_igSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,
    
    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as "ImpossibleToUseTheRTGSSystemInstructed".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_o-_igywrEeOEV5XHD-BKpw")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_o-_ihSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as "PhysicalSettlementImpossible".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_o-_ihywrEeOEV5XHD-BKpw")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_o-_iiSwrEeOEV5XHD-BKpw")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_o-_iiywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection,
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_o-_ijSwrEeOEV5XHD-BKpw")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as "ProcessingBatchRejection".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_o-_ijywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatchRejection,
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_o-_ikSwrEeOEV5XHD-BKpw")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TaxStatusRejection".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_o-_ikywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SettlementSystemMethodRejection".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_o-_ilSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection,
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_o-_ilywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection,
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CorporateActionRejection".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_o-_imSwrEeOEV5XHD-BKpw")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection,
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as "ImpossibleCashSettlementSystem".
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_o-_imywrEeOEV5XHD-BKpw")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_o-_inSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_o-_inywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as "LackOfStampDuty".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_o-_ioSwrEeOEV5XHD-BKpw")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty,
    
    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_o-_ioywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_o-_ipSwrEeOEV5XHD-BKpw")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_o-_ipywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_o-_iqSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1,
    
    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_o-_iqywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_o-_irSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// Instruction aims at using an invalid balance.
    /// Encoded/decoded by serializers as "InvalidBalance".
    /// </summary>
    [EnumMember(Value = "INVB")]
    [IsoId("_o-_irywrEeOEV5XHD-BKpw")]
    [Description(@"Instruction aims at using an invalid balance.")]
    InvalidBalance,
    
    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as "InvalidLink".
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_o-_isSwrEeOEV5XHD-BKpw")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink,
    
    /// <summary>
    /// Invalid or unrecognized lot number.
    /// Encoded/decoded by serializers as "InvalidLotNumber".
    /// </summary>
    [EnumMember(Value = "INVN")]
    [IsoId("_o-_isywrEeOEV5XHD-BKpw")]
    [Description(@"Invalid or unrecognized lot number.")]
    InvalidLotNumber,
    
    /// <summary>
    /// Account servicer validation rule rejection.
    /// Encoded/decoded by serializers as "InvalidRule".
    /// </summary>
    [EnumMember(Value = "VALR")]
    [IsoId("_o-_itSwrEeOEV5XHD-BKpw")]
    [Description(@"Account servicer validation rule rejection.")]
    InvalidRule,
    
    /// <summary>
    /// Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.
    /// Encoded/decoded by serializers as "InvalidInvestorParty".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_sTvQsSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.")]
    InvalidInvestorParty,
    
    /// <summary>
    /// Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.
    /// Encoded/decoded by serializers as "PlaceOfListing".
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("_uSgDcSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.")]
    PlaceOfListing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason37CodeMetadataExtensions
{
    private static readonly RejectionReason37CodeDropdownSource _dropdownSource = new RejectionReason37CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason37CodeDropdownRow GetMetadata(this RejectionReason37Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


