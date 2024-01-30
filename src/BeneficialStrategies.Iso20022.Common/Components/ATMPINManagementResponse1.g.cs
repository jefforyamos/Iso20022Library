﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMPINManagementResponse1.  ISO2002 ID# _-b5YgIrBEeSgLpgNvMAP2g.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM PIN Management from an ATM manager.
/// </summary>
public partial record ATMPINManagementResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the PIN management transaction.
    /// </summary>
    public required ATMEnvironment2 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    public required ATMContext4 Context { get; init; } 
    /// <summary>
    /// Response to the PIN management transaction.
    /// </summary>
    public required ATMTransaction10 Transaction { get; init; } 
    
    #nullable disable
}
