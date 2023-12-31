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
[Derivations(typeof(ESGCategoryGermanStructuredSecuritiesMarket1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ESGCategoryGermanStructuredSecuritiesMarketCode
{
    /// <summary>
    /// Netural or has no impact.
    /// Encoded/decoded by serializers as "NEUT".
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_ysRxAM2tEeuAE-cYsQdwHQ")]
    [Description(@"Netural or has no impact.")]
    Neutral,
    
    /// <summary>
    /// Product manufacturer follows environmental, social and corporate governance (ESG) product and transparency standard.
    /// Encoded/decoded by serializers as "BASS".
    /// </summary>
    [EnumMember(Value = "BASS")]
    [IsoId("_4WMm4M2tEeuAE-cYsQdwHQ")]
    [Description(@"Product manufacturer follows environmental, social and corporate governance (ESG) product and transparency standard.")]
    BasicCategorySS,
    
    /// <summary>
    /// Product manufacturer attains at least with one rating agency the status of a sustainable company.
    /// Encoded/decoded by serializers as "ESGS".
    /// </summary>
    [EnumMember(Value = "ESGS")]
    [IsoId("_AdHDoM2uEeuAE-cYsQdwHQ")]
    [Description(@"Product manufacturer attains at least with one rating agency the status of a sustainable company.")]
    ESGStrategySS,
    
    /// <summary>
    /// Impact-related bond according to recognised market standards (for example, Green/Social Bond Principles, EU Green Bond Standards).
    /// Encoded/decoded by serializers as "IMPS".
    /// </summary>
    [EnumMember(Value = "IMPS")]
    [IsoId("_GGaOcM2uEeuAE-cYsQdwHQ")]
    [Description(@"Impact-related bond according to recognised market standards (for example, Green/Social Bond Principles, EU Green Bond Standards).")]
    ImpactSS,
    
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


