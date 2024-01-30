﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMWithdrawalResponse1.  ISO2002 ID# _UC0koIp1EeS3NqNpgnMh2w.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM withdrawal from an ATM manager.
/// </summary>
public partial record ATMWithdrawalResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the withdrawal transaction.
    /// </summary>
    public required ATMEnvironment2 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    public required ATMContext2 Context { get; init; } 
    /// <summary>
    /// Response to the withdrawal transaction request.
    /// </summary>
    public required ATMTransaction2 Transaction { get; init; } 
    
    #nullable disable
}
