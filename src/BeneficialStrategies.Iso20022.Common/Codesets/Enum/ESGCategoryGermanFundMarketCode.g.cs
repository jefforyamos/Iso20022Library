﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ESGCategoryGermanFundMarketCode.  ISO2002 ID# _hih3QM2sEeuAE-cYsQdwHQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of fund product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hih3QM2sEeuAE-cYsQdwHQ")]
[Description(@"Specifies the category of fund product.")]
[Derivations(typeof(ESGCategoryGermanFundMarket1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ESGCategoryGermanFundMarketCode
{
    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as "NEUT".
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_mxEYsM2sEeuAE-cYsQdwHQ")]
    [Description(@"Neutral or has no impact.")]
    Neutral,
    
    /// <summary>
    /// Product having environmental, social and corporate governance (ESG) characteristics, opportunities or risks according to the "ESG integration enhanced" criteria.
    /// Product integration approach is disclosed and the product manager follows a recognised industry standard (UN PRI).
    /// Encoded/decoded by serializers as "BASF".
    /// </summary>
    [EnumMember(Value = "BASF")]
    [IsoId("_q7RvUM2sEeuAE-cYsQdwHQ")]
    [Description(@"Product having environmental, social and corporate governance (ESG) characteristics, opportunities or risks according to the ""ESG integration enhanced"" criteria. Product integration approach is disclosed and the product manager follows a recognised industry standard (UN PRI).")]
    BasicCategory,
    
    /// <summary>
    /// Product with a dedicated environmental, social and corporate governance (ESG) strategy (pursuant to Article 8 Disclosure Regulation).
    /// Encoded/decoded by serializers as "ESGF".
    /// </summary>
    [EnumMember(Value = "ESGF")]
    [IsoId("_vk3woM2sEeuAE-cYsQdwHQ")]
    [Description(@"Product with a dedicated environmental, social and corporate governance (ESG) strategy (pursuant to Article 8 Disclosure Regulation).")]
    ESGStrategy,
    
    /// <summary>
    /// Product with impact-related investment (pursuant to Article 9 Disclosure Regulation):
    /// - No serious breach of the United Nations Global Compact (UNGC);
    /// - Relevant for both individual products and those in a portfolio/basket (shares/bonds);
    /// - Product manager follows a recognised industry standard (UN PRI).
    /// Encoded/decoded by serializers as "IMPF".
    /// </summary>
    [EnumMember(Value = "IMPF")]
    [IsoId("_0MKr4M2sEeuAE-cYsQdwHQ")]
    [Description(@"Product with impact-related investment (pursuant to Article 9 Disclosure Regulation): - No serious breach of the United Nations Global Compact (UNGC); - Relevant for both individual products and those in a portfolio/basket (shares/bonds); - Product manager follows a recognised industry standard (UN PRI).")]
    Impact,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ESGCategoryGermanFundMarketCodeMetadataExtensions
{
    private static readonly ESGCategoryGermanFundMarketCodeDropdownSource _dropdownSource = new ESGCategoryGermanFundMarketCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IESGCategoryGermanFundMarketCodeDropdownRow GetMetadata(this ESGCategoryGermanFundMarketCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


