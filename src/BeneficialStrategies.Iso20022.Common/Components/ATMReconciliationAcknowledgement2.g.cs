﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMReconciliationAcknowledgement2.  ISO2002 ID# _WK71Qa48EeWRfYPBaeOY8w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement of an ATM reconciliation from the ATM. manager.
/// </summary>
public partial record ATMReconciliationAcknowledgement2
{
    #nullable enable
    
    /// <summary>
    /// ATM information.
    /// </summary>
    public required AutomatedTellerMachine3 ATM { get; init; } 
    /// <summary>
    /// Information about the reconciliation response.
    /// </summary>
    public required ATMTransaction26 Transaction { get; init; } 
    
    #nullable disable
}
