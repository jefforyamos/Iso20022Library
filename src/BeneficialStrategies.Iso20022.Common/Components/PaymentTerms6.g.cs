﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTerms6.  ISO2002 ID# _ODM5MDI2-AOSNFX-3397728.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms of the underlying transaction.
/// </summary>
public partial record PaymentTerms6
{
    #nullable enable
    
    /// <summary>
    /// Due date specified for the payment terms.
    /// </summary>
    public IsoISODate? DueDate { get; init; } 
    /// <summary>
    /// Payment period specified for these payment terms.
    /// </summary>
    public PaymentPeriod1? PaymentPeriod { get; init; } 
    /// <summary>
    /// Textual description of these payment terms.
    /// </summary>
    public IsoMax140Text[] Description { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Partial payment, expressed as a percentage, for the payment terms.
    /// </summary>
    public IsoPercentageRate? PartialPaymentPercent { get; init; } 
    /// <summary>
    /// Direct debit mandate identification specified for these payment terms.
    /// </summary>
    public IsoMax35Text[] DirectDebitMandateIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount used as a basis to calculate the discount amount for these payment terms.
    /// </summary>
    public IsoCurrencyAndAmount? BasisAmount { get; init; } 
    /// <summary>
    /// Amount of money that results from the application of an agreed discount percentage to the basis amount and payable to the creditor.
    /// </summary>
    public IsoCurrencyAndAmount? DiscountAmount { get; init; } 
    /// <summary>
    /// Percent rate used to calculate the discount for these payment terms.
    /// </summary>
    public IsoPercentageRate? DiscountPercentRate { get; init; } 
    /// <summary>
    /// Amount of money that results from the application of an agreed penalty percentage to the basis amount and payable by the creditor.
    /// </summary>
    public IsoCurrencyAndAmount? PenaltyAmount { get; init; } 
    /// <summary>
    /// Percent rate used to calculate the penalty for these payment terms.
    /// </summary>
    public IsoPercentageRate? PenaltyPercentRate { get; init; } 
    
    #nullable disable
}
