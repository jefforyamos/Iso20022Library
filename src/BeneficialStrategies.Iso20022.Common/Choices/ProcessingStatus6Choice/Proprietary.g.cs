﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _UVMcqdp-Ed-ak6NoX_4Aeg_-1089414769.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus6Choice;

/// <summary>
/// Status that cannot be reported using one of the available standard status.
/// </summary>
public partial record Proprietary : ProcessingStatus6Choice_
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    public required GenericIdentification20 ProprietaryStatus { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason1? ProprietaryReason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
