﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ShippingData1.  ISO2002 ID# _ScxsW_cjEeiW-auGnDPZIw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Shipping or Courier Service delivery. 
/// </summary>
[IsoId("_ScxsW_cjEeiW-auGnDPZIw")]
[DisplayName("Shipping Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShippingData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    [IsoId("_ScxsXvcjEeiW-auGnDPZIw")]
    [DisplayName("Invoice Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcNb")]
    #endif
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? InvoiceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InvoiceNumber { get; init; } 
    #else
    public System.String? InvoiceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the date and time the electronic invoice was created.
    /// </summary>
    [IsoId("_ScyTYfcjEeiW-auGnDPZIw")]
    [DisplayName("Invoice Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcCreDtTm")]
    #endif
    [IsoXmlTag("InvcCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? InvoiceCreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? InvoiceCreationDateTime { get; init; } 
    #else
    public System.DateTime? InvoiceCreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a card acceptor designated code for the shipping service provided.
    /// </summary>
    [IsoId("_ScyTYPcjEeiW-auGnDPZIw")]
    [DisplayName("Service Descriptor Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcDscrptrCd")]
    #endif
    [IsoXmlTag("SvcDscrptrCd")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax40Text? ServiceDescriptorCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceDescriptorCode { get; init; } 
    #else
    public System.String? ServiceDescriptorCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the amount of any incentives applied to the transaction. 
    /// </summary>
    [IsoId("_ScxsX_cjEeiW-auGnDPZIw")]
    [DisplayName("Incentive Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncntivAmt")]
    #endif
    [IsoXmlTag("IncntivAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? IncentiveAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? IncentiveAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? IncentiveAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the amount of any miscellaneous expenses applicable to the transaction. 
    /// </summary>
    [IsoId("_ScxsYfcjEeiW-auGnDPZIw")]
    [DisplayName("Miscellaneous Expenses")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MiscExpnss")]
    #endif
    [IsoXmlTag("MiscExpnss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MiscellaneousExpenses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MiscellaneousExpenses { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MiscellaneousExpenses { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_1YnHo_ckEeiW-auGnDPZIw")]
    [DisplayName("Insurance Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncInd")]
    #endif
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuranceIndicator { get; init; } 
    #else
    public System.String? InsuranceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_1YnHpPckEeiW-auGnDPZIw")]
    [DisplayName("Insurance Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncAmt")]
    #endif
    [IsoXmlTag("InsrncAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the net amount of shipping expenses.
    /// </summary>
    [IsoId("_1YnHpfckEeiW-auGnDPZIw")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? NetAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the total tax amount for the entire purchase. 
    /// </summary>
    [IsoId("_ScxsYPcjEeiW-auGnDPZIw")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax33? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax33? Tax { get; init; } 
    #else
    public Tax33? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_ScxsY_cjEeiW-auGnDPZIw")]
    [DisplayName("Summary Commodity Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryCmmdtyId")]
    #endif
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SummaryCommodityIdentification { get; init; } 
    #else
    public System.String? SummaryCommodityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the total number of packages being shipped or sent by the service provider.
    /// </summary>
    [IsoId("_ScxsYvcjEeiW-auGnDPZIw")]
    [DisplayName("Number Of Packages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfPackgs")]
    #endif
    [IsoXmlTag("NbOfPackgs")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6NumericText? NumberOfPackages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfPackages { get; init; } 
    #else
    public System.String? NumberOfPackages { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of the package being shipped. 
    /// </summary>
    [IsoId("_ScxsXPcjEeiW-auGnDPZIw")]
    [DisplayName("Package")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Packg")]
    #endif
    [IsoXmlTag("Packg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShippingPackage1? Package { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShippingPackage1? Package { get; init; } 
    #else
    public ShippingPackage1? Package { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional shipping data.
    /// </summary>
    [IsoId("_ScxsXfcjEeiW-auGnDPZIw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
