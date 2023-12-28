﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason50Code.  ISO2002 ID# _frUwsLKxEemDyeh7tbvg1w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason why the instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_frUwsLKxEemDyeh7tbvg1w")]
[Description(@"Specifies a reason why the instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason50Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_jnMwYLKxEemDyeh7tbvg1w")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Requested additional documentation is missing. 
    /// Encoded/decoded by serializers as "AdditionalDocumentationMissing".
    /// </summary>
    [EnumMember(Value = "ADDM")]
    [IsoId("_kLM1UbKxEemDyeh7tbvg1w")]
    [Description(@"Requested additional documentation is missing. ")]
    AdditionalDocumentationMissing,
    
    /// <summary>
    /// Event has been cancelled.
    /// Encoded/decoded by serializers as "EventCancelled".
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("__7IgEbKxEemDyeh7tbvg1w")]
    [Description(@"Event has been cancelled.")]
    EventCancelled,
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_CnQvIbKyEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,
    
    /// <summary>
    /// Deadline to register is missed.
    /// Encoded/decoded by serializers as "DeadlineToRegisterMissed".
    /// </summary>
    [EnumMember(Value = "DREM")]
    [IsoId("_TNN0wbKyEemDyeh7tbvg1w")]
    [Description(@"Deadline to register is missed.")]
    DeadlineToRegisterMissed,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_XMg74bKyEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "UnrecognisedIdentification".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_Yhd8obKyEemDyeh7tbvg1w")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification,
    
    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as "MissingBeneficiaryOwnerDetails".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_ay-FMbKyEemDyeh7tbvg1w")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails,
    
    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as "MissingOrInvalidPOA".
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_jm1HgbKyEemDyeh7tbvg1w")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA,
    
    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as "InsufficientThresholdPosition".
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_nC3JgbKyEemDyeh7tbvg1w")]
    [Description(@"Position is less than required threshold.")]
    InsufficientThresholdPosition,
    
    /// <summary>
    /// Invalid registration information.
    /// Encoded/decoded by serializers as "RegistrationDiscrepancy".
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_o-Wl0bKyEemDyeh7tbvg1w")]
    [Description(@"Invalid registration information.")]
    RegistrationDiscrepancy,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_sPhbobKyEemDyeh7tbvg1w")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Insufficient or no registered position.
    /// Encoded/decoded by serializers as "NoRegisteredPosition".
    /// </summary>
    [EnumMember(Value = "NPOS")]
    [IsoId("_Fooo4bLHEemDyeh7tbvg1w")]
    [Description(@"Insufficient or no registered position.")]
    NoRegisteredPosition,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Im6X4bLHEemDyeh7tbvg1w")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as "PartialVoteNotAllowed".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_LNib4bLHEemDyeh7tbvg1w")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed,
    
    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as "ProxyCardDiscrepancy".
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_OtAMYbLHEemDyeh7tbvg1w")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy,
    
    /// <summary>
    /// Issuer or registrar has rejected the instruction.
    /// Encoded/decoded by serializers as "RejectedByIssuerOrRegistrar".
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_QftgIbLHEemDyeh7tbvg1w")]
    [Description(@"Issuer or registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar,
    
    /// <summary>
    /// Resolution number provided discrepancy.
    /// Encoded/decoded by serializers as "ResolutionNumberDiscrepancy".
    /// </summary>
    [EnumMember(Value = "RESN")]
    [IsoId("_gxbbIbLHEemDyeh7tbvg1w")]
    [Description(@"Resolution number provided discrepancy.")]
    ResolutionNumberDiscrepancy,
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_if-AkbLHEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as "SplitVoteNotAllowed".
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_kJAa8bLHEemDyeh7tbvg1w")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed,
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_mM92wbLHEemDyeh7tbvg1w")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference,
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "InvalidOptionType".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_uAQz8bLHEemDyeh7tbvg1w")]
    [Description(@"Invalid option type.")]
    InvalidOptionType,
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as "LackofSecurities".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_KZ1cIcjCEem7mOT-LZ2mYQ")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason50CodeMetadataExtensions
{
    private static readonly RejectionReason50CodeDropdownSource _dropdownSource = new RejectionReason50CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason50CodeDropdownRow GetMetadata(this RejectionReason50Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


