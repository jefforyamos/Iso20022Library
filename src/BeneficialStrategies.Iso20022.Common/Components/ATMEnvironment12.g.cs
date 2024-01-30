﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMEnvironment12.  ISO2002 ID# _2LQFQa16EeWMg5rOByfExw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the withdrawal transaction.
/// </summary>
public partial record ATMEnvironment12
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the transactions, in charge of the funds settlement with the issuer.
    /// </summary>
    public Acquirer7? Acquirer { get; init; } 
    /// <summary>
    /// Institution in charge of managing the ATM.
    /// </summary>
    public Acquirer8? ATMManager { get; init; } 
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    public TerminalHosting1? HostingEntity { get; init; } 
    /// <summary>
    /// ATM information.
    /// </summary>
    public required AutomatedTellerMachine2 ATM { get; init; } 
    /// <summary>
    /// Customer involved in the transaction.
    /// </summary>
    public required ATMCustomer5 Customer { get; init; } 
    /// <summary>
    /// Encryption of the sensitive card data.
    /// </summary>
    public ContentInformationType10? ProtectedCardData { get; init; } 
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    public PlainCardData19? PlainCardData { get; init; } 
    
    #nullable disable
}
