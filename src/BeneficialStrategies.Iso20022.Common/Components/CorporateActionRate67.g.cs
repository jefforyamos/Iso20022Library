﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate67.  ISO2002 ID# _qcDWJUEEEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates related to a corporate action option.
/// </summary>
public partial record CorporateActionRate67
{
    #nullable enable
    
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    public IRateAndAmountFormat37Choice? AdditionalTax { get; init; } 
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    public IGrossDividendRateFormat19Choice? GrossDividendRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    public INetDividendRateFormat21Choice? NetDividendRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    public IRateAndAmountFormat37Choice? IndexFactor { get; init; } 
    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    public IInterestRateUsedForPaymentFormat8Choice? InterestRateUsedForPayment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    public IRateFormat3Choice? MaximumAllowedOversubscriptionRate { get; init; } 
    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    public IRateFormat3Choice? ProrationRate { get; init; } 
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IRateAndAmountFormat41Choice? WithholdingTaxRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    public IRateAndAmountFormat41Choice? SecondLevelTax { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    public RateTypeAndAmountAndStatus26? TaxableIncomePerDividendShare { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    public IRateAndAmountFormat37Choice? TaxOnIncome { get; init; } 
    
    #nullable disable
}
