﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate89.  ISO2002 ID# _inXESZb_Eee8S7xwGG7Veg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security rate details.
/// </summary>
public partial record CorporateActionRate89
{
    #nullable enable
    
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    public RatioFormat17Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    public RatioFormat17Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    public RatioFormat18Choice_? NewToOld { get; init; } 
    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions that are the result of a transformation of the parent transaction.
    /// </summary>
    public IsoPercentageRate? TransformationRate { get; init; } 
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    public RateAndAmountFormat37Choice_? ChargesFees { get; init; } 
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    public RateFormat3Choice_? FiscalStamp { get; init; } 
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    public RateFormat3Choice_? ApplicableRate { get; init; } 
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    public RateFormat20Choice_? TaxCreditRate { get; init; } 
    /// <summary>
    /// Rate of financial transaction tax.
    /// </summary>
    public RateFormat3Choice_? FinancialTransactionTaxRate { get; init; } 
    
    #nullable disable
}
