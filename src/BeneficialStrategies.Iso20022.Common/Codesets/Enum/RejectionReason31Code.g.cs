﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason31Code.  ISO2002 ID# _2TSkwQrlEeG2Qoz6TTiHZw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcVxQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcVyQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    QuantityRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcVzQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV0QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    InvalidSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV1QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV2QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    CashAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV3QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    DealPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV4QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    TradeDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV5QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    PlaceOfTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleToUseTheRTGSSystemInstructed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV6QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV7QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhysicalSettlementImpossible".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV8QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV9QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    ReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV-QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    SettlementAmountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcV_QrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProcessingBatchRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWAQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    ProcessingBatchRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWBQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxStatusRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWCQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    TaxStatusRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementSystemMethodRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWDQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    SettlementSystemMethodRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWEQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    CommonReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateActionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWFQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    CorporateActionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleCashSettlementSystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWGQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWHQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    SettlementDateRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWIQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfStampDuty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWJQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    LackOfStampDuty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWKQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWLQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWMQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWNQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    ReceivingDeliveringParty1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWOQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2TcWPQrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidLink".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_45vCkgrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    InvalidLink,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidBalance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9Ior8grlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    InvalidBalance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidLotNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_92-YqgrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    InvalidLotNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidRule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-j-okgrlEeG2Qoz6TTiHZw")]
    [Description(@"??")]
    InvalidRule,
    
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


