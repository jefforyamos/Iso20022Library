﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption60.  ISO2002 ID# _7uOKgYl0EeavwKddCbm3hg.
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
/// Provides information about the corporate action security option.
/// </summary>
[IsoId("_7uOKgYl0EeavwKddCbm3hg")]
[DisplayName("Securities Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOption60
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesOption60 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesOption60( SecurityIdentification19 reqFinancialInstrumentIdentification,CreditDebitCode reqCreditDebitIndicator,Quantity6Choice_ reqPostingQuantity,SecurityDate11 reqDateDetails )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        CreditDebitIndicator = reqCreditDebitIndicator;
        PostingQuantity = reqPostingQuantity;
        DateDetails = reqDateDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_8GBmiYl0EeavwKddCbm3hg")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_8GBmkYl0EeavwKddCbm3hg")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [IsoId("_8GBmmYl0EeavwKddCbm3hg")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TempFinInstrmInd")]
    #endif
    [IsoXmlTag("TempFinInstrmInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TemporaryFinancialInstrumentIndicator3Choice_? TemporaryFinancialInstrumentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TemporaryFinancialInstrumentIndicator3Choice_? TemporaryFinancialInstrumentIndicator { get; init; } 
    #else
    public TemporaryFinancialInstrumentIndicator3Choice_? TemporaryFinancialInstrumentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities are newly issued or not.
    /// </summary>
    [IsoId("_8GBmoYl0EeavwKddCbm3hg")]
    [DisplayName("New Securities Issuance Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewSctiesIssncInd")]
    #endif
    [IsoXmlTag("NewSctiesIssncInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NewSecuritiesIssuanceType6Code? NewSecuritiesIssuanceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NewSecuritiesIssuanceType6Code? NewSecuritiesIssuanceIndicator { get; init; } 
    #else
    public NewSecuritiesIssuanceType6Code? NewSecuritiesIssuanceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_8GBmo4l0EeavwKddCbm3hg")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrOfferrTaxbltyInd")]
    #endif
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; } 
    #else
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_8GBmpYl0EeavwKddCbm3hg")]
    [DisplayName("Income Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmTp")]
    #endif
    [IsoXmlTag("IncmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? IncomeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? IncomeType { get; init; } 
    #else
    public GenericIdentification30? IncomeType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("_8GBmrYl0EeavwKddCbm3hg")]
    [DisplayName("Exemption Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnTp")]
    #endif
    [IsoXmlTag("XmptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? ExemptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? ExemptionType { get; init; } 
    #else
    public GenericIdentification30? ExemptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    [IsoId("_8GBmr4l0EeavwKddCbm3hg")]
    [DisplayName("Country Of Income Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfIncmSrc")]
    #endif
    [IsoXmlTag("CtryOfIncmSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfIncomeSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfIncomeSource { get; init; } 
    #else
    public string? CountryOfIncomeSource { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    [IsoId("_8GBmsYl0EeavwKddCbm3hg")]
    [DisplayName("Posting Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngQty")]
    #endif
    [IsoXmlTag("PstngQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity6Choice_ PostingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity6Choice_ PostingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_ PostingQuantity { get; init; } 
    #else
    public Quantity6Choice_ PostingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_8GBmuYl0EeavwKddCbm3hg")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_8GBmwYl0EeavwKddCbm3hg")]
    [DisplayName("Fraction Disposition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrctnDspstn")]
    #endif
    [IsoXmlTag("FrctnDspstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType27Choice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType27Choice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType27Choice_? FractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_8GBmyYl0EeavwKddCbm3hg")]
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
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [IsoId("_8GBm0Yl0EeavwKddCbm3hg")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityDate11 DateDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityDate11 DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityDate11 DateDetails { get; init; } 
    #else
    public SecurityDate11 DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [IsoId("_8GBm2Yl0EeavwKddCbm3hg")]
    [DisplayName("Rate Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateDtls")]
    #endif
    [IsoXmlTag("RateDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate72? RateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate72? RateDetails { get; init; } 
    #else
    public CorporateActionRate72? RateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [IsoId("_8GBm4Yl0EeavwKddCbm3hg")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice59? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice59? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice59? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_8GBm6Yl0EeavwKddCbm3hg")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties42? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties42? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties42? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_8GBm8Yl0EeavwKddCbm3hg")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties42? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties42? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties42? DeliveringSettlementParties { get; set; } 
    #endif
    
    
    #nullable disable
    
}
