﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActionMessage1.  ISO2002 ID# _TEzSkAEcEeCQm6a_G2yO_w_1379249384.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message to be displayed to the cardholder or the cashier.
/// </summary>
public partial record ActionMessage1
{
    #nullable enable
    
    /// <summary>
    /// Destination of the message to be displayed or printed.
    /// </summary>
    public required UserInterface1Code MessageDestination { get; init; } 
    /// <summary>
    /// Text or graphic data to be display or printed to the cardholder or the cashier.
    /// </summary>
    public required IsoMax256Text MessageContent { get; init; } 
    /// <summary>
    /// Electronic signature of the message to display or print.
    /// </summary>
    public IsoMax70Text? MessageContentSignature { get; init; } 
    
    #nullable disable
}
