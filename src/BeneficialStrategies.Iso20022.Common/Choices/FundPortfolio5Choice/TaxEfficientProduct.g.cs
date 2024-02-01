﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TaxEfficientProduct.  ISO2002 ID# _nxCyoZNMEemQB_8XA98K0Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio5Choice;

/// <summary>
/// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt 'wrappers' in which equities, bonds and funds can be held to shelter them from various types of tax.
/// In the UK, a typical tax wrapper product is known as an 'ISA' (Individual Savings Account).
/// </summary>
public partial record TaxEfficientProduct : FundPortfolio5Choice_
{
    #nullable enable
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
    /// <summary>
    /// Indicates that all the current fiscal year’s products are included.
    /// </summary>
    public IsoYesNoIndicator? CurrentYear { get; init; } 
    /// <summary>
    /// Indicates whether, for the current year, the product contains a cash asset for transfer.
    /// </summary>
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    public PreviousYear4? PreviousYears { get; init; } 
    /// <summary>
    /// Subscriptions from the previous subscription year.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? PreviousYearSubscriptionAmount { get; init; } 
    /// <summary>
    /// Amount subscribed in all previous years.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? PreviousYearsSubscriptionAmount { get; init; } 
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
    public BonusWithdrawal2? BonusOrWithdrawal { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Alternative identification for the transferor (ceding party), for example, the 'ISA manager Z reference' in the UK. 
    /// </summary>
    public IsoMax35Text? TransferorAlternateIdentification { get; init; } 
    /// <summary>
    /// Total amount subscribed over the lifetime of the product.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    /// <summary>
    /// Another amount such as the total qualifying additions in the year of transfer, interest capitalised in the current year, total outstanding dividend and so on.
    /// </summary>
    public OtherAmount3? OtherAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Date the first qualifying additional amount was made to the product.  Qualifying additional amounts may be made to a Lifetime Individual Savings Account (LISA) product.
    /// </summary>
    public IsoISODate? DateFirstQualifyingAddition { get; init; } 
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
