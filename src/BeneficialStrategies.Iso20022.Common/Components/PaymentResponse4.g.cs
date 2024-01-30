﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentResponse4.  ISO2002 ID# _skDv8U0tEeybj420QgWBkA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to respond to a Payment request.
/// </summary>
public partial record PaymentResponse4
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; } 
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    public IsoMax140Text? IssuerReferenceData { get; init; } 
    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    public required RetailerPaymentResult4 RetailerPaymentResult { get; init; } 
    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    public PaymentReceipt4? PaymentReceipt { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// </summary>
    public LoyaltyResult3? LoyaltyResult { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    public CustomerOrder1? CustomerOrder { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
