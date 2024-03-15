﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption5.  ISO2002 ID# _UDm9Ydp-Ed-ak6NoX_4Aeg_1050930838.
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
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_UDm9Ydp-Ed-ak6NoX_4Aeg_1050930838")]
[DisplayName("Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOption5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOption5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOption5( OptionNumber1Choice_ reqOptionNumber,CorporateActionOption4Choice_ reqOptionType,SecuritiesOption2 reqSecuritiesQuantity )
    {
        OptionNumber = reqOptionNumber;
        OptionType = reqOptionType;
        SecuritiesQuantity = reqSecuritiesQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UDm9Ytp-Ed-ak6NoX_4Aeg_1050930855")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionNumber1Choice_ OptionNumber { get; init; } 
    #else
    public OptionNumber1Choice_ OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UDm9Y9p-Ed-ak6NoX_4Aeg_1050931090")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption4Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption4Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption4Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption4Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    [IsoId("_UDm9ZNp-Ed-ak6NoX_4Aeg_-2124840077")]
    [DisplayName("Fraction Disposition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrctnDspstn")]
    #endif
    [IsoXmlTag("FrctnDspstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType2Choice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType2Choice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType2Choice_? FractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    [IsoId("_UDm9Zdp-Ed-ak6NoX_4Aeg_1050931150")]
    [DisplayName("Change Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngTp")]
    #endif
    [IsoXmlTag("ChngTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionChangeTypeFormat2Choice_? ChangeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionChangeTypeFormat2Choice_? ChangeType { get; init; } 
    #else
    public CorporateActionChangeTypeFormat2Choice_? ChangeType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that the corporate action instruction is to be processed using the Available-for-Collateral pool.
    /// </summary>
    [IsoId("_UDm9Ztp-Ed-ak6NoX_4Aeg_714557345")]
    [DisplayName("Eligible For Collateral Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblForCollInd")]
    #endif
    [IsoXmlTag("ElgblForCollInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EligibleForCollateralIndicator { get; init; } 
    #else
    public System.String? EligibleForCollateralIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
    /// </summary>
    [IsoId("_UDm9Z9p-Ed-ak6NoX_4Aeg_-1473647351")]
    [DisplayName("Currency To Buy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyToBuy")]
    #endif
    [IsoXmlTag("CcyToBuy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? CurrencyToBuy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyToBuy { get; init; } 
    #else
    public string? CurrencyToBuy { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction within this instruction message.
    /// </summary>
    [IsoId("_UDm9aNp-Ed-ak6NoX_4Aeg_-1436708495")]
    [DisplayName("Currency To Sell")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyToSell")]
    #endif
    [IsoXmlTag("CcyToSell")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? CurrencyToSell { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyToSell { get; init; } 
    #else
    public string? CurrencyToSell { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_UDm9adp-Ed-ak6NoX_4Aeg_1051851276")]
    [DisplayName("Currency Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyOptn")]
    #endif
    [IsoXmlTag("CcyOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyOption { get; init; } 
    #else
    public string? CurrencyOption { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_UDwuYNp-Ed-ak6NoX_4Aeg_1051851396")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification11? SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11? SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification11? SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_UDwuYdp-Ed-ak6NoX_4Aeg_1051852215")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQty")]
    #endif
    [IsoXmlTag("SctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesOption2 SecuritiesQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesOption2 SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOption2 SecuritiesQuantity { get; init; } 
    #else
    public SecuritiesOption2 SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_UDwuYtp-Ed-ak6NoX_4Aeg_-1007268254")]
    [DisplayName("Execution Requested Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnReqdDtTm")]
    #endif
    [IsoXmlTag("ExctnReqdDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExecutionRequestedDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExecutionRequestedDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExecutionRequestedDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_UDwuY9p-Ed-ak6NoX_4Aeg_1051851882")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate8? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate8? RateAndAmountDetails { get; init; } 
    #else
    public CorporateActionRate8? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_UDwuZNp-Ed-ak6NoX_4Aeg_1051851812")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice8? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice8? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice8? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_UDwuZdp-Ed-ak6NoX_4Aeg_1051851492")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative8? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative8? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative8? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
