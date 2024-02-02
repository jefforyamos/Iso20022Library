﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingStatement2.  ISO2002 ID# _arIxfTq2EeWZFYSPlduMhw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the statement reporting the bank services billing.
/// </summary>
[DataContract]
[XmlType]
public partial record BillingStatement2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the customer billing statement.
    /// </summary>
    [DataMember]
    public required IsoMax35Text StatementIdentification { get; init; } 
    /// <summary>
    /// Date range between the start date and the end date for which the statement is issued.
    /// </summary>
    [DataMember]
    public required DatePeriod1 FromToDate { get; init; } 
    /// <summary>
    /// Date the statement message was created.
    /// </summary>
    [DataMember]
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Defines the status of the statement.
    /// </summary>
    [DataMember]
    public required BillingStatementStatus1Code Status { get; init; } 
    /// <summary>
    /// Specifies the details of the account characteristics.
    /// </summary>
    [DataMember]
    public required CashAccountCharacteristics2 AccountCharacteristics { get; init; } 
    /// <summary>
    /// Identifies the non tax per annum rate and factor values used within the statement along with any time dependent charge basis.
    /// </summary>
    [DataMember]
    public ValueList<BillingRate1> RateData { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies details related to currency exchange data.
    /// </summary>
    [DataMember]
    public ValueList<CurrencyExchange6> CurrencyExchange { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the average value of balances held within the statement period.
    /// </summary>
    [DataMember]
    public ValueList<BillingBalance1> Balance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the set of values and totals that are used to provide compensation information, service and tax totals.
    /// </summary>
    [DataMember]
    public ValueList<BillingCompensation1> Compensation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the values used for every line item service in the statement.
    /// </summary>
    [DataMember]
    public ValueList<BillingService2> Service { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Tax region(s) that levy a tax on the services within this statement.
    /// </summary>
    [DataMember]
    public ValueList<BillingTaxRegion1> TaxRegion { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// One or more sections that identify balance or float adjustments to the account. They can reflect either adjustments to the current statement or adjustments to statements from prior reporting periods.
    /// </summary>
    [DataMember]
    public ValueList<BalanceAdjustment1> BalanceAdjustment { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// One or more sections that identify line item service adjustments to the account. They reflect adjustments to statements from prior reporting periods.
    /// </summary>
    [DataMember]
    public ValueList<BillingServiceAdjustment1> ServiceAdjustment { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
