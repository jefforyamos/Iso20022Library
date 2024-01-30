﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInstruction20.  ISO2002 ID# _w_UlZUgtEeaGKYpLDboHPQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reference and status of the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
public partial record OriginalPaymentInstruction20
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    public IsoMax35Text? PaymentCancellationIdentification { get; init; } 
    /// <summary>
    /// Identifies the case.
    /// </summary>
    public Case3? Case { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block, as assigned by the original sending party.
    /// </summary>
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the cancellation payment information group.
    /// </summary>
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the cancellation payment information group, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Indicates whether or not the cancellation applies to a whole group of transactions or to individual transactions within the original group.
    /// </summary>
    public IsoGroupCancellationIndicator? PaymentInformationCancellation { get; init; } 
    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    public PaymentCancellationReason3? CancellationReasonInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    public PaymentTransaction74? TransactionInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
