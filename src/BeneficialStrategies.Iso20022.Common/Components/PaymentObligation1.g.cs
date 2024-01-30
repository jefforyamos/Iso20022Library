﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentObligation1.  ISO2002 ID# _TmaED9p-Ed-ak6NoX_4Aeg_596881925.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment obligation contracted between two financial institutions related to the financing of a commercial transaction.
/// </summary>
public partial record PaymentObligation1
{
    #nullable enable
    
    /// <summary>
    /// Bank that has to pay under the obligation.
    /// </summary>
    public required BICIdentification1 ObligorBank { get; init; } 
    /// <summary>
    /// Bank that will be paid under the obligation.
    /// </summary>
    public required BICIdentification1 RecipientBank { get; init; } 
    /// <summary>
    /// Maximum amount that will be paid under the obligation.
    /// </summary>
    public required IsoCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Maximum amount that will be paid under the obligation, expressed as a percentage of the purchase order net amount.
    /// </summary>
    public required IsoPercentageRate Percentage { get; init; } 
    /// <summary>
    /// Amount of the charges taken by the obligor bank.
    /// </summary>
    public IsoCurrencyAndAmount? ChargesAmount { get; init; } 
    /// <summary>
    /// Amount of the charges expressed as a percentage of the amount paid by the obligor bank.
    /// </summary>
    public IsoPercentageRate? ChargesPercentage { get; init; } 
    /// <summary>
    /// Date at which the obligation will expire.
    /// </summary>
    public required IsoISODate ExpiryDate { get; init; } 
    /// <summary>
    /// Country of which the law governs the bank payment obligation.
    /// </summary>
    public CountryCode? ApplicableLaw { get; init; } 
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    public PaymentTerms2? PaymentTerms { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Instruction between two clearing agents stipulating the cash transfer characteristics between the two parties.
    /// </summary>
    public SettlementTerms2? SettlementTerms { get; init; } 
    
    #nullable disable
}
