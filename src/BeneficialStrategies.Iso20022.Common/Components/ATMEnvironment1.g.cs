﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMEnvironment1.  ISO2002 ID# _hu8lkIn1EeS9F4Qrq_eaVA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the withdrawal transaction.
/// </summary>
public partial record ATMEnvironment1
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the withdrawal transaction, in charge of the funds settlement with the issuer.
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
    public required AutomatedTellerMachine1 ATM { get; init; } 
    /// <summary>
    /// Customer involved in the withdrawal transaction.
    /// </summary>
    public required ATMCustomer1 Customer { get; init; } 
    /// <summary>
    /// Card performing the withdrawal transaction.
    /// </summary>
    public PaymentCard16? Card { get; init; } 
    
    #nullable disable
}
