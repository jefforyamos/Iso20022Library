﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReconciliationReport5.  ISO2002 ID# _CtHU1__oEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data on transaction requiring reconciliation or pairing.
/// </summary>
public partial record ReconciliationReport5
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Information related to transactions that are subject of reconciliation.
    /// </summary>
    public required TradeTransactionIdentification4 TransactionIdentification { get; init; } 
    /// <summary>
    /// Indication whether information was modified.
    /// </summary>
    public required IsoTrueFalseIndicator Modified { get; init; } 
    /// <summary>
    /// Indication whether the reconciliation is required.
    /// </summary>
    public required IReconciliationStatus5Choice ReconciliationStatus { get; init; } 
    
    #nullable disable
}
