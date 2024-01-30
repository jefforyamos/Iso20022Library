﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMEnvironment9.  ISO2002 ID# _-clJMYtqEeSDLd7nI4Quzw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the ATM.
/// </summary>
public partial record ATMEnvironment9
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the ATM transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    public Acquirer7? Acquirer { get; init; } 
    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    public IsoMax35Text? ATMManagerIdentification { get; init; } 
    /// <summary>
    /// ATM information.
    /// </summary>
    public required AutomatedTellerMachine7 ATM { get; init; } 
    
    #nullable disable
}
