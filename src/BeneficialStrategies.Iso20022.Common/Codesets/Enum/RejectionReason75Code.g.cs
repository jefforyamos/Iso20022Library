﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason75Code.  ISO2002 ID# _W6dCZitXEeyhipY4f42fZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W6dCZitXEeyhipY4f42fZQ")]
[Description(@"Specifies the reason why the settlement instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason75Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpIStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpIytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    QuantityRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpJStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpJytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpKStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpKytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CashAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpLStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    DealPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpLytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TradeDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpMStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PlaceOfTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleToUseTheRTGSSystemInstructed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpMytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpNStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhysicalSettlementImpossible".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpNytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpOStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpOytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementAmountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpPStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProcessingBatchRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpPytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ProcessingBatchRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpQStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxStatusRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpQytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TaxStatusRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementSystemMethodRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpRStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementSystemMethodRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpRytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CommonReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateActionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpSStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CorporateActionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleCashSettlementSystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpSytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpTStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementDateRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpTytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfStampDuty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpUStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    LackOfStampDuty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpUytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpVStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpVytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpWStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringParty1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpWytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BcpXStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidBalance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BmaIStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidBalance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidLink".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BmaIytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidLink,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidLotNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BmaJStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidLotNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidRule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BmaJytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidRule,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidInvestorParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BmaKStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidInvestorParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfListing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7BmaKytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PlaceOfListing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason75CodeMetadataExtensions
{
    private static readonly RejectionReason75CodeDropdownSource _dropdownSource = new RejectionReason75CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason75CodeDropdownRow GetMetadata(this RejectionReason75Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


