﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FleetLineItem2.  ISO2002 ID# _rPO3If5nEeiLerArw36g0w.
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
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[IsoId("_rPO3If5nEeiLerArw36g0w")]
[DisplayName("Fleet Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FleetLineItem2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FleetLineItem2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FleetLineItem2( FleetPurchaseType1Code reqFuelIndicator )
    {
        FuelIndicator = reqFuelIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the requested product or service is allowed.
    /// True = Allowed
    /// False = Not allowed
    /// </summary>
    [IsoId("_arjM8P5oEeiLerArw36g0w")]
    [DisplayName("Allowed Item Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwdItmInd")]
    #endif
    [IsoXmlTag("AllwdItmInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AllowedItemIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AllowedItemIndicator { get; init; } 
    #else
    public System.String? AllowedItemIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the line item represents a fuel or non-fuel product or service.
    /// </summary>
    [IsoId("_rYjyQf5nEeiLerArw36g0w")]
    [DisplayName("Fuel Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FuelInd")]
    #endif
    [IsoXmlTag("FuelInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FleetPurchaseType1Code FuelIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FleetPurchaseType1Code FuelIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetPurchaseType1Code FuelIndicator { get; init; } 
    #else
    public FleetPurchaseType1Code FuelIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of service received at the acceptor location. 
    /// </summary>
    [IsoId("_rYjyQ_5nEeiLerArw36g0w")]
    [DisplayName("Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcTp")]
    #endif
    [IsoXmlTag("SvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FleetServiceType1Code? ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetServiceType1Code? ServiceType { get; init; } 
    #else
    public FleetServiceType1Code? ServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a code that identifies a category of fleet products or services. 
    /// </summary>
    [IsoId("_rYjySf5nEeiLerArw36g0w")]
    [DisplayName("Fleet Product Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FleetPdctCtgy")]
    #endif
    [IsoXmlTag("FleetPdctCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FleetProductCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FleetProductCategory { get; init; } 
    #else
    public System.String? FleetProductCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Code that identifies the type of fuel or non-fuel product or service being purchased. 
    /// </summary>
    [IsoId("_rYjyR_5nEeiLerArw36g0w")]
    [DisplayName("Fleet Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FleetPdctCd")]
    #endif
    [IsoXmlTag("FleetPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15Text? FleetProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FleetProductCode { get; init; } 
    #else
    public System.String? FleetProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_rYjyU_5nEeiLerArw36g0w")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure1Code? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_rYjyV_5nEeiLerArw36g0w")]
    [DisplayName("Product Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctQty")]
    #endif
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.Max12NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax12NumericText? ProductQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductQuantity { get; init; } 
    #else
    public System.String? ProductQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount excluding tax.
    /// </summary>
    [IsoId("_rYjyX_5nEeiLerArw36g0w")]
    [DisplayName("Total Amount Excluding Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtExclgTax")]
    #endif
    [IsoXmlTag("TtlAmtExclgTax")]
    [IsoSimpleType(IsoSimpleType.ImpliedCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalAmountExcludingTax { get; init; } 
    #else
    public System.Decimal? TotalAmountExcludingTax { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount including tax.
    /// </summary>
    [IsoId("_rYjyYf5nEeiLerArw36g0w")]
    [DisplayName("Total Amount Including Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtInclgTax")]
    #endif
    [IsoXmlTag("TtlAmtInclgTax")]
    [IsoSimpleType(IsoSimpleType.ImpliedCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalAmountIncludingTax { get; init; } 
    #else
    public System.Decimal? TotalAmountIncludingTax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
