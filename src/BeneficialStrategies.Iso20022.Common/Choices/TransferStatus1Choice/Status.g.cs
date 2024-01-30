﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Status.  ISO2002 ID# _o1CqqBwkEeOIveEnnb_1-A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice;

/// <summary>
/// Status of the transfer is received, accepted, sent to next party, matched, already executed, or settled.
/// </summary>
public partial record Status : ITransferStatus1Choice
{
    #nullable enable
    /// <summary>
    /// Status code.
    /// </summary>
    public required TransferStatus3Code StatusValue { get; init; } 
    /// <summary>
    /// Reason for the status.
    /// </summary>
    public IsoMax350Text? Reason { get; init; } 
    #nullable disable
}
