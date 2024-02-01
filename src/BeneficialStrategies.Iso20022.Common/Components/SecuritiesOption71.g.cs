﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption71.  ISO2002 ID# _Xqg24bXEEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
public partial record SecuritiesOption71
{
    #nullable enable
    
    /// <summary>
    /// Provides description of the financial instrument related to securities movement.
    /// </summary>
    public required FinancialInstrumentAttributes80 SecurityDetails { get; init; } 
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    public TemporaryFinancialInstrumentIndicator3Choice_? TemporaryFinancialInstrumentIndicator { get; init; } 
    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    public NonEligibleProceedsIndicator3Choice_? NonEligibleProceedsIndicator { get; init; } 
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; } 
    /// <summary>
    /// Specifies the nature of the securities issue.
    /// </summary>
    public NewSecuritiesIssuanceType5Code? NewSecuritiesIssuanceIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    public GenericIdentification30? IncomeType { get; init; } 
    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    public GenericIdentification30[] ExemptionType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    public Quantity6Choice_? EntitledQuantity { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    public CountryCode? CountryOfIncomeSource { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType26Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    public Period6Choice_? TradingPeriod { get; init; } 
    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    public required SecurityDate16 DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    public CorporateActionRate89? RateDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    public CorporateActionPrice56? PriceDetails { get; init; } 
    
    #nullable disable
}
