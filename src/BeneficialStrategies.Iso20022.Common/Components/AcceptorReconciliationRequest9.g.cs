﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorReconciliationRequest9.  ISO2002 ID# _ZKulQS4_EeunNvJlR_vCbg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation request from an acceptor.
/// </summary>
public partial record AcceptorReconciliationRequest9
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment77 Environment { get; init; } 
    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    public required TransactionReconciliation5 Transaction { get; init; } 
    
    #nullable disable
}
