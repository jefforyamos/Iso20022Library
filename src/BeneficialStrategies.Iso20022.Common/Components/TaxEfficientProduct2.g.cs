﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxEfficientProduct2.  ISO2002 ID# _7HpiwU4aEeiQHa-q1Uephw.
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
/// Characteristics of a tax efficient product.
/// </summary>
[IsoId("_7HpiwU4aEeiQHa-q1Uephw")]
[DisplayName("Tax Efficient Product")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxEfficientProduct2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxEfficientProduct2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxEfficientProduct2( TaxEfficientProductType1Choice_ reqTaxEfficientProductType )
    {
        TaxEfficientProductType = reqTaxEfficientProductType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    [IsoId("_Mxu-404bEeiQHa-q1Uephw")]
    [DisplayName("Tax Efficient Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxEffcntPdctTp")]
    #endif
    [IsoXmlTag("TaxEffcntPdctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; } 
    #else
    public TaxEfficientProductType1Choice_ TaxEfficientProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether, for the current year, the product contains a cash asset for transfer.
    /// </summary>
    [IsoId("_7XtYB04aEeiQHa-q1Uephw")]
    [DisplayName("Cash Component Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpntInd")]
    #endif
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashComponentIndicator { get; init; } 
    #else
    public System.String? CashComponentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_7XtYCU4aEeiQHa-q1Uephw")]
    [DisplayName("Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrs")]
    #endif
    [IsoXmlTag("PrvsYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreviousYear4? PreviousYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYear4? PreviousYears { get; init; } 
    #else
    public PreviousYear4? PreviousYears { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investment plan started.
    /// </summary>
    [IsoId("_pznNQV2_EeiFXdiLi_Nf4A")]
    [DisplayName("Date Of First Subscription")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfFrstSbcpt")]
    #endif
    [IsoXmlTag("DtOfFrstSbcpt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfFirstSubscription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfFirstSubscription { get; init; } 
    #else
    public System.DateOnly? DateOfFirstSubscription { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_7XtYC04aEeiQHa-q1Uephw")]
    [DisplayName("Current Year Subscription Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYrSbcptDtls")]
    #endif
    [IsoXmlTag("CurYrSbcptDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    #else
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Bonus paid out or withdrawn.
    /// </summary>
    [IsoId("_uXXFQl2_EeiFXdiLi_Nf4A")]
    [DisplayName("Bonus Or Withdrawal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnsOrWdrwl")]
    #endif
    [IsoXmlTag("BnsOrWdrwl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BonusWithdrawal1? BonusOrWithdrawal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BonusWithdrawal1? BonusOrWithdrawal { get; init; } 
    #else
    public BonusWithdrawal1? BonusOrWithdrawal { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the investor as assigned by a tax authority. 
    /// </summary>
    [IsoId("_uXXFQ12_EeiFXdiLi_Nf4A")]
    [DisplayName("Investor Tax Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTaxRef")]
    #endif
    [IsoXmlTag("InvstrTaxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReference2? InvestorTaxReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReference2? InvestorTaxReference { get; init; } 
    #else
    public TaxReference2? InvestorTaxReference { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the investments to follow.
    /// </summary>
    [IsoId("_71Xu8E4bEeiQHa-q1Uephw")]
    [DisplayName("Investments To Follow Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtsToFllwVal")]
    #endif
    [IsoXmlTag("InvstmtsToFllwVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? InvestmentsToFollowValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? InvestmentsToFollowValue { get; init; } 
    #else
    public DateAndAmount2? InvestmentsToFollowValue { get; set; } 
    #endif
    
    /// <summary>
    /// Information about an innovative finance product.
    /// </summary>
    [IsoId("_FGYnUE4cEeiQHa-q1Uephw")]
    [DisplayName("Innovative Finance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InnvtvFinc")]
    #endif
    [IsoXmlTag("InnvtvFinc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InnovativeFinance1? InnovativeFinance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InnovativeFinance1? InnovativeFinance { get; init; } 
    #else
    public InnovativeFinance1? InnovativeFinance { get; set; } 
    #endif
    
    /// <summary>
    /// Lowest investment amount in the current year, used to calculate a tax deduction amount.
    /// </summary>
    [IsoId("_MosWtKVGEeiYMvosZPzV4g")]
    [DisplayName("Lowest Invested Amount Current Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LwstInvstdAmtCurYr")]
    #endif
    [IsoXmlTag("LwstInvstdAmtCurYr")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd13DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd13DecimalAmount? LowestInvestedAmountCurrentYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? LowestInvestedAmountCurrentYear { get; init; } 
    #else
    public System.Decimal? LowestInvestedAmountCurrentYear { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money from which the tax deduction is calculated. 
    /// </summary>
    [IsoId("_MosWtaVGEeiYMvosZPzV4g")]
    [DisplayName("Tax Calculation Base")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctnBase")]
    #endif
    [IsoXmlTag("TaxClctnBase")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd13DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd13DecimalAmount? TaxCalculationBase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxCalculationBase { get; init; } 
    #else
    public System.Decimal? TaxCalculationBase { get; set; } 
    #endif
    
    /// <summary>
    /// Unused tax deduction amount.
    /// </summary>
    [IsoId("_MosWtqVGEeiYMvosZPzV4g")]
    [DisplayName("Unused Tax Deduction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UusdTaxDdctn")]
    #endif
    [IsoXmlTag("UusdTaxDdctn")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd13DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd13DecimalAmount? UnusedTaxDeduction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? UnusedTaxDeduction { get; init; } 
    #else
    public System.Decimal? UnusedTaxDeduction { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money invested.
    /// </summary>
    [IsoId("_MosWt6VGEeiYMvosZPzV4g")]
    [DisplayName("Current Investment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurInvstmtAmt")]
    #endif
    [IsoXmlTag("CurInvstmtAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd13DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CurrentInvestmentAmount { get; init; } 
    #else
    public System.Decimal? CurrentInvestmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated value of the assets of the tax efficient product to be transferred.
    /// </summary>
    [IsoId("_5953AE4bEeiQHa-q1Uephw")]
    [DisplayName("Estimated Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdVal")]
    #endif
    [IsoXmlTag("EstmtdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? EstimatedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? EstimatedValue { get; init; } 
    #else
    public DateAndAmount2? EstimatedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    [IsoId("_GY9CcE4cEeiQHa-q1Uephw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
