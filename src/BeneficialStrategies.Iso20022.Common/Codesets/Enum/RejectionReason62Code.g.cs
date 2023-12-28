﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason62Code.  ISO2002 ID# _RZnBUhIvEeyHZKWo4KVxBw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the transaction or in the instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RZnBUhIvEeyHZKWo4KVxBw")]
[Description(@"Specifies the reason why the transaction or in the instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason62Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCkRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    ReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCkxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClientCollateralInstructionIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXClRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    ClientCollateralInstructionIdentification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClientCollateralTransactionIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXClxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    ClientCollateralTransactionIdentification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCmRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    CommonReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidPartyA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCmxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    InvalidPartyA,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidPartyB".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCnRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    InvalidPartyB,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidTripartyAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCnxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    InvalidTripartyAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCoRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartyASafekeepingAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCoxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    PartyASafekeepingAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartyBSafekeepingAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCpRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    PartyBSafekeepingAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RequestedExecutionDateTime".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCpxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    RequestedExecutionDateTime,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementProcessRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCqRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    SettlementProcessRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LookbackDaysRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCqxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    LookbackDaysRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DayCountBasis".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCrRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    DayCountBasis,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompoundSimpleAccrualCalculationRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCrxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    CompoundSimpleAccrualCalculationRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClosingDateTimeRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCsRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    ClosingDateTimeRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCsxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    TradeDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCtRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    SettlementDateRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCtxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidEligibilitySetProfile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCuRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    InvalidEligibilitySetProfile,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidExposureType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCuxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    InvalidExposureType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidPreferentialBasketIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCvRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    InvalidPreferentialBasketIdentification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidRateIndexType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCvxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    InvalidRateIndexType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TerminationAmountCurrency".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCwRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    TerminationAmountCurrency,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TerminationTransactionAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCwxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    TerminationTransactionAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TransactionAmountCurrency".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCxRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    TransactionAmountCurrency,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoMatch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCxxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    NoMatch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TransactionAmountBreakdownCurrency".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCyRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    TransactionAmountBreakdownCurrency,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidCollateralTransactionType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCyxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    InvalidCollateralTransactionType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotFoundRejectionForCancellationModificationOrTermination".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCzRIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    NotFoundRejectionForCancellationModificationOrTermination,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotFoundCorrespondingAllegement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXCzxIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    NotFoundCorrespondingAllegement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClosingTransactionAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XhXC0RIvEeyHZKWo4KVxBw")]
    [Description(@"??")]
    ClosingTransactionAmount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason62CodeMetadataExtensions
{
    private static readonly RejectionReason62CodeDropdownSource _dropdownSource = new RejectionReason62CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason62CodeDropdownRow GetMetadata(this RejectionReason62Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


