﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMMessageFunction1.  ISO2002 ID# _PEDmAInwEeS9F4Qrq_eaVA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the type of process related to an ATM message.
/// </summary>
public partial record ATMMessageFunction1
{
    #nullable enable
    
    /// <summary>
    /// Type of requested function.
    /// </summary>
    public required MessageFunction7Code Function { get; init; } 
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    public IsoMax35Text? ATMServiceCode { get; init; } 
    /// <summary>
    /// Codification of the type of service for the ATM manager host.
    /// </summary>
    public IsoMax35Text? HostServiceCode { get; init; } 
    
    #nullable disable
}
