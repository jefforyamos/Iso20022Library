﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate38.  ISO2002 ID# _kxu8fxLnEeKJ5uSjVyVvug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates.
/// </summary>
public partial record CorporateActionRate38
{
    #nullable enable
    
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    public IGrossDividendRateFormat10Choice? GrossDividendRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    public INetDividendRateFormat12Choice? NetDividendRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    public IRateAndAmountFormat5Choice? IndexFactor { get; init; } 
    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    public IInterestRateUsedForPaymentFormat2Choice? InterestRateUsedForPayment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    public IsoPercentageRate? MaximumAllowedOversubscriptionRate { get; init; } 
    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    public IsoPercentageRate? ProrationRate { get; init; } 
    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    public RateTypeAndAmountAndStatus6? TaxRelatedRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    public IsoPercentageRate? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    public IRateAndAmountFormat5Choice? AdditionalTax { get; init; } 
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction to which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    public IRateAndAmountFormat5Choice? WithholdingOfForeignTax { get; init; } 
    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    public RateTypeAndAmountAndStatus11? TaxableIncomePerDividendShare { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
