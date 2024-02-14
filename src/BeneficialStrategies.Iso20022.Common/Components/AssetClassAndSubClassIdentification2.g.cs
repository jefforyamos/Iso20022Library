﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AssetClassAndSubClassIdentification2.  ISO2002 ID# _b_iE8aaUEeqZmriXpMtonA.
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
/// Identification of a non-equity asset-class and sub-class.
/// </summary>
[IsoId("_b_iE8aaUEeqZmriXpMtonA")]
[DisplayName("Asset Class And Sub Class Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AssetClassAndSubClassIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AssetClassAndSubClassIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AssetClassAndSubClassIdentification2( NonEquityAssetClass1Code reqAssetClass )
    {
        AssetClass = reqAssetClass;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Asset class of non-equity instruments to which the result relates
    /// </summary>
    [IsoId("_cBU0saaUEeqZmriXpMtonA")]
    [DisplayName("Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstClss")]
    #endif
    [IsoXmlTag("AsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NonEquityAssetClass1Code AssetClass { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NonEquityAssetClass1Code AssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonEquityAssetClass1Code AssetClass { get; init; } 
    #else
    public NonEquityAssetClass1Code AssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Sub class of non-equity instruments to which the result relates, as defined in the local regulation.
    /// </summary>
    [IsoId("_cBU0s6aUEeqZmriXpMtonA")]
    [DisplayName("Derivative Sub Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivSubClss")]
    #endif
    [IsoXmlTag("DerivSubClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonEquitySubClass1? DerivativeSubClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonEquitySubClass1? DerivativeSubClass { get; init; } 
    #else
    public NonEquitySubClass1? DerivativeSubClass { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of non-equity financial instruments.
    /// </summary>
    [IsoId("_cBU0taaUEeqZmriXpMtonA")]
    [DisplayName("Financial Instrument Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmClssfctn")]
    #endif
    [IsoXmlTag("FinInstrmClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
    #else
    public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
