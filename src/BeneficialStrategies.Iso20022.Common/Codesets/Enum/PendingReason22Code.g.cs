﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingReason22Code.  ISO2002 ID# _liBmURHpEeuE0Pnt-OcNOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_liBmURHpEeuE0Pnt-OcNOA")]
[Description(@"Specifies the reason why the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonV2Code))]
public enum PendingReason22Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_l2_wwRHpEeuE0Pnt-OcNOA")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = PendingFailingReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_l2_wwxHpEeuE0Pnt-OcNOA")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as "MONY".
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_l2_wyRHpEeuE0Pnt-OcNOA")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonV2Code.InsufficientMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as "LACK".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_l2_wyxHpEeuE0Pnt-OcNOA")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV2Code.LackOfSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_l2_wzRHpEeuE0Pnt-OcNOA")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as "CLAC".
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_1tV-YRHpEeuE0Pnt-OcNOA")]
    [Description(@"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.")]
    CounterpartyInsufficientSecurities = PendingFailingReasonV2Code.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient money in counterparty's account.
    /// Encoded/decoded by serializers as "CMON".
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_3BZnQRHpEeuE0Pnt-OcNOA")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney = PendingFailingReasonV2Code.CounterpartyInsufficientMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as "PREA".
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_Ii5b8RUHEeuZw7VHHgrHLg")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold = PendingFailingReasonV2Code.YourInstructionOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as "LINK".
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_JpaYERUHEeuZw7VHHgrHLg")]
    [Description(@"Your instruction is pending settlement because the instruction linked to it is pending.")]
    PendingLinkedInstruction = PendingFailingReasonV2Code.PendingLinkedInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as "CYCL".
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_Lh7Y4RUHEeuZw7VHHgrHLg")]
    [Description(@"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.")]
    AwaitingNextSettlementCycle = PendingFailingReasonV2Code.AwaitingNextSettlementCycle, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as "BOTH".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_NA_X4RUHEeuZw7VHHgrHLg")]
    [Description(@"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.")]
    BothInstructionsOnHold = PendingFailingReasonV2Code.BothInstructionsOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty's instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as "PRCY".
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("_Or9r8RUHEeuZw7VHHgrHLg")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold = PendingFailingReasonV2Code.CounterpartyInstructionOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting settlement date. No settlement problems to be reported.
    /// Encoded/decoded by serializers as "FUTU".
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_bPtwgS2qEeuVt5XRmyhHiA")]
    [Description(@"Awaiting settlement date. No settlement problems to be reported.")]
    AwaitingSettlementDate = PendingFailingReasonV2Code.AwaitingSettlementDate, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingReason22CodeMetadataExtensions
{
    private static readonly PendingReason22CodeDropdownSource _dropdownSource = new PendingReason22CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingReason22CodeDropdownRow GetMetadata(this PendingReason22Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


