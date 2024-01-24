﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason79Code.  ISO2002 ID# __SMwITQWEe2o-K1dwNg8Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__SMwITQWEe2o-K1dwNg8Gg")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason79Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("__tK04TQWEe2o-K1dwNg8Gg")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as "INIR".
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("__tK04zQWEe2o-K1dwNg8Gg")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonV3Code.InstructionIrrevocable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "ULNK".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("__tK05TQWEe2o-K1dwNg8Gg")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("__tK05zQWEe2o-K1dwNg8Gg")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__tK06TQWEe2o-K1dwNg8Gg")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as "DCAN".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("__tK06zQWEe2o-K1dwNg8Gg")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled = RejectionReasonV3Code.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as "DPRG".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("__tK07TQWEe2o-K1dwNg8Gg")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress = RejectionReasonV3Code.RejectedSinceInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction rejected by the issuer agent.
    /// Encoded/decoded by serializers as "REJA".
    /// </summary>
    [EnumMember(Value = "REJA")]
    [IsoId("__tK07zQWEe2o-K1dwNg8Gg")]
    [Description(@"Instruction rejected by the issuer agent.")]
    RejectedByIssuerAgent = RejectionReasonV3Code.RejectedByIssuerAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact information is missing.
    /// Encoded/decoded by serializers as "CTCT".
    /// </summary>
    [EnumMember(Value = "CTCT")]
    [IsoId("_Jk02gTQXEe2o-K1dwNg8Gg")]
    [Description(@"Contact information is missing.")]
    MissingContact = RejectionReasonV3Code.MissingContact, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_K1S_4jQXEe2o-K1dwNg8Gg")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_MmQAIjQXEe2o-K1dwNg8Gg")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect date is required for cover protect instructions.
    /// Encoded/decoded by serializers as "PROT".
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_OG894jQXEe2o-K1dwNg8Gg")]
    [Description(@"Protect date is required for cover protect instructions.")]
    MissingProtectDate = RejectionReasonV3Code.MissingProtectDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_S6EHkTQXEe2o-K1dwNg8Gg")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect identification is required for cover protect instructions.
    /// Encoded/decoded by serializers as "PROI".
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_UX8a0jQXEe2o-K1dwNg8Gg")]
    [Description(@"Protect identification is required for cover protect instructions.")]
    MissingProtectIdentification = RejectionReasonV3Code.MissingProtectIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction type is missing or invalid for protect or cover protect instructions.
    /// Encoded/decoded by serializers as "TRTI".
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_V1YCIjQXEe2o-K1dwNg8Gg")]
    [Description(@"Transaction type is missing or invalid for protect or cover protect instructions.")]
    MissingTransactionType = RejectionReasonV3Code.MissingTransactionType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is rejected due to duplicate business message identifier.
    /// Encoded/decoded by serializers as "DUPL".
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_XcDFAjQXEe2o-K1dwNg8Gg")]
    [Description(@"Instruction is rejected due to duplicate business message identifier.")]
    DuplicateInstruction = RejectionReasonV3Code.DuplicateInstruction, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason79CodeMetadataExtensions
{
    private static readonly RejectionReason79CodeDropdownSource _dropdownSource = new RejectionReason79CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason79CodeDropdownRow GetMetadata(this RejectionReason79Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


