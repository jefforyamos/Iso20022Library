﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction5.  ISO2002 ID# _BgABgYqoEeS4a4abTJTSSw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal transaction for which the completion is sent.
/// </summary>
public partial record ATMTransaction5
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Outcome of the financial transaction for the customer.
    /// </summary>
    public required ATMTransactionStatus1Code TransactionStatus { get; init; } 
    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    public FailureReason4Code[] Incident { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    public IsoMax70Text[] IncidentDetail { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    /// <summary>
    /// True if a receipt has been printed and presented to the customer.
    /// </summary>
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; } 
    /// <summary>
    /// True when the card was captured by the ATM.
    /// </summary>
    public IsoTrueFalseIndicator? CapturedCard { get; init; } 
    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    public AuthorisationResult9? AuthorisationResult { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}
