﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingStatusReasonCode.  ISO2002 ID# _fBiHsGBjEeaR1OOiVxm3Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fBiHsGBjEeaR1OOiVxm3Gg")]
[Description(@"Specifies the reason for a pending status.")]
public enum PendingStatusReasonCode
{
    /// <summary>
    /// Know Your Customer (KYC) document is missing.
    /// Encoded/decoded by serializers as "KYCM".
    /// </summary>
    [EnumMember(Value = "KYCM")]
    [IsoId("_kceGYGBjEeaR1OOiVxm3Gg")]
    [Description(@"Know Your Customer (KYC) document is missing.")]
    KnowYourCustomerDocumentMissing,
    
    /// <summary>
    /// FATCA reporting date is missing.
    /// Encoded/decoded by serializers as "FRDM".
    /// </summary>
    [EnumMember(Value = "FRDM")]
    [IsoId("_kh1HgGBjEeaR1OOiVxm3Gg")]
    [Description(@"FATCA reporting date is missing.")]
    FATCAReportingDateMissing,
    
    /// <summary>
    /// Rights holder information is missing.
    /// Encoded/decoded by serializers as "RIGH".
    /// </summary>
    [EnumMember(Value = "RIGH")]
    [IsoId("_kmvcsGBjEeaR1OOiVxm3Gg")]
    [Description(@"Rights holder information is missing.")]
    RightsHolderMissing,
    
    /// <summary>
    /// Modification to the account data is in process.
    /// Encoded/decoded by serializers as "MODI".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_CXskMGCJEeabZtzjEVWYCQ")]
    [Description(@"Modification to the account data is in process.")]
    ModificationInProcess,
    
    /// <summary>
    /// Authorisation is required.
    /// Encoded/decoded by serializers as "ATHR".
    /// </summary>
    [EnumMember(Value = "ATHR")]
    [IsoId("_GOhEwGCJEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is required.")]
    Authorisation,
    
    /// <summary>
    /// Authorisation is provided but the account change is still pending.
    /// Encoded/decoded by serializers as "ATHP".
    /// </summary>
    [EnumMember(Value = "ATHP")]
    [IsoId("_IzzE8GCJEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is provided but the account change is still pending.")]
    AuthorisedButPending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingStatusReasonCodeMetadataExtensions
{
    private static readonly PendingStatusReasonCodeDropdownSource _dropdownSource = new PendingStatusReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingStatusReasonCodeDropdownRow GetMetadata(this PendingStatusReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


