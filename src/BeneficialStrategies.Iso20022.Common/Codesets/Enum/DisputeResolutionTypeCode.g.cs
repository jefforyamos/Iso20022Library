﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DisputeResolutionTypeCode.  ISO2002 ID# _YcpaMdp-Ed-ak6NoX_4Aeg_-46223766.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the disputed collateral amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcpaMdp-Ed-ak6NoX_4Aeg_-46223766")]
[Description(@"Specifies the nature of the disputed collateral amount.")]
public enum DisputeResolutionTypeCode
{
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_YcpaMtp-Ed-ak6NoX_4Aeg_1891365341")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.")]
    RECO,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the exposure.
    /// </summary>
    [EnumMember(Value = "REEX")]
    [IsoId("_YcpaM9p-Ed-ak6NoX_4Aeg_-1059799862")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the exposure.")]
    REEX,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the threshold.
    /// </summary>
    [EnumMember(Value = "RETH")]
    [IsoId("_YcpaNNp-Ed-ak6NoX_4Aeg_1805713356")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the threshold.")]
    RETH,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.
    /// </summary>
    [EnumMember(Value = "RMTA")]
    [IsoId("_YcpaNdp-Ed-ak6NoX_4Aeg_-861205465")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.")]
    RMTA,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.
    /// </summary>
    [EnumMember(Value = "RERO")]
    [IsoId("_YcpaNtp-Ed-ak6NoX_4Aeg_-266492912")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.")]
    RERO,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.
    /// </summary>
    [EnumMember(Value = "REVF")]
    [IsoId("_YcpaN9p-Ed-ak6NoX_4Aeg_-1878503321")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.")]
    REVF,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the independent amount.
    /// </summary>
    [EnumMember(Value = "RNIA")]
    [IsoId("_YcpaONp-Ed-ak6NoX_4Aeg_1220861070")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the independent amount.")]
    RNIA,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the initial margin.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_YcpaOdp-Ed-ak6NoX_4Aeg_-1592735375")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the initial margin.")]
    RESA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DisputeResolutionTypeCodeMetadataExtensions
{
    private static readonly DisputeResolutionTypeCodeDropdownSource _dropdownSource = new DisputeResolutionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDisputeResolutionTypeCodeDropdownRow GetMetadata(this DisputeResolutionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


