﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Collateral35.  ISO2002 ID# _kyCmOf_9Eemefbt-QjTNnA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the security pledged as collateral.
/// </summary>
[IsoId("_kyCmOf_9Eemefbt-QjTNnA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Collateral")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Collateral35
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the transaction.
    /// </summary>
    [IsoId("_k2Zhwf_9Eemefbt-QjTNnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Value Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CollateralValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CollateralValueDate { get; init; } 
    #else
    public System.DateOnly? CollateralValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of the type of collateral component.
    /// </summary>
    [IsoId("_k2Zhw__9Eemefbt-QjTNnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Asset Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralType14? AssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType14? AssetType { get; init; } 
    #else
    public CollateralType14? AssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    [IsoId("_k2Zhxf_9Eemefbt-QjTNnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Exposure Collateralisation Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NetExposureCollateralisationIndicator { get; init; } 
    #else
    public System.String? NetExposureCollateralisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the collateral basket.
    /// </summary>
    [IsoId("_k2Zhx__9Eemefbt-QjTNnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Basket Identifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
    #else
    public SecurityIdentification26Choice_? BasketIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
