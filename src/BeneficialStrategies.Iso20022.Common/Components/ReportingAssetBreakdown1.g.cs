﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportingAssetBreakdown1.  ISO2002 ID# _J02CgDWzEemdWfjs3tykFQ.
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
/// Specifies the breakdown of a reported amount that can be split across a range of assets: bonds, cash, equities, or another asset class.
/// </summary>
[IsoId("_J02CgDWzEemdWfjs3tykFQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Reporting Asset Breakdown")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportingAssetBreakdown1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportingAssetBreakdown1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportingAssetBreakdown1( ProductType6Code reqReportingAssetType,System.Decimal reqAmount )
    {
        ReportingAssetType = reqReportingAssetType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Class of the asset which is a component of the breakdown.
    /// </summary>
    [IsoId("_f9yPkDWzEemdWfjs3tykFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reporting Asset Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProductType6Code ReportingAssetType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ProductType6Code ReportingAssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductType6Code ReportingAssetType { get; init; } 
    #else
    public ProductType6Code ReportingAssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the reporting asset.
    /// </summary>
    [IsoId("_xu3rkDWzEemdWfjs3tykFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the reporting asset.
    /// </summary>
    [IsoId("_9bzMwDWzEemdWfjs3tykFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
