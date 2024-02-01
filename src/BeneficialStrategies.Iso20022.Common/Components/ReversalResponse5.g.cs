﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReversalResponse5.  ISO2002 ID# _7Q2AIVS5EeuUvsVXOV79DQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response Data to a Reversal request.
/// </summary>
public partial record ReversalResponse5
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
    /// Result of reversal transaction.
    /// </summary>
    public required RetailerReversalResult3 ReversalTransactionResult { get; init; } 
    /// <summary>
    /// Amount that have been reverse.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    /// <summary>
    /// Various receipts linked to the reversal.
    /// </summary>
    public PaymentReceipt3[] Receipt { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
