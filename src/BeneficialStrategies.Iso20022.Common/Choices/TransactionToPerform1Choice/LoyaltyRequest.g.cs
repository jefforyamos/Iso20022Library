﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LoyaltyRequest.  ISO2002 ID# _57p-oNuREeiB5uLfkg9ZJA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform1Choice;

/// <summary>
/// Content of the Loyalty Request message.
/// </summary>
public partial record LoyaltyRequest : ITransactionToPerform1Choice
{
    #nullable enable
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    public CustomerOrder1? CustomerOrder { get; init; } 
    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    public required LoyaltyTransaction1 Transaction { get; init; } 
    /// <summary>
    /// Data related to a Loyalty program or account.
    /// </summary>
    public LoyaltyRequestData1? Data { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
