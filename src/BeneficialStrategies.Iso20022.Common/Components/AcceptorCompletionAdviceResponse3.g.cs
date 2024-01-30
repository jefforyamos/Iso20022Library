﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCompletionAdviceResponse3.  ISO2002 ID# _TmmLkTJMEeOkpIB9tKITlw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acknowledgement by the acquirer, of the completion advice of the card payment at the acceptor.
/// </summary>
public partial record AcceptorCompletionAdviceResponse3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment21 Environment { get; init; } 
    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    public required CardPaymentTransactionAdviceResponse4 Transaction { get; init; } 
    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    public TMSTrigger1? TMSTrigger { get; init; } 
    
    #nullable disable
}
