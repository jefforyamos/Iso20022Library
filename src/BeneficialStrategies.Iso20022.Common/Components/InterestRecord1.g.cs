﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InterestRecord1.  ISO2002 ID# _txS1EVkyEeGeoaLUQk__nA_677183117.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction specific interest information that applies to the underlying transaction.
/// </summary>
public partial record InterestRecord1
{
    #nullable enable
    
    /// <summary>
    /// Amount of interest included in the entry amount.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether the interest amount included in the entry is credit or debit amount.
    /// Usage: A zero amount is considered to be a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    public InterestType1Choice_? Type { get; init; } 
    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    public Rate3? Rate { get; init; } 
    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    public DateTimePeriodDetails? FromToDate { get; init; } 
    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    public IsoMax35Text? Reason { get; init; } 
    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    public TaxCharges2? Tax { get; init; } 
    
    #nullable disable
}
