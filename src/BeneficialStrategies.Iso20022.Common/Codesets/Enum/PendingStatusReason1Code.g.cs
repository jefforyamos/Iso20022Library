﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingStatusReason1Code.  ISO2002 ID# _-nYUEGBjEeaR1OOiVxm3Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-nYUEGBjEeaR1OOiVxm3Gg")]
[Description(@"Specifies the reason for a pending status.")]
[DerivedFrom(typeof(PendingStatusReasonCode))]
public enum PendingStatusReason1Code
{
    /// <summary>
    /// Know Your Customer (KYC) document is missing.
    /// Encoded/decoded by serializers as "KYCM".
    /// </summary>
    [EnumMember(Value = "KYCM")]
    [IsoId("_A7j9MWBkEeaR1OOiVxm3Gg")]
    [Description(@"Know Your Customer (KYC) document is missing.")]
    KnowYourCustomerDocumentMissing = PendingStatusReasonCode.KnowYourCustomerDocumentMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// FATCA reporting date is missing.
    /// Encoded/decoded by serializers as "FRDM".
    /// </summary>
    [EnumMember(Value = "FRDM")]
    [IsoId("_BLoZgWBkEeaR1OOiVxm3Gg")]
    [Description(@"FATCA reporting date is missing.")]
    FATCAReportingDateMissing = PendingStatusReasonCode.FATCAReportingDateMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights holder information is missing.
    /// Encoded/decoded by serializers as "RIGH".
    /// </summary>
    [EnumMember(Value = "RIGH")]
    [IsoId("_BXiHgWBkEeaR1OOiVxm3Gg")]
    [Description(@"Rights holder information is missing.")]
    RightsHolderMissing = PendingStatusReasonCode.RightsHolderMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authorisation is required.
    /// Encoded/decoded by serializers as "ATHR".
    /// </summary>
    [EnumMember(Value = "ATHR")]
    [IsoId("_P9cBIWCJEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is required.")]
    Authorisation = PendingStatusReasonCode.Authorisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authorisation is provided but the account change is still pending.
    /// Encoded/decoded by serializers as "ATHP".
    /// </summary>
    [EnumMember(Value = "ATHP")]
    [IsoId("_QHG6gWCJEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is provided but the account change is still pending.")]
    AuthorisedButPending = PendingStatusReasonCode.AuthorisedButPending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Modification to the account data is in process.
    /// Encoded/decoded by serializers as "MODI".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_QVFsIWCJEeabZtzjEVWYCQ")]
    [Description(@"Modification to the account data is in process.")]
    ModificationInProcess = PendingStatusReasonCode.ModificationInProcess, // same ordinal as derivation source for type conversions
    
}
