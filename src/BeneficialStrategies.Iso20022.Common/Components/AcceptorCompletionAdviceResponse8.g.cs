﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCompletionAdviceResponse8.  ISO2002 ID# _rXIfkQudEeqw5uEXxQ9H4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acknowledgement by the acquirer, of the completion advice of the card payment at the acceptor.
/// </summary>
public partial record AcceptorCompletionAdviceResponse8
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment74 Environment { get; init; } 
    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    public required CardPaymentTransactionAdviceResponse7 Transaction { get; init; } 
    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    public TMSTrigger1? TMSTrigger { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
