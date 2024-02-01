﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction60.  ISO2002 ID# _Nnq5IY3OEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the batch capture.
/// </summary>
public partial record CardPaymentTransaction60
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    public CardPaymentServiceType5Code? TransactionType { get; init; } 
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    public CardPaymentServiceType9Code[] AdditionalService { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; } 
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    public CardPaymentTransaction52? OriginalTransaction { get; init; } 
    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; } 
    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    public IsoTrueFalseIndicator? Reversal { get; init; } 
    /// <summary>
    /// Indicate that the acceptor has forced the transaction in spite of the authorisation result (online or offline), or incident to complete the transaction.
    /// </summary>
    public IsoTrueFalseIndicator? MerchantOverride { get; init; } 
    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    public FailureReason3Code[] FailureReason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    public IsoMax35Text? RecipientTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    public IsoMax140Text? InterchangeData { get; init; } 
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    public required CardPaymentTransactionDetails30 TransactionDetails { get; init; } 
    /// <summary>
    /// Outcome of the authorisation request, and actions to perform.
    /// </summary>
    public AuthorisationResult10? AuthorisationResult { get; init; } 
    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    public TransactionVerificationResult4[] TransactionVerificationResult { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    public IsoMax70Text[] AdditionalTransactionData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
