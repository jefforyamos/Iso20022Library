﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RedemptionMultipleExecution2.  ISO2002 ID# _VXgOOdp-Ed-ak6NoX_4Aeg_1399796950.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption order.
/// </summary>
public partial record RedemptionMultipleExecution2
{
    #nullable enable
    
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    public CountryCode? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    public IsoISODateTime? OrderDateTime { get; init; } 
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    public CancellationRight1? CancellationRight { get; init; } 
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Execution of a redemption order.
    /// </summary>
    public RedemptionExecution4[] IndividualExecutionDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    public PaymentTransaction15? BulkCashSettlementDetails { get; init; } 
    
    #nullable disable
}
