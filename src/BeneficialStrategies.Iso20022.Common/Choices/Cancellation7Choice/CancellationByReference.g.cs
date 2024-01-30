﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationByReference.  ISO2002 ID# _l0CXowgMEeSFYfyUKDXKaw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation7Choice;

/// <summary>
/// Reference of the transfer instruction to be cancelled.
/// </summary>
public partial record CancellationByReference : ICancellation7Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Transfer and cancellation reference.
    /// </summary>
    public TransferReference8? TransferReferences { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
