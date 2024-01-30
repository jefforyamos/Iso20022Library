﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TaxEfficientProduct.  ISO2002 ID# _pEam0U4aEeiQHa-q1Uephw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio2Choice;

/// <summary>
/// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt 'wrappers' in which equities, bonds and funds can be held to shelter them from various types of tax.
/// In the UK, a typical tax wrapper product is known as an 'ISA' (Individual Savings Account).
/// </summary>
public partial record TaxEfficientProduct : IFundPortfolio2Choice
{
    #nullable enable
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    public required ITaxEfficientProductType1Choice TaxEfficientProductType { get; init; } 
    /// <summary>
    /// Indicates whether, for the current year, the product contains a cash asset for transfer.
    /// </summary>
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    public PreviousYear4? PreviousYears { get; init; } 
    /// <summary>
    /// Date the investment plan started.
    /// </summary>
    public IsoISODate? DateOfFirstSubscription { get; init; } 
    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    /// <summary>
    /// Bonus paid out or withdrawn.
    /// </summary>
    public BonusWithdrawal1? BonusOrWithdrawal { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the investor as assigned by a tax authority. 
    /// </summary>
    public TaxReference2? InvestorTaxReference { get; init; } 
    /// <summary>
    /// Value of the investments to follow.
    /// </summary>
    public DateAndAmount2? InvestmentsToFollowValue { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information about an innovative finance product.
    /// </summary>
    public InnovativeFinance1? InnovativeFinance { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Lowest investment amount in the current year, used to calculate a tax deduction amount.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? LowestInvestedAmountCurrentYear { get; init; } 
    /// <summary>
    /// Amount of money from which the tax deduction is calculated. 
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? TaxCalculationBase { get; init; } 
    /// <summary>
    /// Unused tax deduction amount.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? UnusedTaxDeduction { get; init; } 
    /// <summary>
    /// Amount of money invested.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
    /// <summary>
    /// Estimated value of the assets of the tax efficient product to be transferred.
    /// </summary>
    public DateAndAmount2? EstimatedValue { get; init; } 
    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
