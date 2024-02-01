﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate4.  ISO2002 ID# _TXEAddp-Ed-ak6NoX_4Aeg_-525646890.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates.
/// </summary>
public partial record CorporateActionRate4
{
    #nullable enable
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    public RateAndAmountFormat5Choice_? ChargesFees { get; init; } 
    /// <summary>
    /// Dividend is final.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? FinalDividendRate { get; init; } 
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    public IsoPercentageRate? FiscalStamp { get; init; } 
    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    public RateAndAmountFormat5Choice_? FullyFrankedRate { get; init; } 
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    public GrossDividendRateFormat2Choice_[] GrossDividendRate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.
    /// </summary>
    public IsoPercentageRate? CashIncentiveRate { get; init; } 
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    public RateAndAmountFormat5Choice_? IndexFactor { get; init; } 
    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    public InterestRateUsedForPaymentFormat2Choice_[] InterestRateUsedForPayment { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    public NetDividendRateFormat2Choice_[] NetDividendRate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    public RateAndAmountFormat5Choice_? NonResidentRate { get; init; } 
    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    public IsoPercentageRate? MaximumAllowedOversubscriptionRate { get; init; } 
    /// <summary>
    /// Dividend is provisional.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? ProvisionalDividendRate { get; init; } 
    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    public IsoPercentageRate? ProrationRate { get; init; } 
    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// </summary>
    public IsoPercentageRate? SolicitationFeeRate { get; init; } 
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    public TaxCreditRateFormat2Choice_[] TaxCreditRate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    public RateTypeAndAmountAndStatus6[] TaxRelatedRate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    public IsoPercentageRate? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    public IsoPercentageRate? TaxOnIncome { get; init; } 
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    public IsoPercentageRate? TaxOnProfits { get; init; } 
    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    public IsoPercentageRate? TaxReclaimRate { get; init; } 
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    public RateAndAmountFormat5Choice_? WithholdingOfForeignTax { get; init; } 
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    public RateAndAmountFormat5Choice_? WithholdingOfLocalTax { get; init; } 
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    public RateAndAmountFormat5Choice_? AdditionalTax { get; init; } 
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    public IsoPercentageRate? ApplicableRate { get; init; } 
    
    #nullable disable
}
