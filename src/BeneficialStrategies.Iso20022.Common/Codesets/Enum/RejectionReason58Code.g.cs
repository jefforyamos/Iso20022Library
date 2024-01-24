﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason58Code.  ISO2002 ID# _2RoNIfNeEeqRfth943bvEA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason why the instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2RoNIfNeEeqRfth943bvEA")]
[Description(@"Specifies a reason why the instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason58Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_2lar0fNeEeqRfth943bvEA")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested additional documentation is missing. 
    /// Encoded/decoded by serializers as "ADDM".
    /// </summary>
    [EnumMember(Value = "ADDM")]
    [IsoId("_2lar0_NeEeqRfth943bvEA")]
    [Description(@"Requested additional documentation is missing. ")]
    AdditionalDocumentationMissing = RejectionReasonV3Code.AdditionalDocumentationMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event has been cancelled.
    /// Encoded/decoded by serializers as "MCAN".
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("_2lar1fNeEeqRfth943bvEA")]
    [Description(@"Event has been cancelled.")]
    EventCancelled = RejectionReasonV3Code.EventCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_2lar1_NeEeqRfth943bvEA")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deadline to register is missed.
    /// Encoded/decoded by serializers as "DREM".
    /// </summary>
    [EnumMember(Value = "DREM")]
    [IsoId("_2lar2fNeEeqRfth943bvEA")]
    [Description(@"Deadline to register is missed.")]
    DeadlineToRegisterMissed = RejectionReasonV3Code.DeadlineToRegisterMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_2lar2_NeEeqRfth943bvEA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "EVNM".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_2lar3fNeEeqRfth943bvEA")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_2lar3_NeEeqRfth943bvEA")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails = RejectionReasonV3Code.MissingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as "IPOA".
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_2lar4fNeEeqRfth943bvEA")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA = RejectionReasonV3Code.MissingOrInvalidPOA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as "IPOS".
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_2lar4_NeEeqRfth943bvEA")]
    [Description(@"Position is less than required threshold.")]
    InsufficientThresholdPosition = RejectionReasonV3Code.InsufficientThresholdPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid registration information.
    /// Encoded/decoded by serializers as "IREG".
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_2lar5fNeEeqRfth943bvEA")]
    [Description(@"Invalid registration information.")]
    RegistrationDiscrepancy = RejectionReasonV3Code.RegistrationDiscrepancy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_2lar5_NeEeqRfth943bvEA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient or no registered position.
    /// Encoded/decoded by serializers as "NPOS".
    /// </summary>
    [EnumMember(Value = "NPOS")]
    [IsoId("_2lar6fNeEeqRfth943bvEA")]
    [Description(@"Insufficient or no registered position.")]
    NoRegisteredPosition = RejectionReasonV3Code.NoRegisteredPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_2lar6_NeEeqRfth943bvEA")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_2lar7fNeEeqRfth943bvEA")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed = RejectionReasonV3Code.PartialVoteNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as "PRXY".
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_2lar7_NeEeqRfth943bvEA")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy = RejectionReasonV3Code.ProxyCardDiscrepancy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer or registrar has rejected the instruction.
    /// Encoded/decoded by serializers as "RBIS".
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_2lar8fNeEeqRfth943bvEA")]
    [Description(@"Issuer or registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar = RejectionReasonV3Code.RejectedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Resolution number provided discrepancy.
    /// Encoded/decoded by serializers as "RESN".
    /// </summary>
    [EnumMember(Value = "RESN")]
    [IsoId("_2lar8_NeEeqRfth943bvEA")]
    [Description(@"Resolution number provided discrepancy.")]
    ResolutionNumberDiscrepancy = RejectionReasonV3Code.ResolutionNumberDiscrepancy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_2lar9fNeEeqRfth943bvEA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as "SPLT".
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_2lar9_NeEeqRfth943bvEA")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed = RejectionReasonV3Code.SplitVoteNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "ULNK".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_2lar-fNeEeqRfth943bvEA")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "OPTY".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_2lar-_NeEeqRfth943bvEA")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV3Code.InvalidOptionType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as "LACK".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_2lar_fNeEeqRfth943bvEA")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV3Code.LackofSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is invalid due to multiple resolutions instructed as vote "For” and belonging to the same listing group resolution label number.
    /// Encoded/decoded by serializers as "LIST".
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("_RRVU0fNfEeqRfth943bvEA")]
    [Description(@"Instruction is invalid due to multiple resolutions instructed as vote ""For” and belonging to the same listing group resolution label number.")]
    InvalidVoteInFavourInGroupListing = RejectionReasonV3Code.InvalidVoteInFavourInGroupListing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid instruction as the shareholder or its delegate is not registered in the company stock ledger book.
    /// Encoded/decoded by serializers as "NOSL".
    /// </summary>
    [EnumMember(Value = "NOSL")]
    [IsoId("_ELdjYfNiEeqRfth943bvEA")]
    [Description(@"Invalid instruction as the shareholder or its delegate is not registered in the company stock ledger book.")]
    NotRegisteredInInStockLedger = RejectionReasonV3Code.NotRegisteredInInStockLedger, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason58CodeMetadataExtensions
{
    private static readonly RejectionReason58CodeDropdownSource _dropdownSource = new RejectionReason58CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason58CodeDropdownRow GetMetadata(this RejectionReason58Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


