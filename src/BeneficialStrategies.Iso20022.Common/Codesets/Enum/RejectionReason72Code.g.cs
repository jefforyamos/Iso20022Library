﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason72Code.  ISO2002 ID# _FT0YVCtWEeyhipY4f42fZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FT0YVCtWEeyhipY4f42fZQ")]
[Description(@"Specifies the reason why the settlement instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason72Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aMStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aMytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    QuantityRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aNStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aNytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aOStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aOytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CashAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aPStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    DealPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aPytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TradeDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aQStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PlaceOfTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleToUseTheRTGSSystemInstructed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aQytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aRStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhysicalSettlementImpossible".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aRytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aSStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aSytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementAmountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aTStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProcessingBatchRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aTytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ProcessingBatchRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aUStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxStatusRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aUytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TaxStatusRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementSystemMethodRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aVStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementSystemMethodRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aVytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CommonReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateActionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aWStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CorporateActionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleCashSettlementSystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aWytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aXStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementDateRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aXytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfStampDuty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aYStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    LackOfStampDuty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aYytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aZStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aZytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aaStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringParty1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0aaytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0abStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidLink".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0abytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidLink,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidBalance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0acStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidBalance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidLotNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0acytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidLotNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidRule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9G0adStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidRule,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason72CodeMetadataExtensions
{
    private static readonly RejectionReason72CodeDropdownSource _dropdownSource = new RejectionReason72CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason72CodeDropdownRow GetMetadata(this RejectionReason72Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


