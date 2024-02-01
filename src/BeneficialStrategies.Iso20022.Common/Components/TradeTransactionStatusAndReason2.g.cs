﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionStatusAndReason2.  ISO2002 ID# _RXgjh9p-Ed-ak6NoX_4Aeg_587723747.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the transaction with a trade reference and provides its status. If the status is rejected, a reason for this status must be given.
/// </summary>
public partial record TradeTransactionStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the RegulatoryTransactionReportCancellationRequest document that was previously sent by the reporting institution.
    /// </summary>
    public required IsoMax35Text RelatedReference { get; init; } 
    /// <summary>
    /// Unique identification assigned to a trade once it is received or matched by an executing system.
    /// </summary>
    public required IsoMax70Text TradeReference { get; init; } 
    /// <summary>
    /// Indicates the status of an instruction, request or report message.
    /// </summary>
    public required Status2Code Status { get; init; } 
    /// <summary>
    /// Indicates that the cancellation is rejected and provides a reason why.
    /// </summary>
    public RejectedCancellationStatusReason1Choice_[] Rejected { get; init; } = [];
    
    #nullable disable
}
