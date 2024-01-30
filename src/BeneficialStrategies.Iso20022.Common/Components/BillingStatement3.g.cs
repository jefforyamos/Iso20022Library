﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingStatement3.  ISO2002 ID# _Gfoea24-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the statement reporting the bank services billing.
/// </summary>
public partial record BillingStatement3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the customer billing statement.
    /// </summary>
    public required IsoMax35Text StatementIdentification { get; init; } 
    /// <summary>
    /// Date range between the start date and the end date for which the statement is issued.
    /// </summary>
    public required DatePeriod1 FromToDate { get; init; } 
    /// <summary>
    /// Date the statement message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Defines the status of the statement.
    /// </summary>
    public required BillingStatementStatus1Code Status { get; init; } 
    /// <summary>
    /// Specifies the details of the account characteristics.
    /// </summary>
    public required CashAccountCharacteristics3 AccountCharacteristics { get; init; } 
    /// <summary>
    /// Identifies the non tax per annum rate and factor values used within the statement along with any time dependent charge basis.
    /// </summary>
    public BillingRate1? RateData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies details related to currency exchange data.
    /// </summary>
    public CurrencyExchange6? CurrencyExchange { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the average value of balances held within the statement period.
    /// </summary>
    public BillingBalance1? Balance { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the set of values and totals that are used to provide compensation information, service and tax totals.
    /// </summary>
    public BillingCompensation1? Compensation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the values used for every line item service in the statement.
    /// </summary>
    public BillingService2? Service { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Tax region that levy a tax on the services within this statement.
    /// </summary>
    public BillingTaxRegion2? TaxRegion { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// One or more sections that identify balance or float adjustments to the account. They can reflect either adjustments to the current statement or adjustments to statements from prior reporting periods.
    /// </summary>
    public BalanceAdjustment1? BalanceAdjustment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// One or more sections that identify line item service adjustments to the account. They reflect adjustments to statements from prior reporting periods.
    /// </summary>
    public BillingServiceAdjustment1? ServiceAdjustment { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
