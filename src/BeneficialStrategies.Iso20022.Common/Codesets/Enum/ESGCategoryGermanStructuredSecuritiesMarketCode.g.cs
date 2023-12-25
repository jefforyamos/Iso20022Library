﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ESGCategoryGermanStructuredSecuritiesMarketCode.  ISO2002 ID# _qiEvsM2tEeuAE-cYsQdwHQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of structured securities product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qiEvsM2tEeuAE-cYsQdwHQ")]
[Description(@"Specifies the category of structured securities product.")]
public enum ESGCategoryGermanStructuredSecuritiesMarketCode
{
    /// <summary>
    /// Netural or has no impact.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_ysRxAM2tEeuAE-cYsQdwHQ")]
    [Description(@"Netural or has no impact.")]
    NEUT,
    
    /// <summary>
    /// Product manufacturer follows environmental, social and corporate governance (ESG) product and transparency standard.
    /// </summary>
    [EnumMember(Value = "BASS")]
    [IsoId("_4WMm4M2tEeuAE-cYsQdwHQ")]
    [Description(@"Product manufacturer follows environmental, social and corporate governance (ESG) product and transparency standard.")]
    BASS,
    
    /// <summary>
    /// Product manufacturer attains at least with one rating agency the status of a sustainable company.
    /// </summary>
    [EnumMember(Value = "ESGS")]
    [IsoId("_AdHDoM2uEeuAE-cYsQdwHQ")]
    [Description(@"Product manufacturer attains at least with one rating agency the status of a sustainable company.")]
    ESGS,
    
    /// <summary>
    /// Impact-related bond according to recognised market standards (for example, Green/Social Bond Principles, EU Green Bond Standards).
    /// </summary>
    [EnumMember(Value = "IMPS")]
    [IsoId("_GGaOcM2uEeuAE-cYsQdwHQ")]
    [Description(@"Impact-related bond according to recognised market standards (for example, Green/Social Bond Principles, EU Green Bond Standards).")]
    IMPS,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ESGCategoryGermanStructuredSecuritiesMarketCodeMetadataExtensions
{
    private static readonly ESGCategoryGermanStructuredSecuritiesMarketCodeDropdownSource _dropdownSource = new ESGCategoryGermanStructuredSecuritiesMarketCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IESGCategoryGermanStructuredSecuritiesMarketCodeDropdownRow GetMetadata(this ESGCategoryGermanStructuredSecuritiesMarketCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


