﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DisabledReason2Code.  ISO2002 ID# __tcgEGBqEeaHEJD5P6-ccw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason an account is disabled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__tcgEGBqEeaHEJD5P6-ccw")]
[Description(@"Specifies the reason an account is disabled.")]
[DerivedFrom(typeof(BlockedReasonCode))]
public enum DisabledReason2Code
{
    /// <summary>
    /// Account closing is in process.
    /// Encoded/decoded by serializers as "CLOS".
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_EtddUWBrEeaHEJD5P6-ccw")]
    [Description(@"Account closing is in process.")]
    AccountClosingInProcess = BlockedReasonCode.AccountClosingInProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bankruptcy.
    /// Encoded/decoded by serializers as "BKRP".
    /// </summary>
    [EnumMember(Value = "BKRP")]
    [IsoId("_Ex7GkWBrEeaHEJD5P6-ccw")]
    [Description(@"Bankruptcy.")]
    Bankruptcy = BlockedReasonCode.Bankruptcy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commitment.
    /// Encoded/decoded by serializers as "CMMT".
    /// </summary>
    [EnumMember(Value = "CMMT")]
    [IsoId("_E3bRoWBrEeaHEJD5P6-ccw")]
    [Description(@"Commitment.")]
    Commitment = BlockedReasonCode.Commitment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Confiscation.
    /// Encoded/decoded by serializers as "CNFS".
    /// </summary>
    [EnumMember(Value = "CNFS")]
    [IsoId("_E8ySwWBrEeaHEJD5P6-ccw")]
    [Description(@"Confiscation.")]
    Confiscation = BlockedReasonCode.Confiscation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reserved in contemplation of death.
    /// Encoded/decoded by serializers as "MORT".
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_FBi28WBrEeaHEJD5P6-ccw")]
    [Description(@"Reserved in contemplation of death.")]
    MortisCausa = BlockedReasonCode.MortisCausa, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending compliance verification.
    /// Encoded/decoded by serializers as "PCOM".
    /// </summary>
    [EnumMember(Value = "PCOM")]
    [IsoId("_FGdMIWBrEeaHEJD5P6-ccw")]
    [Description(@"Pending compliance verification.")]
    PendingComplianceVerification = BlockedReasonCode.PendingComplianceVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pledged.
    /// Encoded/decoded by serializers as "PLDG".
    /// </summary>
    [EnumMember(Value = "PLDG")]
    [IsoId("_FMHIMWBrEeaHEJD5P6-ccw")]
    [Description(@"Pledged.")]
    Pledged = BlockedReasonCode.Pledged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reregistration.
    /// Encoded/decoded by serializers as "TRPE".
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_FSW6IWBrEeaHEJD5P6-ccw")]
    [Description(@"Reregistration.")]
    Reregistration = BlockedReasonCode.Reregistration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sanctions are in place.
    /// Encoded/decoded by serializers as "SANC".
    /// </summary>
    [EnumMember(Value = "SANC")]
    [IsoId("_FW-UYWBrEeaHEJD5P6-ccw")]
    [Description(@"Sanctions are in place.")]
    Sanctions = BlockedReasonCode.Sanctions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_FbSMoWBrEeaHEJD5P6-ccw")]
    [Description(@"Transfer.")]
    Transfer = BlockedReasonCode.Transfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account was pending opening but is now rejected.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_voHfoWCIEeabZtzjEVWYCQ")]
    [Description(@"Account was pending opening but is now rejected.")]
    Rejected = BlockedReasonCode.Rejected, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DisabledReason2CodeMetadataExtensions
{
    private static readonly DisabledReason2CodeDropdownSource _dropdownSource = new DisabledReason2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDisabledReason2CodeDropdownRow GetMetadata(this DisabledReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


