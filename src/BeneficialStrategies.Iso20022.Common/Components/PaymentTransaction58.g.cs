﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction58.  ISO2002 ID# _rZu7ax72EeSxevWRRWxNAg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
public partial record PaymentTransaction58
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify a cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    public IsoMax35Text? CancellationIdentification { get; init; } 
    /// <summary>
    /// Set of elements to uniquely and unambiguously identify an exception or an investigation workflow.
    /// </summary>
    public Case3? Case { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; } 
    /// <summary>
    /// Date at which the initiating party originally requested the clearing agent to process the payment.
    /// </summary>
    public IsoISODate? OriginalRequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date at which the creditor originally requested the collection of the amount of money from the debtor.
    /// </summary>
    public IsoISODate? OriginalRequestedCollectionDate { get; init; } 
    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    public PaymentCancellationReason2[] CancellationReasonInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference20? OriginalTransactionReference { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
