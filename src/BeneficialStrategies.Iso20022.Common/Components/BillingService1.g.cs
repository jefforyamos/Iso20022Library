﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingService1.  ISO2002 ID# _6PDr1ZqlEeGSON8vddiWzQ_-1150406183.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the values used for every line item service in the statement.
/// </summary>
public partial record BillingService1
{
    #nullable enable
    
    /// <summary>
    /// Specifies further detailed values for this service.
    /// </summary>
    public required BillingServiceParameters1 ServiceDetail { get; init; } 
    /// <summary>
    /// Price applied to the service, expressed in the pricing currency.
    /// </summary>
    public BillingPrice1? Price { get; init; } 
    /// <summary>
    /// Code identifying the disposition of the calculated charge.
    /// </summary>
    public required ServicePaymentMethod1Code PaymentMethod { get; init; } 
    /// <summary>
    /// Amount of the calculated charge, expressed in the pricing currency. This value does not include any tax on the service.
    /// </summary>
    public required AmountAndDirection34 OriginalChargePrice { get; init; } 
    /// <summary>
    /// Amount of the calculated charge, expressed in the settlement currency.
    /// </summary>
    public AmountAndDirection34? OriginalChargeSettlementAmount { get; init; } 
    /// <summary>
    /// Average daily collected balance required to offset a balance compensable service charge, exclusive of taxes, expressed in the account currency.
    /// </summary>
    public AmountAndDirection34? BalanceRequiredAccountAmount { get; init; } 
    /// <summary>
    /// Provides the details of the taxable status of a service.
    /// </summary>
    public required ServiceTaxDesignation1 TaxDesignation { get; init; } 
    /// <summary>
    /// Provides tax related values for tax calculation methods A, B or D.
    /// </summary>
    public IBillingMethod1Choice? TaxCalculation { get; init; } 
    
    #nullable disable
}
