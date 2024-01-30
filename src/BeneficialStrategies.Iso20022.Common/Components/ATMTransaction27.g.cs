﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction27.  ISO2002 ID# _KIj5ca5FEeWCgYcWSNgX5g.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction for which the exception is sent.
/// </summary>
public partial record ATMTransaction27
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public TransactionIdentifier1? TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Exception occurring outside the service.
    /// </summary>
    public FailureReason8Code? Exception { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Explanation of the exception.
    /// </summary>
    public IsoMax70Text? ExceptionDetail { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Balance of the captured card or epurse if available.
    /// </summary>
    public IsoCurrencyAndAmount? ElectronicPurseBalance { get; init; } 
    
    #nullable disable
}
