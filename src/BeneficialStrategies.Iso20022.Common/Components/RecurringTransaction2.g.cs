﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RecurringTransaction2.  ISO2002 ID# _3s3JETDhEeO9waS4ina8CA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record RecurringTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Type of instalment plan.
    /// </summary>
    [DataMember]
    public ValueList<InstalmentPlan1Code> InstalmentPlan { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [DataMember]
    public IsoMax35Text? PlanIdentification { get; init; } 
    /// <summary>
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    [DataMember]
    public IsoNumber? SequenceNumber { get; init; } 
    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    [DataMember]
    public Frequency3Code? PeriodUnit { get; init; } 
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [DataMember]
    public IsoNumber? InstalmentPeriod { get; init; } 
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [DataMember]
    public IsoNumber? TotalNumberOfPayments { get; init; } 
    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [DataMember]
    public IsoISODate? FirstPaymentDate { get; init; } 
    /// <summary>
    /// Cumulative amount of all the instalments.
    /// </summary>
    [DataMember]
    public IsoCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Amount of the first payment.
    /// </summary>
    [DataMember]
    public IsoImpliedCurrencyAndAmount? FirstAmount { get; init; } 
    /// <summary>
    /// Charges related to the transaction.
    /// </summary>
    [DataMember]
    public IsoImpliedCurrencyAndAmount? Charges { get; init; } 
    
    #nullable disable
}
