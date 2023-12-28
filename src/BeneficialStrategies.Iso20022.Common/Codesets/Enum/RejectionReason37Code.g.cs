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
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_icSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_icywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    QuantityRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_idSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_idywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    InvalidSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ieSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ieywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    CashAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ifSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    DealPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ifywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    TradeDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_igSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    PlaceOfTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleToUseTheRTGSSystemInstructed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_igywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ihSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhysicalSettlementImpossible".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ihywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_iiSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    ReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_iiywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    SettlementAmountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ijSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProcessingBatchRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ijywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    ProcessingBatchRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ikSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxStatusRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ikywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    TaxStatusRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementSystemMethodRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ilSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    SettlementSystemMethodRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ilywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    CommonReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateActionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_imSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    CorporateActionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleCashSettlementSystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_imywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_inSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    SettlementDateRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_inywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfStampDuty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ioSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    LackOfStampDuty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ioywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ipSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_ipywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_iqSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    ReceivingDeliveringParty1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_iqywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_irSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidBalance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_irywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    InvalidBalance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidLink".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_isSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    InvalidLink,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidLotNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_isywrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    InvalidLotNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidRule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-_itSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    InvalidRule,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidInvestorParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sTvQsSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
    InvalidInvestorParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfListing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uSgDcSwrEeOEV5XHD-BKpw")]
    [Description(@"??")]
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

