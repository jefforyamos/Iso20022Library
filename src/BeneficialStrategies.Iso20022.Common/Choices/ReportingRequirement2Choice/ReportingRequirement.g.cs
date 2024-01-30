﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ReportingRequirement.  ISO2002 ID# _IVUQMV55Ee2a_-MvhEjKmA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ReportingRequirement2Choice;

/// <summary>
/// Specifies categories of statuses of a derivative when there is a reporting requirement for both counterparties.
/// </summary>
public partial record ReportingRequirement : IReportingRequirement2Choice
{
    #nullable enable
    /// <summary>
    /// Indicator of receiving only one side or both sides of the derivatives.
    /// </summary>
    public required TradeRepositoryReportingType1Code ReportingType { get; init; } 
    /// <summary>
    /// Indicator of side identification of the same derivative.
    /// </summary>
    public required PairingStatus1Code Pairing { get; init; } 
    /// <summary>
    /// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// </summary>
    public required ReconciliationStatus1Code Reconciliation { get; init; } 
    /// <summary>
    /// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// </summary>
    public required ReconciliationStatus2Code ValuationReconciliation { get; init; } 
    /// <summary>
    /// Indicator of derivative reopening, terminated or cancelled by mistake.
    /// </summary>
    public required IsoYesNoIndicator Revived { get; init; } 
    /// <summary>
    /// Indicator of modification to the terms or details of a previously reported derivative, at a trade or position level, but not a correction of a report.
    /// </summary>
    public required IsoYesNoIndicator FurtherModification { get; init; } 
    #nullable disable
}
