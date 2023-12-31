﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestorProfileStatusCode.  ISO2002 ID# _1CAzICDOEeWPMvNwVtiMsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the investor profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1CAzICDOEeWPMvNwVtiMsA")]
[Description(@"Specifies the status of the investor profile.")]
[Derivations(typeof(InvestorProfileStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum InvestorProfileStatusCode
{
    /// <summary>
    /// Status of the investor profile is in analysis.
    /// Encoded/decoded by serializers as "ANLY".
    /// </summary>
    [EnumMember(Value = "ANLY")]
    [IsoId("_ibDNICDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in analysis.")]
    InAnalysis,
    
    /// <summary>
    /// Status of the investor profile is pending approval.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_r8u-wCDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is pending approval.")]
    PendingApproval,
    
    /// <summary>
    /// Status of the investor profile is not approved.
    /// Encoded/decoded by serializers as "NAPP".
    /// </summary>
    [EnumMember(Value = "NAPP")]
    [IsoId("_xjS-oCDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is not approved.")]
    NotApproved,
    
    /// <summary>
    /// Status of the investor profile is in admission.
    /// Encoded/decoded by serializers as "ADMI".
    /// </summary>
    [EnumMember(Value = "ADMI")]
    [IsoId("_2_lBICDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in admission.")]
    InAdmission,
    
    /// <summary>
    /// Status of the investor profile is in the process of being enabled.
    /// Encoded/decoded by serializers as "ENBG".
    /// </summary>
    [EnumMember(Value = "ENBG")]
    [IsoId("_7Rx2ICDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in the process of being enabled.")]
    Enabling,
    
    /// <summary>
    /// Status of the investor profile is enabled.
    /// Encoded/decoded by serializers as "ENAB".
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_-6UqICDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is enabled.")]
    Enabled,
    
    /// <summary>
    /// Status of the investor profile is partially suspended.
    /// Encoded/decoded by serializers as "PSUS".
    /// </summary>
    [EnumMember(Value = "PSUS")]
    [IsoId("_Fkk7oCDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is partially suspended.")]
    PartiallySuspended,
    
    /// <summary>
    /// Status of the investor profile is suspended.
    /// Encoded/decoded by serializers as "SUPS".
    /// </summary>
    [EnumMember(Value = "SUPS")]
    [IsoId("_JiF6ECDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is suspended.")]
    Suspended,
    
    /// <summary>
    /// Status of the investor profile is in the process of being disabled.
    /// Encoded/decoded by serializers as "DISG".
    /// </summary>
    [EnumMember(Value = "DISG")]
    [IsoId("_NgzLUCDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in the process of being disabled.")]
    Disabling,
    
    /// <summary>
    /// Status of the investor profile is disabled.
    /// Encoded/decoded by serializers as "DISA".
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_jjAeQCDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is disabled.")]
    Disabled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestorProfileStatusCodeMetadataExtensions
{
    private static readonly InvestorProfileStatusCodeDropdownSource _dropdownSource = new InvestorProfileStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestorProfileStatusCodeDropdownRow GetMetadata(this InvestorProfileStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


