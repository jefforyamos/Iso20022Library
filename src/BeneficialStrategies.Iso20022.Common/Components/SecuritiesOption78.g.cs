﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption78.  ISO2002 ID# _RITtkxe-EeyroI8qKgB7Mg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
public partial record SecuritiesOption78
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    public ITemporaryFinancialInstrumentIndicator3Choice? TemporaryFinancialInstrumentIndicator { get; init; } 
    /// <summary>
    /// Specifies the nature of the securities issue.
    /// </summary>
    public NewSecuritiesIssuanceType6Code? NewSecuritiesIssuanceIndicator { get; init; } 
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    public IIssuerOfferorTaxabilityIndicator1Choice? IssuerOfferorTaxabilityIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    public GenericIdentification30? IncomeType { get; init; } 
    /// <summary>
    /// Type of income to be used under another tax regime.
    /// </summary>
    public GenericIdentification30? OtherIncomeType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    public GenericIdentification30? ExemptionType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    public CountryCode? CountryOfIncomeSource { get; init; } 
    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    public required IQuantity51Choice PostingQuantity { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public ISafekeepingPlaceFormat29Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public IFractionDispositionType27Choice? FractionDisposition { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    public required SecurityDate15 DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    public CorporateActionRate90? RateDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    public CorporateActionPrice74? PriceDetails { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties102? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties102? DeliveringSettlementParties { get; init; } 
    
    #nullable disable
}
