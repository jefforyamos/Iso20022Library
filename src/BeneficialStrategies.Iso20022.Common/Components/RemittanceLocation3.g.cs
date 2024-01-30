﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceLocation3.  ISO2002 ID# _duvyIaMDEeKl_NvHIICqIw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the remittance advice.
/// </summary>
public partial record RemittanceLocation3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    /// <summary>
    /// Set of elements used to provide information on the location and/or delivery of the remittance information.
    /// </summary>
    public RemittanceLocationDetails1? RemittanceLocationDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the underlying transaction.
    /// </summary>
    public required TransactionReferences4 References { get; init; } 
    
    #nullable disable
}
