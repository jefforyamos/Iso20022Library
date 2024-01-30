﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TaxEfficientProduct.  ISO2002 ID# _ibqr0U4HEeiQHa-q1Uephw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio1Choice;

/// <summary>
/// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt 'wrappers' in which equities, bonds and funds can be held to shelter them from various types of tax.
/// In the UK, a typical tax wrapper product is known as an 'ISA' (Individual Savings Account).
/// </summary>
public partial record TaxEfficientProduct : IFundPortfolio1Choice
{
    #nullable enable
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    public required ITaxEfficientProductType1Choice TaxEfficientProductType { get; init; } 
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    public IPreviousYear2Choice? PreviousYears { get; init; } 
    /// <summary>
    /// Indicates that the product was issued during the current fiscal year.
    /// </summary>
    public IsoYesNoIndicator? CurrentYear { get; init; } 
    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
