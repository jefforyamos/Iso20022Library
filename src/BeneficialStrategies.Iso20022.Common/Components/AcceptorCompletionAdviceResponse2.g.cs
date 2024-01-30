﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCompletionAdviceResponse2.  ISO2002 ID# _A3hccQvXEeKzJ69IWwzB9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acknowledgement by the acquirer, of the completion advice of the card payment at the acceptor.
/// </summary>
public partial record AcceptorCompletionAdviceResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment11 Environment { get; init; } 
    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    public required CardPaymentTransactionAdviceResponse3 Transaction { get; init; } 
    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    public TMSTrigger1? TMSTrigger { get; init; } 
    
    #nullable disable
}
