﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ChargesRecord3.  ISO2002 ID# _9RGSN249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further individual record details on the charges related to the payment transaction.
/// </summary>
public partial record ChargesRecord3
{
    #nullable enable
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the charge should be included in the amount or is added as pre-advice.
    /// </summary>
    public IsoChargeIncludedIndicator? ChargeIncludedIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    public IChargeType3Choice? Type { get; init; } 
    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? Bearer { get; init; } 
    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? Agent { get; init; } 
    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    public TaxCharges2? Tax { get; init; } 
    
    #nullable disable
}
