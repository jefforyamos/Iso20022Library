﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction61.  ISO2002 ID# _B37CkY3QEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the cancellation advice.
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentTransaction61
{
    #nullable enable
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [DataMember]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; } 
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [DataMember]
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [DataMember]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [DataMember]
    public CardPaymentTransaction52? OriginalTransaction { get; init; } 
    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    [DataMember]
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; } 
    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? Reversal { get; init; } 
    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    [DataMember]
    public ValueList<FailureReason3Code> FailureReason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [DataMember]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [DataMember]
    public IsoMax35Text? RecipientTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [DataMember]
    public IsoMax140Text? InterchangeData { get; init; } 
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentTransactionDetails34 TransactionDetails { get; init; } 
    /// <summary>
    /// Outcome of the authorisation.
    /// </summary>
    [DataMember]
    public AuthorisationResult12? AuthorisationResult { get; init; } 
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
