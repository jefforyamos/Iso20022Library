﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction62.  ISO2002 ID# _KppsAY3SEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data associated with the transaction to authorise.
/// </summary>
public partial record CardPaymentTransaction62
{
    #nullable enable
    
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    public required IsoTrueFalseIndicator TransactionCapture { get; init; } 
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    public CardPaymentServiceType5Code? TransactionType { get; init; } 
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    public CardPaymentServiceType9Code? AdditionalService { get; init;  } // Warning: Don't know multiplicity.
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
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    public CardPaymentTransaction52? OriginalTransaction { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    public required CardPaymentTransactionDetails31 TransactionDetails { get; init; } 
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    public IsoMax70Text? AdditionalTransactionData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
