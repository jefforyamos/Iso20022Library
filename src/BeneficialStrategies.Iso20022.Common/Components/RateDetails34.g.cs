﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateDetails34.  ISO2002 ID# _k9v-tc3xEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the rates related to securities movement.
/// </summary>
public partial record RateDetails34
{
    #nullable enable
    
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    public IRateAndAmountFormat46Choice? AdditionalTax { get; init; } 
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    public IGrossDividendRateFormat34Choice? GrossDividendRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    public IInterestRateUsedForPaymentFormat10Choice? InterestRateUsedForPayment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IRateAndAmountFormat47Choice? WithholdingTaxRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    public IRateAndAmountFormat47Choice? SecondLevelTax { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    public IRateAndAmountFormat46Choice? ChargesFees { get; init; } 
    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    public ISolicitationFeeRateFormat10Choice? EarlySolicitationFeeRate { get; init; } 
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    public IRateFormat3Choice? FiscalStamp { get; init; } 
    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer. As information, payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    public IRateFormat21Choice? ThirdPartyIncentiveRate { get; init; } 
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    public INetDividendRateFormat36Choice? NetDividendRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    public IRateFormat3Choice? ApplicableRate { get; init; } 
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fee.
    /// </summary>
    public ISolicitationFeeRateFormat10Choice? SolicitationFeeRate { get; init; } 
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    public IRateFormat21Choice? TaxCreditRate { get; init; } 
    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    public IRateAndAmountFormat46Choice? TaxOnIncome { get; init; } 
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    public IRateFormat3Choice? TaxOnProfits { get; init; } 
    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    public IRateFormat3Choice? TaxReclaimRate { get; init; } 
    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    public IRateAndAmountFormat48Choice? EqualisationRate { get; init; } 
    /// <summary>
    /// Rate applied for the calculation of deemed proceeds which are not paid to security holders but on which withholding tax is applicable.
    /// </summary>
    public IRateAndAmountFormat53Choice? DeemedRate { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
