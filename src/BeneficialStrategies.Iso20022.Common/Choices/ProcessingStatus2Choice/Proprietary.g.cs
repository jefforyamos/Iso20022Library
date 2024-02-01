﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _UUJ61tp-Ed-ak6NoX_4Aeg_868955795.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus2Choice;

/// <summary>
/// Status that cannot be reported using one of the available standard status.
/// </summary>
public partial record Proprietary : ProcessingStatus2Choice_
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
