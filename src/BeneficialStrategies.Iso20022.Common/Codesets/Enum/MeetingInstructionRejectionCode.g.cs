﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MeetingInstructionRejectionCode.  ISO2002 ID# _VpFtddp-Ed-ak6NoX_4Aeg_-315431614.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the possible rejection reasons.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpFtddp-Ed-ak6NoX_4Aeg_-315431614")]
[Description(@"Identifies the possible rejection reasons.")]
[Derivations(typeof(MeetingInstructionRejection1Code))]
// External derivations that should be provided by the proper interface are: 
public enum MeetingInstructionRejectionCode
{
    /// <summary>
    /// Instruction contains an invalid meeting reference.
    /// Encoded/decoded by serializers as "INMR".
    /// </summary>
    [EnumMember(Value = "INMR")]
    [IsoId("_VpFtdtp-Ed-ak6NoX_4Aeg_-1691416163")]
    [Description(@"Instruction contains an invalid meeting reference.")]
    InvalidMeetingReference,
    
    /// <summary>
    /// Instruction contains an invalid account identification.
    /// Encoded/decoded by serializers as "INAC".
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_VpFtd9p-Ed-ak6NoX_4Aeg_-1204717743")]
    [Description(@"Instruction contains an invalid account identification.")]
    InvalidAccount,
    
    /// <summary>
    /// Position is less than required threshold to be allowed to vote.
    /// Encoded/decoded by serializers as "IPOS".
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_VpFteNp-Ed-ak6NoX_4Aeg_787992222")]
    [Description(@"Position is less than required threshold to be allowed to vote.")]
    InsufficientSecurityPosition,
    
    /// <summary>
    /// Instruction contains an invalid instructed quantity (eg the instructed quantity is greater than the entitlement).
    /// Encoded/decoded by serializers as "INQY".
    /// </summary>
    [EnumMember(Value = "INQY")]
    [IsoId("_VpFtedp-Ed-ak6NoX_4Aeg_-1119755804")]
    [Description(@"Instruction contains an invalid instructed quantity (eg the instructed quantity is greater than the entitlement).")]
    InvalidInstructedQuantity,
    
    /// <summary>
    /// Instruction received after the specified deadline.
    /// Encoded/decoded by serializers as "INDT".
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_VpPecNp-Ed-ak6NoX_4Aeg_-573954333")]
    [Description(@"Instruction received after the specified deadline.")]
    InvalidDate,
    
    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as "SPLT".
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_VpPecdp-Ed-ak6NoX_4Aeg_913141247")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed,
    
    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_VpPectp-Ed-ak6NoX_4Aeg_1239143520")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed,
    
    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as "IPOA".
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_VpPec9p-Ed-ak6NoX_4Aeg_-1808147630")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA,
    
    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as "PRXY".
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_VpPedNp-Ed-ak6NoX_4Aeg_1784019512")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy,
    
    /// <summary>
    /// Invalid re-registration information.
    /// Encoded/decoded by serializers as "IREG".
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_VpPeddp-Ed-ak6NoX_4Aeg_-1666850052")]
    [Description(@"Invalid re-registration information.")]
    ReRegistrationDiscrepancy,
    
    /// <summary>
    /// Issuer has rejected the instruction.
    /// Encoded/decoded by serializers as "RBIS".
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_VpPedtp-Ed-ak6NoX_4Aeg_394462746")]
    [Description(@"Issuer has rejected the instruction.")]
    RejectedByIssuer,
    
    /// <summary>
    /// Other errors.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VpPed9p-Ed-ak6NoX_4Aeg_-2127686918")]
    [Description(@"Other errors.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MeetingInstructionRejectionCodeMetadataExtensions
{
    private static readonly MeetingInstructionRejectionCodeDropdownSource _dropdownSource = new MeetingInstructionRejectionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMeetingInstructionRejectionCodeDropdownRow GetMetadata(this MeetingInstructionRejectionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


