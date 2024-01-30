﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationByReference.  ISO2002 ID# _r0ZQUxwnEeOIveEnnb_1-A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation6Choice;

/// <summary>
/// Reference of the transfer instruction to be cancelled.
/// </summary>
public partial record CancellationByReference : ICancellation6Choice
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
