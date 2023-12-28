﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason65Code.  ISO2002 ID# _Dmq4uhrpEeyhRdHRjakS2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason why the instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Dmq4uhrpEeyhRdHRjakS2w")]
[Description(@"Specifies a reason why the instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason65Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq40hrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AdditionalDocumentationMissing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4zBrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    AdditionalDocumentationMissing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EventCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq40BrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    EventCancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4vBrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    QuantityRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeadlineToRegisterMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4vxrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    DeadlineToRegisterMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4vRrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    InvalidSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnrecognisedIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4zRrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    UnrecognisedIdentification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingBeneficiaryOwnerDetails".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4vhrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    MissingBeneficiaryOwnerDetails,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingOrInvalidPOA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4xhrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    MissingOrInvalidPOA,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsufficientThresholdPosition".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4yRrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    InsufficientThresholdPosition,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegistrationDiscrepancy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4zhrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    RegistrationDiscrepancy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq40xrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoRegisteredPosition".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4yhrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    NoRegisteredPosition,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4zxrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartialVoteNotAllowed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4yxrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    PartialVoteNotAllowed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProxyCardDiscrepancy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4whrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    ProxyCardDiscrepancy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedByIssuerOrRegistrar".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4xBrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    RejectedByIssuerOrRegistrar,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ResolutionNumberDiscrepancy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4wBrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    ResolutionNumberDiscrepancy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq40RrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SplitVoteNotAllowed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4wRrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    SplitVoteNotAllowed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4xRrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    InvalidReference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidOptionType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4uxrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    InvalidOptionType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackofSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4wxrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    LackofSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidVoteInFavourInGroupListing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4xxrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    InvalidVoteInFavourInGroupListing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotRegisteredInInStockLedger".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dmq4yBrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    NotRegisteredInInStockLedger,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ParticipationMethodNotSupported".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_V7QDQRrpEeyhRdHRjakS2w")]
    [Description(@"??")]
    ParticipationMethodNotSupported,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason65CodeMetadataExtensions
{
    private static readonly RejectionReason65CodeDropdownSource _dropdownSource = new RejectionReason65CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason65CodeDropdownRow GetMetadata(this RejectionReason65Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

