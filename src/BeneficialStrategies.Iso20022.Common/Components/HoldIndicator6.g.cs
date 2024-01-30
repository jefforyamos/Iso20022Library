﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HoldIndicator6.  ISO2002 ID# _yW7v0TqfEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the transaction is on hold/blocked/frozen.
/// </summary>
public partial record HoldIndicator6
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    public required IsoYesNoIndicator Indicator { get; init; } 
    /// <summary>
    /// Specifies the reason of the registration status.
    /// </summary>
    public RegistrationReason5? Reason { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
