﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestorProfileStatus1Code.  ISO2002 ID# _t6X6sCDREeWCLu74WLgP4w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the investor profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t6X6sCDREeWCLu74WLgP4w")]
[Description(@"Specifies the status of the investor profile.")]
[DerivedFrom(typeof(InvestorProfileStatusCode))]
public enum InvestorProfileStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Disabled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vl8EoSDREeWCLu74WLgP4w")]
    [Description(@"??")]
    Disabled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Disabling".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vt9_QSDREeWCLu74WLgP4w")]
    [Description(@"??")]
    Disabling,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Enabled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_v2cl0SDREeWCLu74WLgP4w")]
    [Description(@"??")]
    Enabled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Enabling".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_v-yCcSDREeWCLu74WLgP4w")]
    [Description(@"??")]
    Enabling,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InAdmission".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wBms8SDREeWCLu74WLgP4w")]
    [Description(@"??")]
    InAdmission,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InAnalysis".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wJ8JkSDREeWCLu74WLgP4w")]
    [Description(@"??")]
    InAnalysis,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotApproved".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wTBNESDREeWCLu74WLgP4w")]
    [Description(@"??")]
    NotApproved,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallySuspended".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wV13kSDREeWCLu74WLgP4w")]
    [Description(@"??")]
    PartiallySuspended,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingApproval".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wd3yMSDREeWCLu74WLgP4w")]
    [Description(@"??")]
    PendingApproval,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Suspended".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wl6T4SDREeWCLu74WLgP4w")]
    [Description(@"??")]
    Suspended,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestorProfileStatus1CodeMetadataExtensions
{
    private static readonly InvestorProfileStatus1CodeDropdownSource _dropdownSource = new InvestorProfileStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestorProfileStatus1CodeDropdownRow GetMetadata(this InvestorProfileStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

