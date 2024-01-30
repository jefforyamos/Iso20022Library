﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyResponse3.  ISO2002 ID# _vPHvcU7XEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response data to a loyalty service request.
/// </summary>
public partial record LoyaltyResponse3
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; } 
    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// </summary>
    public LoyaltyResult3? Result { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
