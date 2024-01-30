﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementInstruction2.  ISO2002 ID# _tiGihVkyEeGeoaLUQk__nA_-836484348.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the settlement of the instruction.
/// </summary>
public partial record SettlementInstruction2
{
    #nullable enable
    
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    public required SettlementMethod2Code SettlementMethod { get; init; } 
    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    public CashAccount24? SettlementAccount { get; init; } 
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    public IClearingSystemIdentification3Choice? ClearingSystem { get; init; } 
    
    #nullable disable
}
