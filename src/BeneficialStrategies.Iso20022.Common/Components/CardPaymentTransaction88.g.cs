﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction88.  ISO2002 ID# _9bqvkdedEeiJyp_aycJaTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the authorisation response.
/// </summary>
public partial record CardPaymentTransaction88
{
    #nullable enable
    
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
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
    /// Detail of the transaction transported.
    /// </summary>
    public required CardPaymentTransactionDetails47 TransactionDetails { get; init; } 
    /// <summary>
    /// Merchant related information provided in the request.
    /// </summary>
    public IsoMax70Text? MerchantReferenceData { get; init; } 
    
    #nullable disable
}
