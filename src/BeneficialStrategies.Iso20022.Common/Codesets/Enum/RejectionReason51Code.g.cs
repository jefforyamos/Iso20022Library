﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason51Code.  ISO2002 ID# _U-MrYLLMEemDyeh7tbvg1w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U-MrYLLMEemDyeh7tbvg1w")]
[Description(@"Specifies a reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason51Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_uT2FAbLMEemDyeh7tbvg1w")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_xwyF8bLMEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as "DCAN".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_zaaWMbLMEemDyeh7tbvg1w")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled = RejectionReasonV3Code.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as "DPRG".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_00txAbLMEemDyeh7tbvg1w")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress = RejectionReasonV3Code.RejectedSinceInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_3UgNMbLMEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "EVNM".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_6LyjYbLMEemDyeh7tbvg1w")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as "INIR".
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_9PSJkbLMEemDyeh7tbvg1w")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonV3Code.InstructionIrrevocable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("__hh5AbLMEemDyeh7tbvg1w")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_CC8s4bLNEemDyeh7tbvg1w")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer or registrar has rejected the instruction.
    /// Encoded/decoded by serializers as "RBIS".
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_GEoZobLNEemDyeh7tbvg1w")]
    [Description(@"Issuer or registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar = RejectionReasonV3Code.RejectedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_OfV8IbLNEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "ULNK".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_ayz44bLNEemDyeh7tbvg1w")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason51CodeMetadataExtensions
{
    private static readonly RejectionReason51CodeDropdownSource _dropdownSource = new RejectionReason51CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason51CodeDropdownRow GetMetadata(this RejectionReason51Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


