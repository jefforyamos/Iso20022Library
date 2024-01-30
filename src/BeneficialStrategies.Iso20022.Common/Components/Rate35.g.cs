﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Rate35.  ISO2002 ID# _YuHS2-XsEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the rates related to securities movement.
/// </summary>
public partial record Rate35
{
    #nullable enable
    
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    public IRateAndAmountFormat39Choice? AdditionalTax { get; init; } 
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    public IRateAndAmountFormat39Choice? ChargesFees { get; init; } 
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    public IsoPercentageRate? FiscalStamp { get; init; } 
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    public IGrossDividendRateFormat37Choice? GrossDividendRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    public ISolicitationFeeRateFormat8Choice? EarlySolicitationFeeRate { get; init; } 
    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer. As information, Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    public IRateAndAmountFormat39Choice? ThirdPartyIncentiveRate { get; init; } 
    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    public IInterestRateUsedForPaymentFormat7Choice? InterestRateUsedForPayment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    public INetDividendRateFormat40Choice? NetDividendRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    public IsoPercentageRate? ApplicableRate { get; init; } 
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fee.
    /// </summary>
    public ISolicitationFeeRateFormat8Choice? SolicitationFeeRate { get; init; } 
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    public IRateFormat22Choice? TaxCreditRate { get; init; } 
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IRateAndAmountFormat40Choice? WithholdingTaxRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    public IRateAndAmountFormat40Choice? SecondLevelTax { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    public IRateAndAmountFormat39Choice? TaxOnIncome { get; init; } 
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    public IsoPercentageRate? TaxOnProfits { get; init; } 
    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    public IsoPercentageRate? TaxReclaimRate { get; init; } 
    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? EqualisationRate { get; init; } 
    /// <summary>
    /// Rate applied for the calculation of deemed proceeds which are not paid to security holders but on which withholding tax is applicable.
    /// </summary>
    public IRateAndAmountFormat52Choice? DeemedRate { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
