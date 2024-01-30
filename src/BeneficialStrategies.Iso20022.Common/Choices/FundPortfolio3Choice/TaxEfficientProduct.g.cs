﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TaxEfficientProduct.  ISO2002 ID# _U5MVgU7cEeifNrXGwadPmg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio3Choice;

/// <summary>
/// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt 'wrappers' in which equities, bonds and funds can be held to shelter them from various types of tax.
/// In the UK, a typical tax wrapper product is known as an 'ISA' (Individual Savings Account).
/// </summary>
public partial record TaxEfficientProduct : IFundPortfolio3Choice
{
    #nullable enable
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    public required ITaxEfficientProductType1Choice TaxEfficientProductType { get; init; } 
    /// <summary>
    /// Indicates whether the product contains a cash asset for transfer.
    /// </summary>
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    public PreviousYear4? PreviousYears { get; init; } 
    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
