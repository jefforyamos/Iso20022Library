﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMEnvironment8.  ISO2002 ID# _PfGckYtLEeSxlKlAGYErFg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the key download.
/// </summary>
public partial record ATMEnvironment8
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
    /// Entity hosting the ATM terminal.
    /// </summary>
    public TerminalHosting1? HostingEntity { get; init; } 
    /// <summary>
    /// ATM information.
    /// </summary>
    public required AutomatedTellerMachine6 ATM { get; init; } 
    
    #nullable disable
}
