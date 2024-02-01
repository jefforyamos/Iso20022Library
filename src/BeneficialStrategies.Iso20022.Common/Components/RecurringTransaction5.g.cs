﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RecurringTransaction5.  ISO2002 ID# _I0Ew0XDlEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
public partial record RecurringTransaction5
{
    #nullable enable
    
    /// <summary>
    /// Type of instalment plan.
    /// </summary>
    public InstalmentPlan1Code[] InstalmentPlan { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    public IsoMax35Text? PlanIdentification { get; init; } 
    /// <summary>
    /// Type of the Plan Owner.
    /// </summary>
    public PlanOwner1Code? PlanOwner { get; init; } 
    /// <summary>
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    public IsoNumber? SequenceNumber { get; init; } 
    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    public Frequency3Code? PeriodUnit { get; init; } 
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    public IsoNumber? InstalmentPeriod { get; init; } 
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    public IsoNumber? TotalNumberOfPayments { get; init; } 
    /// <summary>
    /// Date of the first payment.
    /// </summary>
    public IsoISODate? FirstPaymentDate { get; init; } 
    /// <summary>
    /// Cumulative amount of all the instalments.
    /// </summary>
    public IsoCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Amount of the first payment.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? FirstAmount { get; init; } 
    /// <summary>
    /// Amount of subsequent payments but the first one.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? SubsequentAmount { get; init; } 
    /// <summary>
    /// Amount of the last payment.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? LastAmount { get; init; } 
    /// <summary>
    /// Charges related to the transaction.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? Charges { get; init; } 
    /// <summary>
    /// Contains the charge details of an instalment plan.
    /// </summary>
    public InstalmentAmountDetails1[] DetailedCharges { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Details of the interest rate.
    /// </summary>
    public InterestRateDetails1[] InterestRate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Contains grace period details.
    /// </summary>
    public GracePeriod1[] GracePeriod { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Notice related to the InstalmentPlan.
    /// </summary>
    public ActionMessage10[] PlanNotice { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
